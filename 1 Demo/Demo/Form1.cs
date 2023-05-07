using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        // PUNTO 2
        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_a.Text = "Si";
            txt_b.Text = "Si";
            txt_c.Text = "Si";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_a.Text = "No";
            txt_b.Text = "No";
            txt_c.Text = "No";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_a.Text = "A";
            txt_b.Text = "B";
            txt_c.Text = "C";
        }
        // PUNTO 3
        private void btn_e_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adios Mundo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_a.Visible = false;
            txt_b.Visible = false;
            txt_c.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_a.Visible = true;
            txt_b.Visible = true;
            txt_c.Visible = true;
        }
    }
}
