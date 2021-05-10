﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio1 objFrm1 = new frmExercicio1();
            objFrm1.MdiParent = this;
            objFrm1.WindowState = FormWindowState.Maximized;
            objFrm1.Show();
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio2 objFrm2 = new frmExercicio2();
            objFrm2.MdiParent = this;
            objFrm2.WindowState = FormWindowState.Maximized;
            objFrm2.Show();
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio3 objFrm3 = new frmExercicio3();
            objFrm3.MdiParent = this;
            objFrm3.WindowState = FormWindowState.Maximized;
            objFrm3.Show();
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio4 objFrm4 = new frmExercicio4();
            objFrm4.MdiParent = this;
            objFrm4.WindowState = FormWindowState.Maximized;
            objFrm4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
