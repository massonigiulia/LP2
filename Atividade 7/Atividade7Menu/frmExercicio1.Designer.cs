
namespace Atividade7Menu
{
    partial class frmExercicio1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTexto = new System.Windows.Forms.RichTextBox();
            this.btnEspacBranco = new System.Windows.Forms.Button();
            this.btnLetraR = new System.Windows.Forms.Button();
            this.btnPares = new System.Windows.Forms.Button();
            this.txtEspacBranco = new System.Windows.Forms.TextBox();
            this.txtLetraR = new System.Windows.Forms.TextBox();
            this.txtPares = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(42, 46);
            this.txtTexto.MaxLength = 100;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(702, 248);
            this.txtTexto.TabIndex = 0;
            this.txtTexto.Text = "";
            // 
            // btnEspacBranco
            // 
            this.btnEspacBranco.Location = new System.Drawing.Point(42, 318);
            this.btnEspacBranco.Name = "btnEspacBranco";
            this.btnEspacBranco.Size = new System.Drawing.Size(112, 52);
            this.btnEspacBranco.TabIndex = 1;
            this.btnEspacBranco.Text = "Quantidade de espaços em branco";
            this.btnEspacBranco.UseVisualStyleBackColor = true;
            this.btnEspacBranco.Click += new System.EventHandler(this.btnEspacBranco_Click);
            // 
            // btnLetraR
            // 
            this.btnLetraR.Location = new System.Drawing.Point(328, 318);
            this.btnLetraR.Name = "btnLetraR";
            this.btnLetraR.Size = new System.Drawing.Size(112, 52);
            this.btnLetraR.TabIndex = 2;
            this.btnLetraR.Text = "Ocorrências da letra \"R\" ou \"r\"";
            this.btnLetraR.UseVisualStyleBackColor = true;
            this.btnLetraR.Click += new System.EventHandler(this.btnLetraR_Click);
            // 
            // btnPares
            // 
            this.btnPares.Location = new System.Drawing.Point(632, 318);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(112, 52);
            this.btnPares.TabIndex = 3;
            this.btnPares.Text = "Ocorrências de um mesmo par de letras";
            this.btnPares.UseVisualStyleBackColor = true;
            this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
            // 
            // txtEspacBranco
            // 
            this.txtEspacBranco.Enabled = false;
            this.txtEspacBranco.Location = new System.Drawing.Point(42, 389);
            this.txtEspacBranco.Name = "txtEspacBranco";
            this.txtEspacBranco.ReadOnly = true;
            this.txtEspacBranco.Size = new System.Drawing.Size(112, 20);
            this.txtEspacBranco.TabIndex = 4;
            // 
            // txtLetraR
            // 
            this.txtLetraR.Enabled = false;
            this.txtLetraR.Location = new System.Drawing.Point(328, 389);
            this.txtLetraR.Name = "txtLetraR";
            this.txtLetraR.ReadOnly = true;
            this.txtLetraR.Size = new System.Drawing.Size(112, 20);
            this.txtLetraR.TabIndex = 5;
            // 
            // txtPares
            // 
            this.txtPares.Enabled = false;
            this.txtPares.Location = new System.Drawing.Point(632, 389);
            this.txtPares.Name = "txtPares";
            this.txtPares.ReadOnly = true;
            this.txtPares.Size = new System.Drawing.Size(112, 20);
            this.txtPares.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Escreva uma frase com 100 letras.";
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPares);
            this.Controls.Add(this.txtLetraR);
            this.Controls.Add(this.txtEspacBranco);
            this.Controls.Add(this.btnPares);
            this.Controls.Add(this.btnLetraR);
            this.Controls.Add(this.btnEspacBranco);
            this.Controls.Add(this.txtTexto);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtTexto;
        private System.Windows.Forms.Button btnEspacBranco;
        private System.Windows.Forms.Button btnLetraR;
        private System.Windows.Forms.Button btnPares;
        private System.Windows.Forms.TextBox txtEspacBranco;
        private System.Windows.Forms.TextBox txtLetraR;
        private System.Windows.Forms.TextBox txtPares;
        private System.Windows.Forms.Label label1;
    }
}