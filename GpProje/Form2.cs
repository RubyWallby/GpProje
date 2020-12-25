using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GpProje
{
    public partial class Form2 : Form
    {
        kisiler k2 = new kisiler();
        public Form2(kisiler k1)
        {
            InitializeComponent();
            k2 = k1;
            string ilksifre = k1.sifre;
            string İlkemail = k1.email;
            tbGirisEmail.Text = k2.email;
            tbGirisSifre.Text = k2.sifre;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
