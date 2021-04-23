
namespace PTesteMetodos
{
    partial class frmExercicio4
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
            this.rtxtbCaracter = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNumerico = new System.Windows.Forms.Button();
            this.btnPosBranco = new System.Windows.Forms.Button();
            this.btnAlfabetico = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtPosBranco = new System.Windows.Forms.TextBox();
            this.txtAlfab = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtxtbCaracter
            // 
            this.rtxtbCaracter.Location = new System.Drawing.Point(29, 39);
            this.rtxtbCaracter.Name = "rtxtbCaracter";
            this.rtxtbCaracter.Size = new System.Drawing.Size(500, 96);
            this.rtxtbCaracter.TabIndex = 0;
            this.rtxtbCaracter.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Preencha a caixa abaixo com caracteres.";
            // 
            // btnNumerico
            // 
            this.btnNumerico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumerico.Location = new System.Drawing.Point(29, 151);
            this.btnNumerico.Name = "btnNumerico";
            this.btnNumerico.Size = new System.Drawing.Size(126, 47);
            this.btnNumerico.TabIndex = 2;
            this.btnNumerico.Text = "Caracteres Numéricos";
            this.btnNumerico.UseVisualStyleBackColor = true;
            this.btnNumerico.Click += new System.EventHandler(this.btnNumerico_Click);
            // 
            // btnPosBranco
            // 
            this.btnPosBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosBranco.Location = new System.Drawing.Point(218, 151);
            this.btnPosBranco.Name = "btnPosBranco";
            this.btnPosBranco.Size = new System.Drawing.Size(126, 47);
            this.btnPosBranco.TabIndex = 3;
            this.btnPosBranco.Text = "Posição 1º Caracter Branco";
            this.btnPosBranco.UseVisualStyleBackColor = true;
            this.btnPosBranco.Click += new System.EventHandler(this.btnPosBranco_Click);
            // 
            // btnAlfabetico
            // 
            this.btnAlfabetico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlfabetico.Location = new System.Drawing.Point(403, 151);
            this.btnAlfabetico.Name = "btnAlfabetico";
            this.btnAlfabetico.Size = new System.Drawing.Size(126, 47);
            this.btnAlfabetico.TabIndex = 4;
            this.btnAlfabetico.Text = "Caracteres Alfabéticos";
            this.btnAlfabetico.UseVisualStyleBackColor = true;
            this.btnAlfabetico.Click += new System.EventHandler(this.btnAlfabetico_Click);
            // 
            // txtNum
            // 
            this.txtNum.Enabled = false;
            this.txtNum.Location = new System.Drawing.Point(29, 204);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(126, 20);
            this.txtNum.TabIndex = 5;
            // 
            // txtPosBranco
            // 
            this.txtPosBranco.Enabled = false;
            this.txtPosBranco.Location = new System.Drawing.Point(218, 204);
            this.txtPosBranco.Name = "txtPosBranco";
            this.txtPosBranco.ReadOnly = true;
            this.txtPosBranco.Size = new System.Drawing.Size(126, 20);
            this.txtPosBranco.TabIndex = 6;
            // 
            // txtAlfab
            // 
            this.txtAlfab.Enabled = false;
            this.txtAlfab.Location = new System.Drawing.Point(403, 204);
            this.txtAlfab.Name = "txtAlfab";
            this.txtAlfab.ReadOnly = true;
            this.txtAlfab.Size = new System.Drawing.Size(126, 20);
            this.txtAlfab.TabIndex = 7;
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 252);
            this.Controls.Add(this.txtAlfab);
            this.Controls.Add(this.txtPosBranco);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnAlfabetico);
            this.Controls.Add(this.btnPosBranco);
            this.Controls.Add(this.btnNumerico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtbCaracter);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtbCaracter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNumerico;
        private System.Windows.Forms.Button btnPosBranco;
        private System.Windows.Forms.Button btnAlfabetico;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtPosBranco;
        private System.Windows.Forms.TextBox txtAlfab;
    }
}