using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace rechnen
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new Form1());
            }
            catch (OverflowException)
            {
                MessageBox.Show("Die Zahlen dürfen sich nur zwischen 0 und 255 bewegen!");
                Application.Run(new Form1());
            }
            catch (FormatException)
            {
                MessageBox.Show("Bitte nur Zahlen verwenden!");
                Application.Run(new Form1());
            }
        }
    }
}
