using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        double altura, peso, resultado = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(mskAltura.Text, out altura) || !double.TryParse(mskPeso.Text, out peso))
            {
                MessageBox.Show("Valores inválidos");
            }
            else 
            { 
                if (rdbFeminino.Checked)
                {
                    resultado = (62.1 * altura) - 44.7;
                    resultado = Math.Round(resultado, 2);
                    if (resultado == peso)
                    {
                        MessageBox.Show("Você está no peso ideal!");
                    }
                    else if (peso > resultado)
                    {
                        MessageBox.Show("Você está acima do peso!");
                    }
                    else
                    {
                        MessageBox.Show("Você está abaixo do peso");
                    }
                }
                else
                {
                    resultado = (72.7 * altura) - 58;
                    resultado = Math.Round(resultado, 2);
                    if (resultado == peso)
                    {
                        MessageBox.Show("Você está no peso ideal!");
                    }
                    else if (peso > resultado)
                    {
                        MessageBox.Show("Você está acima do peso!");
                    }
                    else
                    {
                        MessageBox.Show("Você está abaixo do peso");
                    }
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskAltura.Clear();
            mskPeso.Clear();
            mskAltura.Focus();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
