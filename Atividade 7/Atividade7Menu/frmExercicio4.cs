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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double salarioBruto, producao, gratificacao;
            double a, b = 0, c = 0, d = 0;

            if (double.TryParse(txtSalario.Text, out a) &&
                double.TryParse(txtGratificacao.Text, out gratificacao) &&
                double.TryParse(txtProducao.Text, out producao))
            {
              
                if (producao >= 100)
                    b = 1;
                if (producao >= 120)
                    c = 1;
                if (producao >= 150)
                    d = 1;

                salarioBruto = a + a * (0.05 * b + 0.1 * c + 0.1 * d) + gratificacao;

                if (salarioBruto > 7000)
                {
                    if (!(producao >= 150) && !(gratificacao > 0))
                    {
                        salarioBruto = 7000;
                    }                   
                }

                txtSalarioBruto.Text = salarioBruto.ToString("N2");
            }

            else
            {
                MessageBox.Show("Valores inválidos.");
            }
        }  
    }
}
