namespace Beispiel2
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
            this.buttonRot = new System.Windows.Forms.Button();
            this.buttonGruen = new System.Windows.Forms.Button();
            this.buttonGetauscht = new System.Windows.Forms.Button();
            this.comboBoxFarbeauswahl = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.farbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxFarbauswahl = new System.Windows.Forms.ListBox();
            this.colorDialogFarbauswahl = new System.Windows.Forms.ColorDialog();
            this.buttonColorDialog = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.buttonMessageBox = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRot
            // 
            this.buttonRot.Location = new System.Drawing.Point(6, 21);
            this.buttonRot.Name = "buttonRot";
            this.buttonRot.Size = new System.Drawing.Size(301, 39);
            this.buttonRot.TabIndex = 0;
            this.buttonRot.Text = "es werde ROT";
            this.buttonRot.UseVisualStyleBackColor = true;
            this.buttonRot.Click += new System.EventHandler(this.buttonRot_Click);
            // 
            // buttonGruen
            // 
            this.buttonGruen.Location = new System.Drawing.Point(6, 66);
            this.buttonGruen.Name = "buttonGruen";
            this.buttonGruen.Size = new System.Drawing.Size(301, 39);
            this.buttonGruen.TabIndex = 1;
            this.buttonGruen.Text = "es werde GRÜN";
            this.buttonGruen.UseVisualStyleBackColor = true;
            this.buttonGruen.Click += new System.EventHandler(this.buttonGruen_Click);
            // 
            // buttonGetauscht
            // 
            this.buttonGetauscht.Location = new System.Drawing.Point(6, 111);
            this.buttonGetauscht.Name = "buttonGetauscht";
            this.buttonGetauscht.Size = new System.Drawing.Size(301, 39);
            this.buttonGetauscht.TabIndex = 2;
            this.buttonGetauscht.Text = "es werde GETAUSCHT";
            this.buttonGetauscht.UseVisualStyleBackColor = true;
            this.buttonGetauscht.Click += new System.EventHandler(this.buttonGetauscht_Click);
            // 
            // comboBoxFarbeauswahl
            // 
            this.comboBoxFarbeauswahl.FormattingEnabled = true;
            this.comboBoxFarbeauswahl.Items.AddRange(new object[] {
            "Rot",
            "Grün",
            "Orange"});
            this.comboBoxFarbeauswahl.Location = new System.Drawing.Point(121, 156);
            this.comboBoxFarbeauswahl.Name = "comboBoxFarbeauswahl";
            this.comboBoxFarbeauswahl.Size = new System.Drawing.Size(186, 24);
            this.comboBoxFarbeauswahl.TabIndex = 3;
            this.comboBoxFarbeauswahl.Tag = "";
            this.comboBoxFarbeauswahl.SelectedIndexChanged += new System.EventHandler(this.comboBoxFarbeauswahl_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonRot);
            this.groupBox1.Controls.Add(this.comboBoxFarbeauswahl);
            this.groupBox1.Controls.Add(this.buttonGruen);
            this.groupBox1.Controls.Add(this.buttonGetauscht);
            this.groupBox1.Location = new System.Drawing.Point(343, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 192);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Farbauswahl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Farbauswahl";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.farbeToolStripMenuItem,
            this.exotToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // farbeToolStripMenuItem
            // 
            this.farbeToolStripMenuItem.Name = "farbeToolStripMenuItem";
            this.farbeToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.farbeToolStripMenuItem.Text = "Farbe";
            // 
            // exotToolStripMenuItem
            // 
            this.exotToolStripMenuItem.Name = "exotToolStripMenuItem";
            this.exotToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exotToolStripMenuItem.Text = "Exit";
            // 
            // listBoxFarbauswahl
            // 
            this.listBoxFarbauswahl.FormattingEnabled = true;
            this.listBoxFarbauswahl.ItemHeight = 16;
            this.listBoxFarbauswahl.Items.AddRange(new object[] {
            "rot",
            "grün",
            "tauschen",
            ""});
            this.listBoxFarbauswahl.Location = new System.Drawing.Point(683, 65);
            this.listBoxFarbauswahl.Name = "listBoxFarbauswahl";
            this.listBoxFarbauswahl.Size = new System.Drawing.Size(120, 84);
            this.listBoxFarbauswahl.TabIndex = 6;
            // 
            // buttonColorDialog
            // 
            this.buttonColorDialog.Location = new System.Drawing.Point(349, 254);
            this.buttonColorDialog.Name = "buttonColorDialog";
            this.buttonColorDialog.Size = new System.Drawing.Size(301, 39);
            this.buttonColorDialog.TabIndex = 6;
            this.buttonColorDialog.Text = "Öffne Color Dialog";
            this.buttonColorDialog.UseVisualStyleBackColor = true;
            this.buttonColorDialog.Click += new System.EventHandler(this.buttonColorDialog_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(30, 56);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(307, 237);
            this.panel.TabIndex = 7;
            // 
            // buttonMessageBox
            // 
            this.buttonMessageBox.Location = new System.Drawing.Point(349, 299);
            this.buttonMessageBox.Name = "buttonMessageBox";
            this.buttonMessageBox.Size = new System.Drawing.Size(301, 39);
            this.buttonMessageBox.TabIndex = 8;
            this.buttonMessageBox.Text = "Öffne Message Box";
            this.buttonMessageBox.UseVisualStyleBackColor = true;
            this.buttonMessageBox.Click += new System.EventHandler(this.buttonMessageBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 388);
            this.Controls.Add(this.buttonMessageBox);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.buttonColorDialog);
            this.Controls.Add(this.listBoxFarbauswahl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRot;
        private System.Windows.Forms.Button buttonGruen;
        private System.Windows.Forms.Button buttonGetauscht;
        private System.Windows.Forms.ComboBox comboBoxFarbeauswahl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem farbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exotToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxFarbauswahl;
        private System.Windows.Forms.ColorDialog colorDialogFarbauswahl;
        private System.Windows.Forms.Button buttonColorDialog;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonMessageBox;
    }
}

