namespace FileInfoExample
{
    partial class Form1
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
            this.buttonFileInfo = new System.Windows.Forms.Button();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonSelectDirectory = new System.Windows.Forms.Button();
            this.buttonLoadTree = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // buttonFileInfo
            // 
            this.buttonFileInfo.Location = new System.Drawing.Point(524, 57);
            this.buttonFileInfo.Name = "buttonFileInfo";
            this.buttonFileInfo.Size = new System.Drawing.Size(138, 52);
            this.buttonFileInfo.TabIndex = 0;
            this.buttonFileInfo.Text = "File Info";
            this.buttonFileInfo.UseVisualStyleBackColor = true;
            this.buttonFileInfo.Click += new System.EventHandler(this.buttonFileInfo_Click);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(47, 57);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(377, 274);
            this.textBoxInfo.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(524, 115);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(138, 45);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonSelectDirectory
            // 
            this.buttonSelectDirectory.Location = new System.Drawing.Point(524, 166);
            this.buttonSelectDirectory.Name = "buttonSelectDirectory";
            this.buttonSelectDirectory.Size = new System.Drawing.Size(138, 52);
            this.buttonSelectDirectory.TabIndex = 3;
            this.buttonSelectDirectory.Text = "Select directory";
            this.buttonSelectDirectory.UseVisualStyleBackColor = true;
            this.buttonSelectDirectory.Click += new System.EventHandler(this.buttonSelectDirectory_Click);
            // 
            // buttonLoadTree
            // 
            this.buttonLoadTree.Location = new System.Drawing.Point(524, 224);
            this.buttonLoadTree.Name = "buttonLoadTree";
            this.buttonLoadTree.Size = new System.Drawing.Size(138, 52);
            this.buttonLoadTree.TabIndex = 4;
            this.buttonLoadTree.Text = "Load tree";
            this.buttonLoadTree.UseVisualStyleBackColor = true;
            this.buttonLoadTree.Click += new System.EventHandler(this.buttonLoadTree_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(47, 29);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(377, 22);
            this.textBoxPath.TabIndex = 5;
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(47, 57);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(377, 274);
            this.treeView.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 396);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.buttonLoadTree);
            this.Controls.Add(this.buttonSelectDirectory);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.buttonFileInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFileInfo;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonSelectDirectory;
        private System.Windows.Forms.Button buttonLoadTree;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.TreeView treeView;
    }
}

