using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryTreeView
{
    public partial class FormMain : Form
    {

        String sPfad = "";

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonSelectDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Set textBox path.
                sPfad = folderBrowserDialog.SelectedPath;
                textBoxFilePath.Text = sPfad;
            }
        }

        private void buttonLoadView_Click(object sender, EventArgs e)
        {
            // File selected
            if (textBoxFilePath.Text != "")
            {
                // Clear tree view
                treeView.Nodes.Clear();

                String[] sVerzeichnisListe = Directory.GetDirectories(sPfad);
                String[] sFileListe = Directory.GetFiles(sPfad);

                DirectoryInfo oDirectoryInfo = new DirectoryInfo(sPfad);

                // Display List with directories
                ListDirectory(treeView, textBoxFilePath.Text);
            }
        }

        public void ListDirectory(TreeView oTreeView, string sPath)
        {
            oTreeView.Nodes.Clear();
            DirectoryInfo oRootDirectoryInfo = new DirectoryInfo(sPath);
            oTreeView.Nodes.Add(CreateDirectoryNode(oRootDirectoryInfo));
        }

        public TreeNode CreateDirectoryNode(DirectoryInfo oDirectoryInfo)
        {
            TreeNode oDirectoryNode = new TreeNode(oDirectoryInfo.Name);
            foreach (DirectoryInfo oDirectory in oDirectoryInfo.GetDirectories())
                oDirectoryNode.Nodes.Add(CreateDirectoryNode(oDirectory));
            foreach (FileInfo file in oDirectoryInfo.GetFiles())
                oDirectoryNode.Nodes.Add(new TreeNode(file.Name));
            return oDirectoryNode;
        }
    }
}
