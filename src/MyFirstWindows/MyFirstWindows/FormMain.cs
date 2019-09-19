using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWindows
{
    public partial class FormMain : Form
    {
        /**
         * ==== Bewegen
         * 2 -- nach unten
         * 8 -- nach oben
         * 6 -- nach rechts
         * 4 -- nach links
         */
        int iRichtung = 2;
        int iButtonPosX = 100;
        int iButtonPosY = 100;

        int iGeschwindigkeit = 5;

        Random zufall = new Random();

        public FormMain()
        {
            InitializeComponent();
        }

        private void timer10ms_Tick(object sender, EventArgs e)
        {
            int iUFOX = buttonUFO.Location.X;
            int iUFOY = buttonUFO.Location.Y;

            if (iUFOY >= 250 || iUFOY <= 50 || iUFOX <= 50 || iUFOX >= 250)
            {
                iRichtung = zufall.Next(1, 8);
            }

            switch (iRichtung)
            {
                case 2:
                    // nach unten Bewegen
                    buttonUFO.Top += iGeschwindigkeit;
                    break;

                case 6:
                    // nach rechts Bewegen
                    buttonUFO.Left += iGeschwindigkeit;
                    break;


                case 4:
                    // nach links Bewegen
                    buttonUFO.Left -= iGeschwindigkeit;
                    break;

                case 8:
                    // nach oben Bewegen
                    buttonUFO.Top -= iGeschwindigkeit;
                    break;
                case 7:
                    // nach links oben Bewegen
                    buttonUFO.Left -= iGeschwindigkeit;
                    buttonUFO.Top -= iGeschwindigkeit;
                    break;

                case 1:
                    // nach links unten Bewegen
                    buttonUFO.Left -= iGeschwindigkeit;
                    buttonUFO.Top += iGeschwindigkeit;
                    break;
                case 3:
                    // nach rechts unten Bewegen
                    buttonUFO.Left += iGeschwindigkeit;
                    buttonUFO.Top += iGeschwindigkeit;
                    break;

                case 5:
                    // nach rechts oben Bewegen
                    buttonUFO.Left += iGeschwindigkeit;
                    buttonUFO.Top -= iGeschwindigkeit;
                    break;

            }
            
        }
    }
}
