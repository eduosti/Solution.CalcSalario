namespace Solution.CalcSalario
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            txtDependente = new TextBox();
            txtDescontar = new TextBox();
            txtSalario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(12, 456);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(126, 56);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(564, 16);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(637, 271);
            dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(564, 388);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(637, 286);
            dataGridView2.TabIndex = 4;
            // 
            // txtDependente
            // 
            txtDependente.Location = new Point(184, 45);
            txtDependente.Name = "txtDependente";
            txtDependente.Size = new Size(100, 23);
            txtDependente.TabIndex = 5;
            txtDependente.TextChanged += textBox1_TextChanged;
            // 
            // txtDescontar
            // 
            txtDescontar.Location = new Point(184, 87);
            txtDescontar.Name = "txtDescontar";
            txtDescontar.Size = new Size(100, 23);
            txtDescontar.TabIndex = 6;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(184, 126);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 360);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 8;
            label1.Text = "Salário Líquido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(149, 15);
            label2.TabIndex = 9;
            label2.Text = "Quantidade Dependente(s)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 10;
            label3.Text = "Valor à Descontar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 129);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 11;
            label4.Text = "Salário";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 207);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 12;
            label5.Text = "Salário";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 239);
            label6.Name = "label6";
            label6.Size = new Size(141, 15);
            label6.TabIndex = 13;
            label6.Text = "Valor Total Dependente(s)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 272);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 14;
            label7.Text = "INSS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 303);
            label8.Name = "label8";
            label8.Size = new Size(24, 15);
            label8.TabIndex = 15;
            label8.Text = "IRR";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 332);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 16;
            label9.Text = "Valor Desconto";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(184, 174);
            label10.Name = "label10";
            label10.Size = new Size(105, 15);
            label10.TabIndex = 17;
            label10.Text = "Valores Calculados";
            // 
            // lblResultSalario
            // 
            lblResultSalario.AutoSize = true;
            lblResultSalario.Location = new Point(184, 207);
            lblResultSalario.Name = "lblResultSalario";
            lblResultSalario.Size = new Size(0, 15);
            lblResultSalario.TabIndex = 18;
            // 
            // lblResultValorDependente
            // 
            lblResultValorDependente.AutoSize = true;
            lblResultValorDependente.Location = new Point(184, 239);
            lblResultValorDependente.Name = "lblResultValorDependente";
            lblResultValorDependente.Size = new Size(0, 15);
            lblResultValorDependente.TabIndex = 19;
            // 
            // lblResultInss
            // 
            lblResultInss.AutoSize = true;
            lblResultInss.Location = new Point(184, 272);
            lblResultInss.Name = "lblResultInss";
            lblResultInss.Size = new Size(0, 15);
            lblResultInss.TabIndex = 20;
            // 
            // lblResultIr
            // 
            lblResultIr.AutoSize = true;
            lblResultIr.Location = new Point(184, 303);
            lblResultIr.Name = "lblResultIr";
            lblResultIr.Size = new Size(0, 15);
            lblResultIr.TabIndex = 21;
            // 
            // lblResultDesconto
            // 
            lblResultDesconto.AutoSize = true;
            lblResultDesconto.Location = new Point(184, 332);
            lblResultDesconto.Name = "lblResultDesconto";
            lblResultDesconto.Size = new Size(0, 15);
            lblResultDesconto.TabIndex = 22;
            // 
            // lblResultSalarioLiquido
            // 
            lblResultSalarioLiquido.AutoSize = true;
            lblResultSalarioLiquido.Location = new Point(184, 360);
            lblResultSalarioLiquido.Name = "lblResultSalarioLiquido";
            lblResultSalarioLiquido.Size = new Size(0, 15);
            lblResultSalarioLiquido.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 754);
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
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSalario);
            Controls.Add(txtDescontar);
            Controls.Add(txtDependente);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(btnCalculate);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox txtDependente;
        private TextBox txtDescontar;
        private TextBox txtSalario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
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
    }
}
