﻿using System;
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
            Form3 form3 = this;
            Form3.Dock = DockStyle.Fill;
            Form3.TopLevel = false;
            //Form3.MdiParent = form3;
            Form3.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(Form3);
            Form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FilmYeri Form3 = new FilmYeri();
            Form3 form3 = this;
            Form3.Dock = DockStyle.Fill;
            Form3.TopLevel = false;
            //Form3.MdiParent = form3;
            Form3.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(Form3);
            Form3.Show();
        }
    }
}
