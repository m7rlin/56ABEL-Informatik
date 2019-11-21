using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class FormMain : Form
    {

        // File changed
        bool bFileChanged = false;

        bool bFileExist = false;


        string sFileName = "<unknown>";

        public FormMain()
        {
            InitializeComponent();
            timer1s_Tick(null, null);


            Text = sFileName;
            
        }
           
        // Open - Menu 
        private void ToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
           if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                textBox.Text = System.IO.File.ReadAllText(openFileDialog.FileName);
                bFileExist = true;
            }
        }

        // Save - Menu
        private void ToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            this.saveFile();
        }

        private void timer1s_Tick(object sender, EventArgs e)
        {
            DateTime oLocalTime = DateTime.Now;

            toolStripStatusLabelZeit.Text = oLocalTime.ToLongTimeString();
            toolStripStatusLabelDatum.Text = oLocalTime.ToLongDateString();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bFileChanged)
            {
                DialogResult oDialogResult = MessageBox.Show("Do you want to save before closing?", "Exit", MessageBoxButtons.YesNoCancel);
                if (DialogResult.Yes == oDialogResult)
                {
                    // Clicked yes
                    this.saveFile();
                } if (DialogResult.Abort == oDialogResult) {
                    // Clicked abort
                    e.Cancel = true;
                }
                // Clicked no
            }
        }

        private void saveAsFile()
        {
            saveFileDialog.ShowDialog();
            System.IO.File.WriteAllText(saveFileDialog.FileName, textBox.Text);
        }

        private void saveFile()
        {
            if (!bFileExist)
            {
                // Save file
                try
                {
                    System.IO.File.WriteAllText(openFileDialog.FileName, textBox.Text);
                }

                catch
                {
                    MessageBox.Show("Speichern geht nit");
                }
            } else
            {
                this.saveAsFile();
            }
            bFileChanged = false;
            bFileExist = true;
        }


        private void textBox_TextChanged(object sender, EventArgs e)
        {
            // File text changed
            bFileChanged = true;

            // If file already exist on the disk but the content has changed
            // update filename with *
            if (true)
            {
                this.Text = "*" + sFileName;
            }
        }

        private void toolStripMenuItemHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(c) 2019 — Marcin Stawowczyk");
        }

        // Set Editor font size
        private void toolStripMenuItemSize_Click(object sender, EventArgs e)
        {
            FontDialog ftd = new FontDialog();
            if (ftd.ShowDialog() == DialogResult.OK)
            {
                textBox.Font = ftd.Font;
            }
        }

        // Set Editor font color
        private void toolStripMenuItemColor_Click(object sender, EventArgs e)
        {

            ColorDialog ftd = new ColorDialog();
            if (ftd.ShowDialog() == DialogResult.OK)
            {
                textBox.ForeColor = ftd.Color;
            }
        }

        private void ToolStripMenuItemSaveAs_Click(object sender, EventArgs e)
        {
            this.saveAsFile();
        }
    }
}
