﻿namespace DirectoryTreeView
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
            this.labelDirectoryPath = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonSelectDirectory = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.buttonLoadView = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonTreeViewExpandAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDirectoryPath
            // 
            this.labelDirectoryPath.AutoSize = true;
            this.labelDirectoryPath.Location = new System.Drawing.Point(36, 34);
            this.labelDirectoryPath.Name = "labelDirectoryPath";
            this.labelDirectoryPath.Size = new System.Drawing.Size(101, 17);
            this.labelDirectoryPath.TabIndex = 0;
            this.labelDirectoryPath.Text = "Directory path:";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(143, 29);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(281, 22);
            this.textBoxFilePath.TabIndex = 1;
            // 
            // buttonSelectDirectory
            // 
            this.buttonSelectDirectory.Location = new System.Drawing.Point(430, 29);
            this.buttonSelectDirectory.Name = "buttonSelectDirectory";
            this.buttonSelectDirectory.Size = new System.Drawing.Size(39, 24);
            this.buttonSelectDirectory.TabIndex = 2;
            this.buttonSelectDirectory.Text = "...";
            this.buttonSelectDirectory.UseVisualStyleBackColor = true;
            this.buttonSelectDirectory.Click += new System.EventHandler(this.buttonSelectDirectory_Click);
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(39, 62);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(432, 336);
            this.treeView.TabIndex = 3;
            // 
            // buttonLoadView
            // 
            this.buttonLoadView.Location = new System.Drawing.Point(945, 179);
            this.buttonLoadView.Name = "buttonLoadView";
            this.buttonLoadView.Size = new System.Drawing.Size(225, 35);
            this.buttonLoadView.TabIndex = 4;
            this.buttonLoadView.Text = "Load view";
            this.buttonLoadView.UseVisualStyleBackColor = true;
            this.buttonLoadView.Click += new System.EventHandler(this.buttonLoadView_Click);
            // 
            // buttonTreeViewExpandAll
            // 
            this.buttonTreeViewExpandAll.Location = new System.Drawing.Point(945, 220);
            this.buttonTreeViewExpandAll.Name = "buttonTreeViewExpandAll";
            this.buttonTreeViewExpandAll.Size = new System.Drawing.Size(225, 35);
            this.buttonTreeViewExpandAll.TabIndex = 5;
            this.buttonTreeViewExpandAll.Text = "Expand all";
            this.buttonTreeViewExpandAll.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 468);
            this.Controls.Add(this.buttonTreeViewExpandAll);
            this.Controls.Add(this.buttonLoadView);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.buttonSelectDirectory);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.labelDirectoryPath);
            this.Name = "FormMain";
            this.Text = "Tree View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDirectoryPath;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonSelectDirectory;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button buttonLoadView;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button buttonTreeViewExpandAll;
    }
}

