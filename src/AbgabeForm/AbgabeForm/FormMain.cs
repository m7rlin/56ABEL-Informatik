using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbgabeForm
{
    public partial class FormMain : Form
    {
        string sBenutzername = "test";
        string sPasswort = "test";

        string sNeueZahl = "";

        string sGewinnZahl = "7568";

        Boolean bAngemeldet = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void anmelden()
        {
            bAngemeldet = true;
            groupBoxAnmelden.Visible = false;
            groupBoxSpielFeld.Visible = true;
        }

        private void abmelden()
        {
            bAngemeldet = false;
            groupBoxAnmelden.Visible = true;
            groupBoxSpielFeld.Visible = false;
        }

        private void buttonAnmelden_Click(object sender, EventArgs e)
        {
            string sBenutzerNameInput = textBoxBenutzername.Text;
            string sPasswortInput = textBoxPasswort.Text;

            // Wenn Benutzername und Passwort nicht leer sind soll
            // ein Messagebox geöffnet werden
            if (sBenutzerNameInput != "" && sPasswortInput != "")
            {
                // Verifizieren of die Anmeldedaten richtig sind
                if (sBenutzername == sBenutzerNameInput && sPasswort == sPasswortInput)
                {
                    MessageBox.Show("Erfolgreich angemeldet");
                    anmelden();
                } else
                {
                    MessageBox.Show("Benutzername bzw. Passwort sind falsch.");
                }
            } else
            // Wenn beide Felder leer sind soll ein error kommen
            {
                MessageBox.Show("Du musst Benutzername und Passwort eingeben.");
            }
        }

        private void textBoxEingabeZahl_TextChanged(object sender, EventArgs e)
        {

        }

        private void spielReset()
        {
            textSpielFeld.Clear();
        }

        private void neueLinie(string text)
        {
            textSpielFeld.AppendText(text + " — " + sNeueZahl + "\r\n");
        }

        private void spielGewonnen()
        {
            MessageBox.Show("Du hast gewonnen!");
            panelStatus.BackColor = Color.Green;
        }

        private void spielProcess()
        {
            if (sNeueZahl == sGewinnZahl)
            {
                spielGewonnen();
                return;
            }
            string sNewString = "";
            for (int i = 0; i < 4; i++)
            {
                string sZahl = sNeueZahl[i].ToString();
                if (sZahl == sGewinnZahl[i].ToString())
                {
                    sNewString += sZahl;
                } else
                {
                    sNewString += "x";
                }
                
            }
            neueLinie(sNewString);
            MessageBox.Show(sNewString);
        }


        private void zahlVerifizieren()
        {
            int iValue;
            string sEingabeZahl = textBoxEingabeZahl.Text;
            if (sEingabeZahl.Length == 4 && int.TryParse(sEingabeZahl, out iValue))
            {
                sNeueZahl = sEingabeZahl;
                //neueLinie(sEingabeZahl);
                spielProcess();
            }

            textBoxEingabeZahl.Clear();
        }

        private void textBoxEingabeZahl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                zahlVerifizieren();
            }

        }
    }
}
