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
    public partial class Musteri : Form
    {
        Musteriler m3 = new Musteriler();
        public Musteri(Musteriler m1, object m11)
        {
            InitializeComponent();
            m3 = m1;
            string ilksifre = m1.sifre;
            string İlkemail = m1.email;
            textBox1.Text = m1.email;
            textBox2.Text = m1.sifre;
            textBox3.Text = m1.isim;
            textBox4.Text = m1.soyisim;
        }

        public Musteri()
        {
        }

        private void Musteri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'görselDataSet1.Uygulama' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.uygulamaTableAdapter.Fill(this.görselDataSet1.Uygulama);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
