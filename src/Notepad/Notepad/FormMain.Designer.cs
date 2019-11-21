namespace Notepad
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelZeit = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDatum = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1s = new System.Windows.Forms.Timer(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFont = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemColor = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStripMain.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemHelp,
            this.editToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(716, 28);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemOpen,
            this.ToolStripMenuItemSave,
            this.ToolStripMenuItemSaveAs});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(44, 24);
            this.toolStripMenuItemFile.Text = "File";
            // 
            // ToolStripMenuItemOpen
            // 
            this.ToolStripMenuItemOpen.Name = "ToolStripMenuItemOpen";
            this.ToolStripMenuItemOpen.Size = new System.Drawing.Size(142, 26);
            this.ToolStripMenuItemOpen.Text = "Open";
            this.ToolStripMenuItemOpen.Click += new System.EventHandler(this.ToolStripMenuItemOpen_Click);
            // 
            // ToolStripMenuItemSave
            // 
            this.ToolStripMenuItemSave.Name = "ToolStripMenuItemSave";
            this.ToolStripMenuItemSave.Size = new System.Drawing.Size(142, 26);
            this.ToolStripMenuItemSave.Text = "Save";
            this.ToolStripMenuItemSave.Click += new System.EventHandler(this.ToolStripMenuItemSave_Click);
            // 
            // ToolStripMenuItemSaveAs
            // 
            this.ToolStripMenuItemSaveAs.Name = "ToolStripMenuItemSaveAs";
            this.ToolStripMenuItemSaveAs.Size = new System.Drawing.Size(181, 26);
            this.ToolStripMenuItemSaveAs.Text = "Save as...";
            this.ToolStripMenuItemSaveAs.Click += new System.EventHandler(this.ToolStripMenuItemSaveAs_Click);
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(53, 24);
            this.toolStripMenuItemHelp.Text = "Help";
            this.toolStripMenuItemHelp.Click += new System.EventHandler(this.toolStripMenuItemHelp_Click);
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 28);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(716, 416);
            this.textBox.TabIndex = 2;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.FileName = "test";
            this.openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelZeit,
            this.toolStripStatusLabelDatum});
            this.statusStrip.Location = new System.Drawing.Point(0, 419);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(716, 25);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelZeit
            // 
            this.toolStripStatusLabelZeit.AutoSize = false;
            this.toolStripStatusLabelZeit.Name = "toolStripStatusLabelZeit";
            this.toolStripStatusLabelZeit.Size = new System.Drawing.Size(200, 20);
            this.toolStripStatusLabelZeit.Text = "toolStripStatusLabelZeit";
            this.toolStripStatusLabelZeit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelDatum
            // 
            this.toolStripStatusLabelDatum.AutoSize = false;
            this.toolStripStatusLabelDatum.Name = "toolStripStatusLabelDatum";
            this.toolStripStatusLabelDatum.Size = new System.Drawing.Size(200, 20);
            this.toolStripStatusLabelDatum.Text = "toolStripStatusLabelDatum";
            this.toolStripStatusLabelDatum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1s
            // 
            this.timer1s.Enabled = true;
            this.timer1s.Tick += new System.EventHandler(this.timer1s_Tick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFont});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolStripMenuItemFont
            // 
            this.toolStripMenuItemFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSize,
            this.toolStripMenuItemColor});
            this.toolStripMenuItemFont.Name = "toolStripMenuItemFont";
            this.toolStripMenuItemFont.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuItemFont.Text = "Font";
            // 
            // toolStripMenuItemSize
            // 
            this.toolStripMenuItemSize.Name = "toolStripMenuItemSize";
            this.toolStripMenuItemSize.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuItemSize.Text = "Size";
            this.toolStripMenuItemSize.Click += new System.EventHandler(this.toolStripMenuItemSize_Click);
            // 
            // toolStripMenuItemColor
            // 
            this.toolStripMenuItemColor.Name = "toolStripMenuItemColor";
            this.toolStripMenuItemColor.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuItemColor.Text = "Color";
            this.toolStripMenuItemColor.Click += new System.EventHandler(this.toolStripMenuItemColor_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "test";
            this.saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 444);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "Notepad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveAs;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelZeit;
        private System.Windows.Forms.Timer timer1s;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDatum;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFont;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSize;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemColor;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

