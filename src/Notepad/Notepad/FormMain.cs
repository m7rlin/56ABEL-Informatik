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
        public FormMain()
        {
            InitializeComponent();
        }
           
        // Open - Menu 
        private void ToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
           if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                textBox.Text = System.IO.File.ReadAllText(openFileDialog.FileName);
            }
        }

        // Save - Menu
        private void ToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(openFileDialog.FileName, textBox.Text);
        }
    }
}
