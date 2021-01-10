using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GpProje
{
    public partial class Form1 : Form
    {   
        kisiler k1 = new kisiler();
        kisiler k2 = new kisiler();
        Musteriler m1 = new Musteriler();
        public Form1()
        {
            InitializeComponent();
            m1 = new Musteriler();
            k1 = new kisiler();
            k1.email = tbEmail.Text;
            k1.sifre = tbSifre.Text;
            k2 = new kisiler();
            k2.kullaniciAdi = tbEmail.Text;
            k2.sifre = tbSifre.Text;
            k1.Soyisim = textBox2.Text;
            k1.isim = textBox1.Text;
            m1.isim = textBox1.Text;
            m1.soyisim = textBox2.Text;
            m1.sifre = tbSifre.Text;
            m1.email = tbEmail.Text;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string Constring = "Server=DESKTOP-PGCFN95\\GPSERVER1;Database=Görsel;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(Constring);
            connection.Open();
            
            if (connection.State==System.Data.ConnectionState.Open)
            {
                string query = $"select *from Uygulama where Email = '{tbEmail.Text}' and Şifre = '{tbSifre.Text}'";
                SqlCommand Command = new SqlCommand(query,connection);
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                DataTable dt = new DataTable();
                Adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    k2.kullaniciAdi = dt.Rows[0]["İsim"].ToString();
                    k2.sifre = dt.Rows[0]["Şifre"].ToString();
                }
            }
            else
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = tbEmail.Text;
            string Password = tbSifre.Text;
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
                k2.kullaniciAdi = tbEmail.Text;
                k2.sifre = tbSifre.Text;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
