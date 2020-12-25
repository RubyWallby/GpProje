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
    public partial class Form1 : Form
    {
        kisiler k1 = new kisiler();
        public Form1()
        {
            InitializeComponent();
            k1 = new kisiler();
            k1.email = tbEmail.Text;
            k1.sifre = tbSifre.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim();
            string sifre = tbSifre.Text.Trim();
            string sifre2 = tbSifre2.Text.Trim();
            if (!email.Contains("@hotmail.com"))
            {
                lblMessage.Text = "Lütfen doğru bir email giriniz";
                lblMessage.ForeColor = Color.Red;
            }
            else if (email == "")
            {
                lblMessage.Text = "Email kısmı boş olamaz.";
                lblMessage.ForeColor = Color.Red;
            }
            else if (!email.Contains('@'))
            {
                lblMessage.Text = "Lütfen doğru bir mail giriniz.";
            }
            else if (sifre.Length < 8)
            {
                lblMessage.Text = "Şifreniz 8 karakterden az olamaz";
                lblMessage.ForeColor = Color.Red;
            }
            else if (sifre != sifre2)
            {
                lblMessage.Text = "Şifreleriniz uyuşmuyor.";
                lblMessage.ForeColor = Color.Red;
            }
            else if (sifre.Contains(' '))
            {
                lblMessage.Text = "Şifrenizde boşluk olamaz";
                lblMessage.ForeColor = Color.Red;
            }
            else
            {
                lblMessage.Text = "Kaydolma işlemi başarıyla gerçekleşmiştir.";
                lblMessage.ForeColor = Color.Green;
                k1.email = tbEmail.Text;
                k1.sifre = tbSifre.Text;
                this.Hide();
                Form2 form = new Form2(k1);
                form.ShowDialog();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tbEmail.Text = "";
            tbSifre.Text = "";
            tbSifre2.Text = "";
            maskedTextBox2.Text = "";
            lblMessage.Text = "";
        }
    }
}
