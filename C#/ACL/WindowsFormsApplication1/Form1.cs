using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string access;
            string protocol;
            string direction;

            if (deny_radio.Checked)
            {
                access = "Deny";
            }
            else
            {
                access = "Permit";
            }

            if (tcp_radio.Checked)
            {
                protocol = "TCP";
            }
            else
            {
                if (udp_radio.Checked)
                {
                    protocol = "UDP";
                }
                else
                {
                    protocol = "IP";
                }
            }

            if (in_radio.Checked)
            {
                direction = "IN";
            }
            else
            {
                if (out_radio.Checked)
                {
                    direction = "OUT";
                }
                else
                {
                    direction = "IN/OUT";
                }
            }

            if (Convert.ToInt32(quellport_edit.Text) > 1024)
            {
                MessageBox.Show("Die Ports dürfen nur im Bereich von 1 bis 1024 liegen oder den Wert Any bekommen.");
            }
            else
            {
                acl_listbox.Items.Add(access + "\t" + protocol + "\t" + quellip_edit.Text + "\t" + zielip_edit.Text + "\t" + quellport_edit.Text + "\t" + zielport_edit.Text + "\t" + interface_edit.Text + "\t" + direction);
            }

            if (Convert.ToInt32(zielport_edit.Text) < 1 || Convert.ToInt32(zielport_edit.Text) > 1024)
            {
                MessageBox.Show("Die Ports dürfen nur im Bereich von 1 bis 1024 liegen oder den Wert Any bekommen.");
            }

        }
    }
}
