using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadora
{
    public partial class Form1 : Form
    {
        double num1, num2, resultado;
        public Form1()
        {
            InitializeComponent();            
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum1.Text, out num1) || !double.TryParse(txtNum2.Text, out num2))
                MessageBox.Show("Valores inválidos");

            else
            {
                resultado = num1 + num2;
                txtResultado.Text = resultado.ToString("N2");
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum1.Text, out num1) || !double.TryParse(txtNum2.Text, out num2))
                MessageBox.Show("Valores inválidos");

            else
            {
                resultado = num1 - num2;
                txtResultado.Text = resultado.ToString("N2");
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum1.Text, out num1) && !double.TryParse(txtNum2.Text, out num2))
                MessageBox.Show("Valores inválidos");

            else
            {
                resultado = num1 * num2;
                txtResultado.Text = resultado.ToString("N2");
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out num1) && double.TryParse(txtNum2.Text, out num2))
                if (num2 == 0)
                {   
                    MessageBox.Show("Não é possível fazer divisão por zero!");                  
                }
                else
                {
                    resultado = num1 / num2;
                    txtResultado.Text = resultado.ToString("N2");
                }

            else               
                MessageBox.Show("Valores inválidos");              
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
            txtNum1.Focus();          
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
