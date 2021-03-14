using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbEstCivil.SelectedIndex = 0;
            cmbNumFilhos.SelectedIndex = 0;
        }

        private void btnVerificarDesconto_Click(object sender, EventArgs e)
        {
            lblDados.Visible = true;
            double salarioBruto = 0;

            if ((txtNomeFunc.Text == "") || (txtNomeFunc.Text.Length < 5))
            {
                MessageBox.Show("Nome Inválido!");
            }
            else if (!double.TryParse(mskSalarioBruto.Text, out salarioBruto))
            {
                MessageBox.Show("Salário Inválido!");
            }
            else
            {
                double descontoInss = 0;
                double descontoIrpf = 0;
                double salarioFamilia = 0;
                double salarioLiquido = 0;

                //inss
                if (salarioBruto <= 800.47)
                {
                    txtAliqINSS.Text = "7.65%";
                    descontoInss = 0.0765 * salarioBruto;
                    mskDescINSS.Text = descontoInss.ToString();
                }
                else if (salarioBruto <= 1050)
                {
                    txtAliqINSS.Text = "8.65%";
                    descontoInss = 0.0865 * salarioBruto;
                    mskDescINSS.Text = descontoInss.ToString();
                }
                else if (salarioBruto <= 1400.77)
                {
                    txtAliqINSS.Text = "9.00%";
                    descontoInss = 0.09 * salarioBruto;
                    mskDescINSS.Text = descontoInss.ToString();
                }
                else if (salarioBruto <= 2801.56)
                {
                    txtAliqINSS.Text = "11%";
                    descontoInss = 0.11 * salarioBruto;
                    mskDescINSS.Text = descontoInss.ToString();
                }
                else
                {
                    txtAliqINSS.Text = "Teto";
                    descontoInss = 308.17;
                    mskDescINSS.Text = descontoInss.ToString();
                }

                mskDescINSS.Text = descontoInss.ToString("N2");

                //irpf
                if (salarioBruto <= 1257.12)
                {
                    txtAliqIRPF.Text = "Isento";
                    descontoIrpf = 0;
                    mskDescIRPF.Text = descontoIrpf.ToString();
                }
                else if (salarioBruto <= 2512.08)
                {
                    txtAliqIRPF.Text = "15%";
                    descontoIrpf = 0.15 * salarioBruto;
                    mskDescIRPF.Text = descontoIrpf.ToString();
                }
                else
                {
                    txtAliqIRPF.Text = "27.5%";
                    descontoIrpf = 0.275 * salarioBruto;
                    mskDescIRPF.Text = descontoIrpf.ToString();
                }

                mskDescIRPF.Text = descontoIrpf.ToString("N2");

                //familia
                if (salarioBruto <= 435.32)
                {
                    salarioFamilia = Convert.ToDouble(cmbNumFilhos.SelectedItem) * 22.33;
                    mskSalarioFam.Text = salarioFamilia.ToString();
                }
                else if (salarioBruto <= 654.61)
                {
                    salarioFamilia = Convert.ToDouble(cmbNumFilhos.SelectedItem) * 15.74;
                    mskSalarioFam.Text = salarioFamilia.ToString();
                }
                else
                {
                    salarioFamilia = 0;
                    mskSalarioFam.Text = salarioFamilia.ToString();
                }

                salarioLiquido = salarioBruto - descontoInss - descontoIrpf + salarioFamilia;
                mskSalarioLiq.Text = salarioLiquido.ToString("N2");

                //mensagem
                string mensagem = "Os descontos do salário ";
                if (rdbF.Checked)
                {
                    mensagem = mensagem + "da Sra. " + txtNomeFunc.Text;
                }
                else
                {
                    mensagem = mensagem + "do Sr. " + txtNomeFunc.Text;
                }
                if (lbEstCivil.SelectedIndex == 0)
                {
                    mensagem = mensagem + " que é solteiro(a) ";
                }
                else
                {
                    mensagem = mensagem + " que é casado(a) ";
                }
                mensagem = mensagem + "e que tem " + cmbNumFilhos.SelectedItem + " filho(a)(s) são:";

                this.lblDados.Text = mensagem;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {        
            txtAliqINSS.Clear();
            txtNomeFunc.Clear();
            txtAliqIRPF.Clear();
            mskDescINSS.Clear();
            mskDescIRPF.Clear();
            mskSalarioFam.Clear();
            mskSalarioLiq.Clear();
            mskSalarioBruto.Clear();
            rdbF.Checked = true;
            cmbNumFilhos.SelectedIndex = 0;
            lbEstCivil.SelectedIndex = 0;
            lblDados.Visible = false;
            lblDados.Text = "";
        }
    }
}
