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
    public partial class FilmYeri : Form
    {
        public FilmYeri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbFilmYeri.Text = cbFilmYeri.Text;
            if (radioButton1.Checked==true)
            {
                tbFilmSaat.Text = "10.00";
            }
            else if (radioButton2.Checked==true)
            {
                tbFilmSaat.Text = "13.00";
            }
            else if (radioButton3.Checked==true)
            {
                tbFilmSaat.Text = "16.00";
            }
            else if (radioButton4.Checked==true)
            {
                tbFilmSaat.Text = "19.00";
            }
            else if (radioButton5.Checked==true)
            {
                tbFilmSaat.Text = "01.00";
            }
            else if (radioButton6.Checked==true)
            {
                tbFilmSaat.Text = "22.00";
            }
            else
            {
                lblmessage.Text = "Lütfen bir film saati seçiniz";
                lblmessage.ForeColor = Color.DarkRed;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cbFilmYeri.Text = "";
            tbFilmSaat.Text = "";
            tbFilmYeri.Text = "";
            radioButton3.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
        }

        private void FilmYeri_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tbFilmYeri.Text = cbFilmYeri.Text;
            if (radioButton1.Checked == true)
            {
                tbFilmSaat.Text = "10.00";
            }
            else if (radioButton2.Checked == true)
            {
                tbFilmSaat.Text = "13.00";
            }
            else if (radioButton3.Checked == true)
            {
                tbFilmSaat.Text = "16.00";
            }
            else if (radioButton4.Checked == true)
            {
                tbFilmSaat.Text = "19.00";
            }
            else if (radioButton5.Checked == true)
            {
                tbFilmSaat.Text = "01.00";
            }
            else if (radioButton6.Checked == true)
            {
                tbFilmSaat.Text = "22.00";
            }
            else
            {
                lblmessage.Text = "Lütfen bir film saati seçiniz";
                lblmessage.ForeColor = Color.DarkRed;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            cbFilmYeri.Text = "";
            tbFilmSaat.Text = "";
            tbFilmYeri.Text = "";
            radioButton3.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
