using System.ComponentModel;
using System.Windows.Forms;

namespace Solution.CalcSalario
{
    partial class frmCalculoSalLiquido
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalculate = new Button();
            DataGridInss = new DataGridView();
            DataGridIr = new DataGridView();
            txtDescontar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lblResultSalario = new Label();
            lblResultValorDependente = new Label();
            lblResultInss = new Label();
            lblResultIr = new Label();
            lblResultDesconto = new Label();
            lblResultSalarioLiquido = new Label();
            DataGridDependente = new DataGridView();
            cboDependente = new ComboBox();
            label11 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            btnLimparTudo = new Button();
            btnSalvarTabelas = new Button();
            label19 = new Label();
            btnSalvarExcel = new Button();
            DataGridValorMaxINSS = new DataGridView();
            label12 = new Label();
            label4 = new Label();
            txtSalario = new TextBox();
            ((ISupportInitialize)DataGridInss).BeginInit();
            ((ISupportInitialize)DataGridIr).BeginInit();
            ((ISupportInitialize)DataGridDependente).BeginInit();
            ((ISupportInitialize)DataGridValorMaxINSS).BeginInit();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(11, 441);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(126, 56);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click_1;
            // 
            // DataGridInss
            // 
            DataGridInss.BackgroundColor = SystemColors.Control;
            DataGridInss.BorderStyle = BorderStyle.None;
            DataGridInss.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridInss.Location = new Point(450, 12);
            DataGridInss.Name = "DataGridInss";
            DataGridInss.Size = new Size(450, 160);
            DataGridInss.TabIndex = 6;
            DataGridInss.CellEndEdit += DataGridInss_CellEndEdit;
            // 
            // DataGridIr
            // 
            DataGridIr.BackgroundColor = SystemColors.Control;
            DataGridIr.BorderStyle = BorderStyle.None;
            DataGridIr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridIr.Location = new Point(450, 178);
            DataGridIr.Name = "DataGridIr";
            DataGridIr.Size = new Size(450, 168);
            DataGridIr.TabIndex = 7;
            DataGridIr.CellEndEdit += DataGridIr_CellEndEdit;
            // 
            // txtDescontar
            // 
            txtDescontar.Location = new Point(249, 110);
            txtDescontar.Name = "txtDescontar";
            txtDescontar.Size = new Size(121, 23);
            txtDescontar.TabIndex = 2;
            txtDescontar.Text = "0,00";
            txtDescontar.MouseClick += txtDescontar_MouseClick;
            txtDescontar.KeyPress += txtDescontar_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 385);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 8;
            label1.Text = "Salário Líquido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 152);
            label2.Name = "label2";
            label2.Size = new Size(149, 15);
            label2.TabIndex = 9;
            label2.Text = "Quantidade Dependente(s)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 113);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 10;
            label3.Text = "Valor à Descontar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 232);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 12;
            label5.Text = "Salário";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 264);
            label6.Name = "label6";
            label6.Size = new Size(141, 15);
            label6.TabIndex = 13;
            label6.Text = "Valor Total Dependente(s)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 297);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 14;
            label7.Text = "INSS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 328);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 15;
            label8.Text = "IRRF";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 357);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 16;
            label9.Text = "Valor Desconto";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(250, 199);
            label10.Name = "label10";
            label10.Size = new Size(105, 15);
            label10.TabIndex = 17;
            label10.Text = "Valores Calculados";
            // 
            // lblResultSalario
            // 
            lblResultSalario.AutoSize = true;
            lblResultSalario.Location = new Point(250, 232);
            lblResultSalario.Name = "lblResultSalario";
            lblResultSalario.Size = new Size(0, 15);
            lblResultSalario.TabIndex = 18;
            // 
            // lblResultValorDependente
            // 
            lblResultValorDependente.AutoSize = true;
            lblResultValorDependente.Location = new Point(250, 264);
            lblResultValorDependente.Name = "lblResultValorDependente";
            lblResultValorDependente.Size = new Size(0, 15);
            lblResultValorDependente.TabIndex = 19;
            // 
            // lblResultInss
            // 
            lblResultInss.AutoSize = true;
            lblResultInss.Location = new Point(250, 297);
            lblResultInss.Name = "lblResultInss";
            lblResultInss.Size = new Size(0, 15);
            lblResultInss.TabIndex = 20;
            // 
            // lblResultIr
            // 
            lblResultIr.AutoSize = true;
            lblResultIr.Location = new Point(250, 328);
            lblResultIr.Name = "lblResultIr";
            lblResultIr.Size = new Size(0, 15);
            lblResultIr.TabIndex = 21;
            // 
            // lblResultDesconto
            // 
            lblResultDesconto.AutoSize = true;
            lblResultDesconto.Location = new Point(250, 357);
            lblResultDesconto.Name = "lblResultDesconto";
            lblResultDesconto.Size = new Size(0, 15);
            lblResultDesconto.TabIndex = 22;
            // 
            // lblResultSalarioLiquido
            // 
            lblResultSalarioLiquido.AutoSize = true;
            lblResultSalarioLiquido.Location = new Point(250, 385);
            lblResultSalarioLiquido.Name = "lblResultSalarioLiquido";
            lblResultSalarioLiquido.Size = new Size(0, 15);
            lblResultSalarioLiquido.TabIndex = 23;
            // 
            // DataGridDependente
            // 
            DataGridDependente.BackgroundColor = SystemColors.Control;
            DataGridDependente.BorderStyle = BorderStyle.None;
            DataGridDependente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridDependente.Location = new Point(450, 352);
            DataGridDependente.Name = "DataGridDependente";
            DataGridDependente.Size = new Size(228, 50);
            DataGridDependente.TabIndex = 8;
            DataGridDependente.CellEndEdit += DataGridDependente_CellEndEdit;
            // 
            // cboDependente
            // 
            cboDependente.FormattingEnabled = true;
            cboDependente.Location = new Point(249, 149);
            cboDependente.Name = "cboDependente";
            cboDependente.Size = new Size(121, 23);
            cboDependente.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(226, 113);
            label11.Name = "label11";
            label11.Size = new Size(23, 15);
            label11.TabIndex = 26;
            label11.Text = "R$ ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(221, 232);
            label13.Name = "label13";
            label13.Size = new Size(23, 15);
            label13.TabIndex = 28;
            label13.Text = "R$ ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(221, 264);
            label14.Name = "label14";
            label14.Size = new Size(23, 15);
            label14.TabIndex = 29;
            label14.Text = "R$ ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(221, 297);
            label15.Name = "label15";
            label15.Size = new Size(23, 15);
            label15.TabIndex = 30;
            label15.Text = "R$ ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(221, 328);
            label16.Name = "label16";
            label16.Size = new Size(23, 15);
            label16.TabIndex = 31;
            label16.Text = "R$ ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(221, 357);
            label17.Name = "label17";
            label17.Size = new Size(23, 15);
            label17.TabIndex = 32;
            label17.Text = "R$ ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(221, 385);
            label18.Name = "label18";
            label18.Size = new Size(23, 15);
            label18.TabIndex = 33;
            label18.Text = "R$ ";
            // 
            // btnLimparTudo
            // 
            btnLimparTudo.Location = new Point(301, 441);
            btnLimparTudo.Name = "btnLimparTudo";
            btnLimparTudo.Size = new Size(126, 56);
            btnLimparTudo.TabIndex = 6;
            btnLimparTudo.Text = "Limpar Tudo";
            btnLimparTudo.UseVisualStyleBackColor = true;
            btnLimparTudo.Click += btnLimparTudo_Click;
            // 
            // btnSalvarTabelas
            // 
            btnSalvarTabelas.Location = new Point(450, 441);
            btnSalvarTabelas.Name = "btnSalvarTabelas";
            btnSalvarTabelas.Size = new Size(126, 56);
            btnSalvarTabelas.TabIndex = 7;
            btnSalvarTabelas.Text = "Salvar Modificações da Tabela";
            btnSalvarTabelas.UseVisualStyleBackColor = true;
            btnSalvarTabelas.Click += btnSalvarTabelas_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(27, 12);
            label19.Name = "label19";
            label19.Size = new Size(362, 32);
            label19.TabIndex = 34;
            label19.Text = "Calculadora de Salário Líquido";
            // 
            // btnSalvarExcel
            // 
            btnSalvarExcel.Location = new Point(155, 441);
            btnSalvarExcel.Name = "btnSalvarExcel";
            btnSalvarExcel.Size = new Size(126, 56);
            btnSalvarExcel.TabIndex = 5;
            btnSalvarExcel.Text = "Salvar Resultado Calculado Excel";
            btnSalvarExcel.UseVisualStyleBackColor = true;
            btnSalvarExcel.Click += btnSalvarExcel_Click;
            // 
            // DataGridValorMaxINSS
            // 
            DataGridValorMaxINSS.BackgroundColor = SystemColors.Control;
            DataGridValorMaxINSS.BorderStyle = BorderStyle.None;
            DataGridValorMaxINSS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridValorMaxINSS.Location = new Point(684, 350);
            DataGridValorMaxINSS.Name = "DataGridValorMaxINSS";
            DataGridValorMaxINSS.Size = new Size(216, 50);
            DataGridValorMaxINSS.TabIndex = 35;
            DataGridValorMaxINSS.CellEndEdit += DataGridValorMaxINSS_CellEndEdit;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(226, 69);
            label12.Name = "label12";
            label12.Size = new Size(23, 15);
            label12.TabIndex = 38;
            label12.Text = "R$ ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 69);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 37;
            label4.Text = "Salário";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(249, 66);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(121, 23);
            txtSalario.TabIndex = 1;
            txtSalario.Text = "0,00";
            // 
            // frmCalculoSalLiquido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 509);
            Controls.Add(label12);
            Controls.Add(label4);
            Controls.Add(txtSalario);
            Controls.Add(DataGridValorMaxINSS);
            Controls.Add(btnSalvarExcel);
            Controls.Add(label19);
            Controls.Add(btnSalvarTabelas);
            Controls.Add(btnLimparTudo);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(cboDependente);
            Controls.Add(DataGridDependente);
            Controls.Add(lblResultSalarioLiquido);
            Controls.Add(lblResultDesconto);
            Controls.Add(lblResultIr);
            Controls.Add(lblResultInss);
            Controls.Add(lblResultValorDependente);
            Controls.Add(lblResultSalario);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescontar);
            Controls.Add(DataGridIr);
            Controls.Add(DataGridInss);
            Controls.Add(btnCalculate);
            Name = "frmCalculoSalLiquido";
            Text = "Calculadora de Salário Líquido";
            ((ISupportInitialize)DataGridInss).EndInit();
            ((ISupportInitialize)DataGridIr).EndInit();
            ((ISupportInitialize)DataGridDependente).EndInit();
            ((ISupportInitialize)DataGridValorMaxINSS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private DataGridView DataGridInss;
        private DataGridView DataGridIr;
        private TextBox txtDescontar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lblResultSalario;
        private Label lblResultValorDependente;
        private Label lblResultInss;
        private Label lblResultIr;
        private Label lblResultDesconto;
        private Label lblResultSalarioLiquido;
        private DataGridView DataGridDependente;
        private ComboBox cboDependente;
        private Label label11;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Button btnLimparTudo;
        private Button btnSalvarTabelas;
        private Label label19;
        private Button btnSalvarExcel;
        private DataGridView DataGridValorMaxINSS;
        private Label label12;
        private Label label4;
        private TextBox txtSalario;
    }
}
