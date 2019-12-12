using System;
using System.IO;
using System.Windows.Forms;

namespace FileInfoExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFileInfo_Click(object sender, EventArgs e)
        {

            String sFileName;
            String sPfad;
            String sExtension;


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                textBoxInfo.Text = openFileDialog.FileName;

                sFileName = Path.GetFileName(openFileDialog.FileName);
                sPfad = Path.GetDirectoryName(openFileDialog.FileName);
                sExtension = Path.GetExtension(openFileDialog.FileName);

                FileInfo oFileInfo = new FileInfo(openFileDialog.FileName);

                //Folderbrowserdialog 
                //Verzeichnisse -> was ist drinnen -> Liste erstellen -> Größe von gesamten Verzeichnis

            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            long iGesamtLaenge;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    String[] sVerzeichnisListe = Directory.GetDirectories(folderBrowserDialog.SelectedPath);
                    String[] sFileListe = Directory.GetFiles(folderBrowserDialog.SelectedPath);

                    foreach (String sPfad in sVerzeichnisListe)
                    {

                    }

                    textBoxInfo.Text = "Infos für Verzeichnis" + Environment.NewLine;
                    iGesamtLaenge = 0;
                    foreach (String sFile in sFileListe)
                    {
                        try
                        {
                            FileInfo oFileInfo = new FileInfo(sFile);
                            iGesamtLaenge = iGesamtLaenge + oFileInfo.Length;
                            textBoxInfo.Text += sFile + " L=" + oFileInfo.Length.ToString() + Environment.NewLine;
                        } catch
                        {

                        }
                    }
                    textBoxInfo.Text += "Gesamtlänge=" + iGesamtLaenge.ToString();
                } catch
                {

                }
            }
        }

        private void buttonSelectDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = folderBrowserDialog.SelectedPath;

            }
        }

        private void buttonLoadTree_Click(object sender, EventArgs e)
        {

        }
    }
}
