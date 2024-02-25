using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Solution.CalcSalario
{
    public partial class Form1 : Form
    {

        private List<InssTable> inssTables = new List<InssTable>();

        private List<IrTable> IrTables = new List<IrTable>();

        private List<DependenteTable> DependenteTables = new List<DependenteTable>();

        public Form1()
        {
            InitializeComponent();

            LoadInssTable();

            LoadTableIR();

            LoadTableDependente();


        }

        private void LoadInssTable()
        {
            // Load the INSS table from a file, database, or other storage
            // For example, using a JSON file:
            string json = File.ReadAllText("inssTable.json");
            List<InssTable> inssTables = JsonConvert.DeserializeObject<List<InssTable>>(json);

            // Display the INSS table in the DataGridView
            dataGridView1.DataSource = inssTables;
        }

        private void LoadTableIR()
        {
            // Load the INSS table from a file, database, or other storage
            // For example, using a JSON file:
            string json2 = File.ReadAllText("IRTable.json");
            List<IrTable> IrTables = JsonConvert.DeserializeObject<List<IrTable>>(json2);


            // Display the INSS table in the DataGridView
            dataGridView2.DataSource = IrTables;
        }

        private void LoadTableDependente()
        {
            // Load the INSS table from a file, database, or other storage
            // For example, using a JSON file:
            string json3 = File.ReadAllText("DependenteTable.json");
            List<DependenteTable> dependenteTables = JsonConvert.DeserializeObject<List<DependenteTable>>(json3);

        }

        private void SaveInssTable()
        {
            // Save the INSS table to a file, database, or other storage
            // For example, using a JSON file:
            string json = JsonConvert.SerializeObject(inssTables);
            File.WriteAllText("inssTable.json", json);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SaveInssTable();
        }

        public double CalculateSalarioLiquido(double Salario)
        {

            string json = File.ReadAllText("inssTable.json");
            List<InssTable> inssTables = JsonConvert.DeserializeObject<List<InssTable>>(json);

            string json2 = File.ReadAllText("IRTable.json");
            List<IrTable> IrTables = JsonConvert.DeserializeObject<List<IrTable>>(json2);

            string json3 = File.ReadAllText("DependenteTable.json");
            List<DependenteTable> DependenteTables = JsonConvert.DeserializeObject<List<DependenteTable>>(json3);

            double DeducaoInss = 0;

            foreach (var inssTable in inssTables)
            {
                if (Salario >= inssTable.MinSalary && Salario <= inssTable.MaxSalary)
                {
                    DeducaoInss += Math.Round(((Salario * inssTable.Percentage) / 100) - inssTable.FixedValue,2);

                }
            }

            double DeducaoIr = 0;
            

            string qtdDependenteText = txtDependente.Text;
            int.TryParse(qtdDependenteText, out int qtdDependenteInt);
            double ValorTotalDependente = 0;
            

            foreach (var DepTable in DependenteTables)
            {
                ValorTotalDependente = qtdDependenteInt * DepTable.ValorDependente;
            }

            double SalarioBase = Salario - DeducaoInss - ValorTotalDependente;

            foreach (var irTable in IrTables)
            {
                if (SalarioBase >= irTable.MenorBaseDeCalculo && SalarioBase <= irTable.MaiorBaseDeCalculo)
                {
                    DeducaoIr = Math.Round(((SalarioBase * irTable.Aliquota) / 100) - irTable.ParcelaADeduzirDoIR,2); // - dependente

                }
            }

            string ValorDescontar = txtDescontar.Text;
            double.TryParse(ValorDescontar, out double ValorDescontarDouble);
            

            double salarioLiquido = Math.Round(Salario - DeducaoInss - DeducaoIr - ValorDescontarDouble, 2);

            lblResultValorDependente.Text = ValorTotalDependente.ToString();
            lblResultInss.Text = DeducaoInss.ToString();
            lblResultIr.Text = DeducaoIr.ToString();
            lblResultDesconto.Text = ValorDescontar.ToString();
            
            return salarioLiquido;
        }
       
        private void btnCalculate_Click_1(object sender, EventArgs e)
        {

            double salary = Convert.ToDouble(txtSalario.Text);
            double SalarioLiquido = CalculateSalarioLiquido(salary);


            lblResultSalario.Text = salary.ToString();
            lblResultSalarioLiquido.Text = SalarioLiquido.ToString();

        }
    }
}
