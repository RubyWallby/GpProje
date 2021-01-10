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
    
    public partial class Form3 : Form
    {
        Musteriler m2 = new Musteriler();
        public object m1;

        public Form3()
        {
            InitializeComponent();
            
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Film Form3 = new Film();
           // Form3 form3 = this;
            Form3.Dock = DockStyle.Fill;
            Form3.TopLevel = false;
            //Form3.MdiParent = Form3;
            Form3.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(Form3);
            Form3.Show();
            Form3.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FilmYeri Form3 = new FilmYeri();
            //Form3 form3 = this;
            Form3.TopLevel = false;
            Form3.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(Form3); // panel3 içerisinde formu ekledik
            Form3.Show(); // formu gösterdik. Ancak buraya dikakt. ShowDialog(); olarak değil Show(); olarak açıyoruz.
            Form3.Dock = DockStyle.Fill; // Açılan formun paneli doldurmasını sağladık.
            Form3.BringToFront(); // formu panel içinde en öne getirdik
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Musteri Form3 = new Musteri();
            //Form3 form3 = this;
            Form3.TopLevel = false;
            Form3.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(Form3); // panel3 içerisinde formu ekledik
            Form3.Show(); // formu gösterdik. Ancak buraya dikakt. ShowDialog(); olarak değil Show(); olarak açıyoruz.
            Form3.Dock = DockStyle.Fill; // Açılan formun paneli doldurmasını sağladık.
            Form3.BringToFront(); // formu panel içinde en öne getirdik
        }
    }
}
