﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestExamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInainteF1_Click(object sender, EventArgs e)
        {
            Form2 proiecte = new Form2();
            proiecte.Show();
            this.Hide();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
