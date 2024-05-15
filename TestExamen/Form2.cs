using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnInainteF2_Click(object sender, EventArgs e)
        {
            Form3 angajati = new Form3();
            angajati.Show();
            this.Hide();
        }

        private void btnInapoiF2_Click(object sender, EventArgs e)
        {
            Form1 meniu = new Form1();
            meniu.Show();
            this.Close();
        }
    }
}
