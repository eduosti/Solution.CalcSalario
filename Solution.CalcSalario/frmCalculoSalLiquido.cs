using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using static CalculoSalLiquido;
using IR;
using INSS;
using DEPENDENTE;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OfficeOpenXml.Drawing;


namespace Solution.CalcSalario
{
    public partial class frmCalculoSalLiquido : Form
    {
        private bool bSalvarAlteracaoDataGridInss = false;
        private bool bSalvarAlteracaoDataGridIr = false;
        private bool bSalvarAlteracaoDataGridDependente = false;
        private bool bSalvarAlteracaoDataGridValorMaxINSS = false;

        public frmCalculoSalLiquido()
        {
            InitializeComponent();

            List<InssDados> inssTables = InssDados.LoadInssTable();
            DataGridInss.DataSource = inssTables;

            List<ValorLimiteINSS> ValorLimiteInssList = ValorLimiteINSS.LoadInssValorLimite();
            DataGridValorMaxINSS.DataSource = ValorLimiteInssList;

            List<IRDados> irDadosTable = IRDados.LoadTableIR();
            DataGridIr.DataSource = irDadosTable;

            List<DependenteDados> TableDependente = DependenteDados.LoadDependenteTable();
            DataGridDependente.DataSource = TableDependente;

            for (int i = 1; i <= 10; i++)
            {
                cboDependente.Items.Add(i);
            }

            cboDependente.Text = "0";

        }


        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            string qtdDependenteText = cboDependente.Text;
            int.TryParse(qtdDependenteText, out int varQtdDep);


            Double.TryParse(txtDescontar.Text.Replace(" ", ""), out double varValorDesc);

            Double.TryParse(txtSalario.Text.Replace(" ", ""), out double varSalario);

            SalarioLiquidoResult objCalcSalLiquResult = CalculateSalarioLiquido(varQtdDep, varSalario, varValorDesc);

            lblResultSalario.Text = string.Format("R$ {0:N}", txtSalario.Text);
            lblResultValorDependente.Text = string.Format("R$ {0:N}", objCalcSalLiquResult.ValorTotalDependente);
            lblResultInss.Text = string.Format("R$ {0,00:N}", objCalcSalLiquResult.DeducaoInss);
            lblResultIr.Text = string.Format("R$ {0,00:N}", objCalcSalLiquResult.DeducaoIr);
            lblResultDesconto.Text = string.Format("R$ {0,00:N}", varValorDesc);
            lblResultSalarioLiquido.Text = string.Format("R$ {0,00:N}", objCalcSalLiquResult.SalarioLiquido);


        }
        private void txtDescontar_KeyPress(object sender, EventArgs e)
        {
            if (txtDescontar.Text == "R$ 0,00" || txtDescontar.Text == "0,00")
            {
                txtDescontar.Clear();
            }
        }
        private void txtDescontar_MouseClick(object sender, EventArgs e)
        {
            if (txtDescontar.Text == "R$ 0,00" || txtDescontar.Text == "0,00")
            {
                txtDescontar.Clear();
            }
        }

        private void txtSalario_KeyPress(object sender, EventArgs e)
        {
            if (txtSalario.Text == "R$ 0,00" || txtSalario.Text == "0,00")
            {
                txtSalario.Clear();
            }
        }
        private void txtSalario_MouseClick(object sender, EventArgs e)
        {
            if (txtSalario.Text == "R$ 0,00" || txtSalario.Text == "0,00")
            {
                txtSalario.Clear();
            }
        }

        private void btnLimparTudo_Click(object sender, EventArgs e)
        {

            cboDependente.Text = "0";
            txtDescontar.Text = "0,00";
            txtSalario.Text = "0,00";
            lblResultDesconto.Text = "";
            lblResultInss.Text = "";
            lblResultIr.Text = "";
            lblResultSalario.Text = "";
            lblResultSalarioLiquido.Text = "";
            lblResultValorDependente.Text = "";

        }


        private void DataGridInss_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bSalvarAlteracaoDataGridInss = true;
        }

        private void DataGridIr_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bSalvarAlteracaoDataGridIr = true;
        }

        private void DataGridDependente_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bSalvarAlteracaoDataGridDependente = true;
        }

        private void DataGridValorMaxINSS_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bSalvarAlteracaoDataGridValorMaxINSS = true;
        }


        private void btnSalvarTabelas_Click(object sender, EventArgs e)
        {

            if (!bSalvarAlteracaoDataGridInss && !bSalvarAlteracaoDataGridIr && !bSalvarAlteracaoDataGridDependente && !bSalvarAlteracaoDataGridValorMaxINSS)
            {
                MessageBox.Show("Nenhuma Alteração foi encontrada nas Tabelas de (INSS, IR ou Dependente)! Tente Alterar novamente e em seguida clique novamente no botão de Salvar!", "Não Houve Alterações", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (bSalvarAlteracaoDataGridInss)
            {
                // Prompt the user for confirmation.
                DialogResult result = MessageBox.Show("Deseja realmente salvar as alterações de INSS?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user clicked Yes, save the data.
                if (result == DialogResult.Yes)
                {
                    List<InssDados> inssTables = (List<InssDados>)DataGridInss.DataSource;
                    InssDados.SaveInssTable(inssTables);

                    bSalvarAlteracaoDataGridInss = false;

                    MessageBox.Show("Alteração da tabela INSS realizada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (bSalvarAlteracaoDataGridValorMaxINSS)
            {
                // Prompt the user for confirmation.
                DialogResult result = MessageBox.Show("Deseja realmente salvar as alterações de Valor Máximo INSS?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user clicked Yes, save the data.
                if (result == DialogResult.Yes)
                {
                    List<ValorLimiteINSS> ValorLimiteInssList = (List<ValorLimiteINSS>)DataGridValorMaxINSS.DataSource;
                    ValorLimiteINSS.SaveValorMaxInss(ValorLimiteInssList);

                    bSalvarAlteracaoDataGridValorMaxINSS = false;

                    MessageBox.Show("Alteração da tabela Valor Máximo INSS realizada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            if (bSalvarAlteracaoDataGridIr)
            {
                // Prompt the user for confirmation.
                DialogResult result = MessageBox.Show("Deseja realmente salvar as alterações de IR?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user clicked Yes, save the data.
                if (result == DialogResult.Yes)
                {
                    List<IRDados> IrTable = (List<IRDados>)DataGridIr.DataSource;
                    IRDados.SaveIrTable(IrTable);

                    bSalvarAlteracaoDataGridIr = false;
                    MessageBox.Show("Alteração da tabela IR realizada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (bSalvarAlteracaoDataGridDependente)
            {
                // Prompt the user for confirmation.
                DialogResult result = MessageBox.Show("Deseja realmente salvar as alterações de Dependente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user clicked Yes, save the data.
                if (result == DialogResult.Yes)
                {
                    List<DependenteDados> DependenteTables = (List<DependenteDados>)DataGridDependente.DataSource;
                    DependenteDados.SaveDependenteTable(DependenteTables);

                    bSalvarAlteracaoDataGridDependente = false;


                    MessageBox.Show("Alteração da tabela Dependente realizada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSalvarExcel_Click(object sender, EventArgs e)
        {

            // Cria um novo objeto SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Define as propriedades do SaveFileDialog
            saveFileDialog.Filter = "Arquivos Excel (*.xlsx)|*.xlsx|Todos os arquivos (*.*)|*.*"; // Define os tipos de arquivos que podem ser salvos
            saveFileDialog.Title = "Salvar arquivo Excel"; // Define o título da caixa de diálogo
            saveFileDialog.FileName = "Resultado_" + DateTime.Now.ToString("yyyyMMdd") + DateTime.Now.ToString("hhmm") + ".xlsx"; // Define o nome padrão do arquivo

            // Exibe a caixa de diálogo e obtém a resposta do usuário
            DialogResult result = saveFileDialog.ShowDialog();

            // Verifica se o usuário clicou no botão Salvar
            if (result == DialogResult.OK)
            {

                // Salva o arquivo no caminho especificado pelo usuário
                double salario = Double.Parse((txtSalario.Text.Replace("R$", "")).Trim());
                int dependente = int.Parse(cboDependente.Text);
                double valorDependente = Double.Parse((lblResultValorDependente.Text.Replace("R$", "")).Trim());
                double inss = Double.Parse((lblResultInss.Text.Replace("R$", "")).Trim());
                double ir = Double.Parse((lblResultIr.Text.Replace("R$", "")).Trim());
                double descontar = Double.Parse((txtDescontar.Text.Replace("R$", "")).Trim());
                double salarioLiquido = Double.Parse((lblResultSalarioLiquido.Text.Replace("R$", "")).Trim());


                SalvaDados.SalvaDados.SalvaParaExcel(salario, dependente, valorDependente, inss, ir, descontar, salarioLiquido, saveFileDialog.FileName);
            }
        }
    }
}
