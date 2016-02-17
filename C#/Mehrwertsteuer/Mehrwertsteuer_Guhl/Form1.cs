//Jannis Guhl
//11.10.2011
//Klausur 5. Block: Programm zur Berechnung der Mehrwertsteuer bei der Uebernachtung in Stundenhotels
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mehrwertsteuer_Guhl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void berechnen_button_Click(object sender, EventArgs e)
        {
            //Deklaration der benoetigten Variablen:
            string verhalten;
            int mwstr, zeit, betrag, ergebnis, steuer, ankunft, abreise;

            //Ueberpruefung ob gerade Zahlen eingegeben wurden:
            try
            {
                ankunft = Convert.ToInt32(ankunft_edit.Text);
                abreise = Convert.ToInt32(abreise_edit.Text);
            }
            catch(FormatException)
            {
                //Wenn nicht wird eine MessageBox erzeugt:
                MessageBox.Show("Bitte nur ganze Stunden eingeben!");
                //und es erfolgt keine Berechnung:
                return;
            }

            //Ueberpruefung ob die Abreise vor der Ankunft war:
            if (ankunft > abreise)
            {
                //Wenn ja wird eine MessageBox erzeugt und es erfolgt keine Berechnung:
                MessageBox.Show("Die Ankunft kann nicht nach der Abreise erolgt sein!");
            }
            else 
            {
                //Start der Abfrage ob die Zeiten zwischen 0 und 23 Uhr liegen
                if (ankunft > 23 || ankunft < 0 || abreise > 23 || abreise < 0)
                {
                    //Wenn nicht wird eine Messagebox mit dem Fehler ausgegeben und es erfolgt keine Berechnung:
                    MessageBox.Show("Die Zeiten dürfen nicht größer als 23 und kleiner als 0 sein!");
                }
                else
                {
                    //Die Aufenthaltsdazer wird berechnet:
                    zeit = abreise - ankunft;

                    //Pruefung ob Kunde eingeschlafen ist oder Bett verlassen hat:
                    if (einschlafen_radio.Checked)
                    {
                        verhalten = "und ist danach eingeschlafen!";
                        mwstr = 7;
                    }
                    else
                    {
                        verhalten = "und hat danach das Bett sofort verlassen!";
                        if (zeit >= 4)
                        {
                            mwstr = 7;
                        }
                        else
                        {
                            mwstr = 19;
                        }
                    }

                    //Berechnung der Beträge:
                    betrag = Convert.ToInt32(uebernachtung_edit.Text) + Convert.ToInt32(zusatz_edit.Text);
                    steuer = mwstr * (betrag / 100);
                    ergebnis = betrag + steuer;

                    //Ausgabe der Ergebnisse in den vorgesehenen Labels:
                    ausgabe_label1.Text = "Der Gast war " + Convert.ToString(zeit) + " Stunden anwesend " + verhalten;
                    ausgabe_label2.Text = "Der Gesamtbetrag ist: " + Convert.ToString(ergebnis) + " EURO";
                    ausgabe_label3.Text = "Im Betrag sind " + Convert.ToString(mwstr) + "% MwStr (=" + Convert.ToString(steuer) + " EURO) enthalten.";
                }
            }
        }
    }
}
