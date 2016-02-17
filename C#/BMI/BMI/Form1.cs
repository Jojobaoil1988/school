using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ergebnis;

            ergebnis = Convert.ToDouble(this.gewichtbox.Text) / (Convert.ToDouble(this.groessebox.Text) * Convert.ToDouble(this.groessebox.Text));
            if (ergebnis <= 25)
            {
                MessageBox.Show("Ihr BMI beträgt: \n\n" + Convert.ToString(ergebnis) + "\n\nSchauen sie gleich mal wo das nächste McDonalds ist: www.mcdonalds.de\n\n" + Image.FromFile("thin.jpg"));
            }
            else
            {
                MessageBox.Show("Ihr BMI beträgt: \n\n" + Convert.ToString(ergebnis) + "\n\nSchauen sie gleich mal wo das nächste McFit ist: www.mcfit.de\n\n" + Image.FromFile("big.jpg"));
            }
            
        }
        private void groessebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
