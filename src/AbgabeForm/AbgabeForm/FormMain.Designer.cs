namespace AbgabeForm
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
            this.buttonAnmelden = new System.Windows.Forms.Button();
            this.groupBoxAnmelden = new System.Windows.Forms.GroupBox();
            this.textBoxBenutzername = new System.Windows.Forms.TextBox();
            this.labelBenutzername = new System.Windows.Forms.Label();
            this.labelPasswort = new System.Windows.Forms.Label();
            this.textBoxPasswort = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxEingabeZahl = new System.Windows.Forms.TextBox();
            this.textSpielFeld = new System.Windows.Forms.TextBox();
            this.labelEingabeZahl = new System.Windows.Forms.Label();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.groupBoxSpielFeld = new System.Windows.Forms.GroupBox();
            this.groupBoxAnmelden.SuspendLayout();
            this.groupBoxSpielFeld.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAnmelden
            // 
            this.buttonAnmelden.Location = new System.Drawing.Point(6, 129);
            this.buttonAnmelden.Name = "buttonAnmelden";
            this.buttonAnmelden.Size = new System.Drawing.Size(188, 50);
            this.buttonAnmelden.TabIndex = 0;
            this.buttonAnmelden.Text = "Anmelden";
            this.buttonAnmelden.UseVisualStyleBackColor = true;
            this.buttonAnmelden.Click += new System.EventHandler(this.buttonAnmelden_Click);
            // 
            // groupBoxAnmelden
            // 
            this.groupBoxAnmelden.Controls.Add(this.labelPasswort);
            this.groupBoxAnmelden.Controls.Add(this.textBoxPasswort);
            this.groupBoxAnmelden.Controls.Add(this.labelBenutzername);
            this.groupBoxAnmelden.Controls.Add(this.textBoxBenutzername);
            this.groupBoxAnmelden.Controls.Add(this.buttonAnmelden);
            this.groupBoxAnmelden.Location = new System.Drawing.Point(40, 43);
            this.groupBoxAnmelden.Name = "groupBoxAnmelden";
            this.groupBoxAnmelden.Size = new System.Drawing.Size(200, 185);
            this.groupBoxAnmelden.TabIndex = 1;
            this.groupBoxAnmelden.TabStop = false;
            this.groupBoxAnmelden.Text = "Anmelden";
            // 
            // textBoxBenutzername
            // 
            this.textBoxBenutzername.Location = new System.Drawing.Point(6, 46);
            this.textBoxBenutzername.Name = "textBoxBenutzername";
            this.textBoxBenutzername.Size = new System.Drawing.Size(188, 22);
            this.textBoxBenutzername.TabIndex = 1;
            // 
            // labelBenutzername
            // 
            this.labelBenutzername.AutoSize = true;
            this.labelBenutzername.Location = new System.Drawing.Point(7, 26);
            this.labelBenutzername.Name = "labelBenutzername";
            this.labelBenutzername.Size = new System.Drawing.Size(100, 17);
            this.labelBenutzername.TabIndex = 2;
            this.labelBenutzername.Text = "Benutzername";
            // 
            // labelPasswort
            // 
            this.labelPasswort.AutoSize = true;
            this.labelPasswort.Location = new System.Drawing.Point(7, 81);
            this.labelPasswort.Name = "labelPasswort";
            this.labelPasswort.Size = new System.Drawing.Size(65, 17);
            this.labelPasswort.TabIndex = 4;
            this.labelPasswort.Text = "Passwort";
            // 
            // textBoxPasswort
            // 
            this.textBoxPasswort.Location = new System.Drawing.Point(6, 101);
            this.textBoxPasswort.Name = "textBoxPasswort";
            this.textBoxPasswort.Size = new System.Drawing.Size(188, 22);
            this.textBoxPasswort.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(71, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(177, 39);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Mein Spiel";
            // 
            // textBoxEingabeZahl
            // 
            this.textBoxEingabeZahl.Location = new System.Drawing.Point(6, 422);
            this.textBoxEingabeZahl.Name = "textBoxEingabeZahl";
            this.textBoxEingabeZahl.Size = new System.Drawing.Size(170, 22);
            this.textBoxEingabeZahl.TabIndex = 3;
            this.textBoxEingabeZahl.TextChanged += new System.EventHandler(this.textBoxEingabeZahl_TextChanged);
            this.textBoxEingabeZahl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEingabeZahl_KeyDown);
            // 
            // textSpielFeld
            // 
            this.textSpielFeld.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSpielFeld.Location = new System.Drawing.Point(6, 73);
            this.textSpielFeld.Multiline = true;
            this.textSpielFeld.Name = "textSpielFeld";
            this.textSpielFeld.ReadOnly = true;
            this.textSpielFeld.Size = new System.Drawing.Size(294, 314);
            this.textSpielFeld.TabIndex = 4;
            // 
            // labelEingabeZahl
            // 
            this.labelEingabeZahl.AutoSize = true;
            this.labelEingabeZahl.Location = new System.Drawing.Point(3, 402);
            this.labelEingabeZahl.Name = "labelEingabeZahl";
            this.labelEingabeZahl.Size = new System.Drawing.Size(125, 17);
            this.labelEingabeZahl.TabIndex = 5;
            this.labelEingabeZahl.Text = "4 Ciffern Eingeben";
            // 
            // panelStatus
            // 
            this.panelStatus.Location = new System.Drawing.Point(333, 73);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(27, 314);
            this.panelStatus.TabIndex = 6;
            // 
            // groupBoxSpielFeld
            // 
            this.groupBoxSpielFeld.Controls.Add(this.labelTitle);
            this.groupBoxSpielFeld.Controls.Add(this.labelEingabeZahl);
            this.groupBoxSpielFeld.Controls.Add(this.textBoxEingabeZahl);
            this.groupBoxSpielFeld.Controls.Add(this.panelStatus);
            this.groupBoxSpielFeld.Controls.Add(this.textSpielFeld);
            this.groupBoxSpielFeld.Location = new System.Drawing.Point(308, 23);
            this.groupBoxSpielFeld.Name = "groupBoxSpielFeld";
            this.groupBoxSpielFeld.Size = new System.Drawing.Size(389, 465);
            this.groupBoxSpielFeld.TabIndex = 7;
            this.groupBoxSpielFeld.TabStop = false;
            this.groupBoxSpielFeld.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 525);
            this.Controls.Add(this.groupBoxSpielFeld);
            this.Controls.Add(this.groupBoxAnmelden);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBoxAnmelden.ResumeLayout(false);
            this.groupBoxAnmelden.PerformLayout();
            this.groupBoxSpielFeld.ResumeLayout(false);
            this.groupBoxSpielFeld.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAnmelden;
        private System.Windows.Forms.GroupBox groupBoxAnmelden;
        private System.Windows.Forms.TextBox textBoxBenutzername;
        private System.Windows.Forms.Label labelBenutzername;
        private System.Windows.Forms.Label labelPasswort;
        private System.Windows.Forms.TextBox textBoxPasswort;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxEingabeZahl;
        private System.Windows.Forms.TextBox textSpielFeld;
        private System.Windows.Forms.Label labelEingabeZahl;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.GroupBox groupBoxSpielFeld;
    }
}

