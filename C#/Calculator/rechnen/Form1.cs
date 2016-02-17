using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rechnen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            this.ergebnis_txt.Text = Convert.ToString(Convert.ToByte(this.zahl1_txt.Text) + Convert.ToByte(this.zahl2_txt.Text));
            this.ergebnis_lbl.Text = "+";
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {
            this.ergebnis_txt.Text = Convert.ToString(Convert.ToByte(this.zahl1_txt.Text) - Convert.ToByte(this.zahl2_txt.Text));
            this.ergebnis_lbl.Text = "-";
        }

        private void div_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.ergebnis_txt.Text = Convert.ToString(Convert.ToByte(this.zahl1_txt.Text) / Convert.ToByte(this.zahl2_txt.Text));
                this.ergebnis_lbl.Text = "/";
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Eine Division durch 0 ist nicht erlaubt!");
                //throw;
            }
        }

        private void multi_btn_Click(object sender, EventArgs e)
        {
            this.ergebnis_txt.Text = Convert.ToString(Convert.ToByte(this.zahl1_txt.Text) * Convert.ToByte(this.zahl2_txt.Text));
            this.ergebnis_lbl.Text = "*";
        }

        private void wurzel_btn_Click(object sender, EventArgs e)
        {
            this.ergebnis_txt.Text = Convert.ToString(Math.Sqrt(Convert.ToByte(this.zahl1_txt.Text)));
            this.ergebnis_lbl.Text = "Wurzel";
            this.zahl2_txt.Visible = false;
            this.zahl2_lbl.Visible = false;
            this.add_btn.Enabled = false;
            this.sub_btn.Enabled = false;
            this.div_btn.Enabled = false;
            this.multi_btn.Enabled = false;
            this.potenz_btn.Enabled = false;
        }

        private void rueck_btn_Click(object sender, EventArgs e)
        {
            this.zahl2_txt.Visible = true;
            this.zahl2_lbl.Visible = true;
            this.add_btn.Enabled = true;
            this.sub_btn.Enabled = true;
            this.div_btn.Enabled = true;
            this.multi_btn.Enabled = true;
            this.potenz_btn.Enabled = true;
        }

        private void potenz_btn_Click(object sender, EventArgs e)
        {
            this.ergebnis_txt.Text = Convert.ToString(Math.Pow(Convert.ToByte(this.zahl1_txt.Text), Convert.ToByte(this.zahl2_txt.Text)));
        }
    }
}
