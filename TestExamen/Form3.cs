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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnInainteF3_Click(object sender, EventArgs e)
        {
            Form4 materiale = new Form4();
            materiale.Show();
            this.Hide();
        }

        private void btnInapoiF3_Click(object sender, EventArgs e)
        {
            Form2 proiecte = new Form2();
            proiecte.Show();
            this.Close();
        }
    }
}
