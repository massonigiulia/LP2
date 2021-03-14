
namespace PSalario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.btnVerificarDesconto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.rdbF = new System.Windows.Forms.RadioButton();
            this.lbEstCivil = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDados = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAliqINSS = new System.Windows.Forms.TextBox();
            this.txtAliqIRPF = new System.Windows.Forms.TextBox();
            this.mskSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.cmbNumFilhos = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.mskSalarioFam = new System.Windows.Forms.MaskedTextBox();
            this.mskSalarioLiq = new System.Windows.Forms.MaskedTextBox();
            this.mskDescINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskDescIRPF = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salário bruto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de filhos";
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(162, 51);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(116, 21);
            this.txtNomeFunc.TabIndex = 1;
            // 
            // btnVerificarDesconto
            // 
            this.btnVerificarDesconto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerificarDesconto.Location = new System.Drawing.Point(36, 180);
            this.btnVerificarDesconto.Name = "btnVerificarDesconto";
            this.btnVerificarDesconto.Size = new System.Drawing.Size(243, 27);
            this.btnVerificarDesconto.TabIndex = 6;
            this.btnVerificarDesconto.Text = "Verifica Desconto";
            this.btnVerificarDesconto.UseVisualStyleBackColor = true;
            this.btnVerificarDesconto.Click += new System.EventHandler(this.btnVerificarDesconto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbM);
            this.groupBox1.Controls.Add(this.rdbF);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(348, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rdbM
            // 
            this.rdbM.AutoSize = true;
            this.rdbM.Location = new System.Drawing.Point(21, 55);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(82, 19);
            this.rdbM.TabIndex = 1;
            this.rdbM.Text = "Masculino";
            this.rdbM.UseVisualStyleBackColor = true;
            // 
            // rdbF
            // 
            this.rdbF.AutoSize = true;
            this.rdbF.Checked = true;
            this.rdbF.Location = new System.Drawing.Point(21, 29);
            this.rdbF.Name = "rdbF";
            this.rdbF.Size = new System.Drawing.Size(77, 19);
            this.rdbF.TabIndex = 0;
            this.rdbF.TabStop = true;
            this.rdbF.Text = "Feminino";
            this.rdbF.UseVisualStyleBackColor = true;
            // 
            // lbEstCivil
            // 
            this.lbEstCivil.FormattingEnabled = true;
            this.lbEstCivil.ItemHeight = 15;
            this.lbEstCivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado"});
            this.lbEstCivil.Location = new System.Drawing.Point(441, 172);
            this.lbEstCivil.Name = "lbEstCivil";
            this.lbEstCivil.Size = new System.Drawing.Size(98, 34);
            this.lbEstCivil.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estado civil";
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(33, 258);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(83, 15);
            this.lblDados.TabIndex = 10;
            this.lblDados.Text = "<Resultados>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Alíquota INSS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Alíquota IRPF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Salário Família";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(324, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Salário Líquido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Desconto INSS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(325, 399);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Desconto IRPF";
            // 
            // txtAliqINSS
            // 
            this.txtAliqINSS.Enabled = false;
            this.txtAliqINSS.Location = new System.Drawing.Point(142, 313);
            this.txtAliqINSS.Name = "txtAliqINSS";
            this.txtAliqINSS.Size = new System.Drawing.Size(116, 21);
            this.txtAliqINSS.TabIndex = 17;
            // 
            // txtAliqIRPF
            // 
            this.txtAliqIRPF.Enabled = false;
            this.txtAliqIRPF.Location = new System.Drawing.Point(142, 354);
            this.txtAliqIRPF.Name = "txtAliqIRPF";
            this.txtAliqIRPF.Size = new System.Drawing.Size(116, 21);
            this.txtAliqIRPF.TabIndex = 18;
            // 
            // mskSalarioBruto
            // 
            this.mskSalarioBruto.Location = new System.Drawing.Point(162, 85);
            this.mskSalarioBruto.Mask = "00000.00";
            this.mskSalarioBruto.Name = "mskSalarioBruto";
            this.mskSalarioBruto.Size = new System.Drawing.Size(116, 21);
            this.mskSalarioBruto.TabIndex = 2;
            // 
            // cmbNumFilhos
            // 
            this.cmbNumFilhos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumFilhos.FormattingEnabled = true;
            this.cmbNumFilhos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbNumFilhos.Location = new System.Drawing.Point(162, 120);
            this.cmbNumFilhos.Name = "cmbNumFilhos";
            this.cmbNumFilhos.Size = new System.Drawing.Size(116, 23);
            this.cmbNumFilhos.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpar.Location = new System.Drawing.Point(453, 456);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 27);
            this.btnLimpar.TabIndex = 25;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // mskSalarioFam
            // 
            this.mskSalarioFam.Enabled = false;
            this.mskSalarioFam.Location = new System.Drawing.Point(142, 396);
            this.mskSalarioFam.Name = "mskSalarioFam";
            this.mskSalarioFam.Size = new System.Drawing.Size(116, 21);
            this.mskSalarioFam.TabIndex = 26;
            // 
            // mskSalarioLiq
            // 
            this.mskSalarioLiq.Enabled = false;
            this.mskSalarioLiq.Location = new System.Drawing.Point(423, 313);
            this.mskSalarioLiq.Name = "mskSalarioLiq";
            this.mskSalarioLiq.Size = new System.Drawing.Size(116, 21);
            this.mskSalarioLiq.TabIndex = 27;
            // 
            // mskDescINSS
            // 
            this.mskDescINSS.Enabled = false;
            this.mskDescINSS.Location = new System.Drawing.Point(423, 354);
            this.mskDescINSS.Name = "mskDescINSS";
            this.mskDescINSS.Size = new System.Drawing.Size(116, 21);
            this.mskDescINSS.TabIndex = 28;
            // 
            // mskDescIRPF
            // 
            this.mskDescIRPF.Enabled = false;
            this.mskDescIRPF.Location = new System.Drawing.Point(423, 396);
            this.mskDescIRPF.Name = "mskDescIRPF";
            this.mskDescIRPF.Size = new System.Drawing.Size(116, 21);
            this.mskDescIRPF.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(582, 508);
            this.Controls.Add(this.mskDescIRPF);
            this.Controls.Add(this.mskDescINSS);
            this.Controls.Add(this.mskSalarioLiq);
            this.Controls.Add(this.mskSalarioFam);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cmbNumFilhos);
            this.Controls.Add(this.mskSalarioBruto);
            this.Controls.Add(this.txtAliqIRPF);
            this.Controls.Add(this.txtAliqINSS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbEstCivil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVerificarDesconto);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cálculo de Salário";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Button btnVerificarDesconto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.RadioButton rdbF;
        private System.Windows.Forms.ListBox lbEstCivil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAliqINSS;
        private System.Windows.Forms.TextBox txtAliqIRPF;
        private System.Windows.Forms.MaskedTextBox mskSalarioBruto;
        private System.Windows.Forms.ComboBox cmbNumFilhos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox mskSalarioFam;
        private System.Windows.Forms.MaskedTextBox mskSalarioLiq;
        private System.Windows.Forms.MaskedTextBox mskDescINSS;
        private System.Windows.Forms.MaskedTextBox mskDescIRPF;
    }
}

