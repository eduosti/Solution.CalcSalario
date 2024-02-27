using Solution.CalcSalario.IR;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using static CalculoSalLiquido;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Solution.CalcSalario
{
    public partial class frmCalculoSalLiquido : Form
    {
        private bool bSalvarAlteracaoDataGridInss = false;
        private bool bSalvarAlteracaoDataGridIr = false;
        private bool bSalvarAlteracaoDataGridDependente = false;

        public frmCalculoSalLiquido()
        {
            InitializeComponent();

            List<InssDados> inssTables = InssDados.LoadInssTable();
            DataGridInss.DataSource = inssTables;

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
            lblResultIr.Text = string.Format("R$ {0,00:N}", objCalcSalLiquResult.DeducaoIr.ToString());
            lblResultDesconto.Text = string.Format("R$ {0,00:N}", varValorDesc);
            lblResultSalarioLiquido.Text = string.Format("R$ {0,00:N}", varSalario);

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


        private void btnSalvarTabelas_Click(object sender, EventArgs e)
        {

            if (!bSalvarAlteracaoDataGridInss && !bSalvarAlteracaoDataGridIr && !bSalvarAlteracaoDataGridDependente)
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

                    MessageBox.Show("Alteração da tabela INSS realizada com sucesso!", "Sucesso!", MessageBoxButtons.OK,MessageBoxIcon.Information);
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

      
    }
}
