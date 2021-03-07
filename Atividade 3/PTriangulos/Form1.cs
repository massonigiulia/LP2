using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTriangulos
{
    public partial class Form1 : Form
    {
        double ladoA, ladoB, ladoC;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtA.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //verificar se são números
            if (double.TryParse(txtA.Text, out ladoA) && double.TryParse(txtB.Text, out ladoB) && double.TryParse(txtC.Text, out ladoC))
            {
                //verificar se podem ser lados de um triângulo
                if ((ladoB - ladoC) < ladoA && ladoA < ladoB + ladoC && (ladoA - ladoC) < ladoB && ladoB < ladoA + ladoC &&(ladoA - ladoB) < ladoC && ladoC < ladoA + ladoB)
                {
                    if ((ladoA == ladoB) && (ladoC == ladoB))
                    {
                        MessageBox.Show("Equilátero.");
                    }
                    else
                    {
                        if ((ladoA != ladoB) && (ladoB != ladoC) && (ladoC != ladoA))
                        {
                            MessageBox.Show("Escaleno.");
                        }
                        else
                        {
                            MessageBox.Show("Isósceles.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Valores inválidos!");
                }
            }
            else
            {
                MessageBox.Show("Digite apenas números!");
            }
        }
    }
}
