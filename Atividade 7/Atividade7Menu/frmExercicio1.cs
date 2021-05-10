using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade7Menu
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnEspacBranco_Click(object sender, EventArgs e)
        {
            int quantidade = 0;

            for (int caracter = 0; caracter < txtTexto.Text.Length; caracter++)
            {
                if (char.IsWhiteSpace(txtTexto.Text[caracter]))
                    quantidade++;
            }

            txtEspacBranco.Text = quantidade.ToString();
        }

        private void btnLetraR_Click(object sender, EventArgs e)
        {
            string text = txtTexto.Text;
            var count = text.Split('R', 'r');
            txtLetraR.Text = (Convert.ToString(count.Length - 1));
        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            int pares = 0;
            string text = txtTexto.Text;

            for (int letra = 0; letra < text.Length - 1; letra++)
            {
                if (text[letra] == text[letra + 1])
                    pares++;
            }

            txtPares.Text = pares.ToString();
        }
    }
}
