using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodos
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemover1_Click(object sender, EventArgs e)
        {
            int tamanho = txtPalavra1.Text.Length;
            int index = txtPalavra2.Text.IndexOf(txtPalavra1.Text);

            while (index > -1)
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, index) + txtPalavra2.Text.Substring(index + tamanho);
                index = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            }

        }

        private void btnRemover2_Click(object sender, EventArgs e)
        {
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {

            string s = txtPalavra1.Text;
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);

            string ss = "";
            foreach (char c in arr)
            {
                ss = ss + c.ToString();
            }
            MessageBox.Show(ss);
        }

    }
}
