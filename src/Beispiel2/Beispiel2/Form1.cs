using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beispiel2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            buttonGruen_Click(null, null);
        }

        private void buttonRot_Click(object sender, EventArgs e)
        {
            panel.BackColor = Color.Red;
        }

        private void buttonGruen_Click(object sender, EventArgs e)
        {
            panel.BackColor = Color.Green;
        }

        private void buttonGetauscht_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxFarbeauswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxFarbeauswahl.SelectedIndex)
            {
                case 0:
                    buttonRot_Click(sender, e); break;

                case 1:
                    buttonGruen_Click(sender, e); break;

                case 2:
                    buttonGetauscht_Click(sender, e); break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonColorDialog_Click(object sender, EventArgs e)
        {
            if(colorDialogFarbauswahl.ShowDialog() == DialogResult.OK)
            {
                panel.BackColor = colorDialogFarbauswahl.Color;
            }
        }

        private void buttonMessageBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("body", "title", MessageBoxButtons.AbortRetryIgnore);
        }
    }
}
