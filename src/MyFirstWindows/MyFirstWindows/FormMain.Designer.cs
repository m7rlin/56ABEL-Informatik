namespace MyFirstWindows
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
            this.buttonUFO = new System.Windows.Forms.Button();
            this.timer10ms = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonUFO
            // 
            this.buttonUFO.Location = new System.Drawing.Point(43, 89);
            this.buttonUFO.Name = "buttonUFO";
            this.buttonUFO.Size = new System.Drawing.Size(120, 46);
            this.buttonUFO.TabIndex = 0;
            this.buttonUFO.Text = "UFO";
            this.buttonUFO.UseVisualStyleBackColor = true;
            // 
            // timer10ms
            // 
            this.timer10ms.Enabled = true;
            this.timer10ms.Tick += new System.EventHandler(this.timer10ms_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 396);
            this.Controls.Add(this.buttonUFO);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUFO;
        private System.Windows.Forms.Timer timer10ms;
    }
}

