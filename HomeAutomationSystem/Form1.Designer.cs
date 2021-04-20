namespace HomeAutomationSystem
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
            this.home1 = new HomeAutomationSystem.Home();
            this.login1 = new HomeAutomationSystem.Login();
            this.SuspendLayout();
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.home1.Location = new System.Drawing.Point(-5, -3);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(795, 567);
            this.home1.TabIndex = 0;
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.DodgerBlue;
            this.login1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login1.Location = new System.Drawing.Point(842, -3);
            this.login1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(397, 567);
            this.login1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 560);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.home1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Home home1;
        private Login login1;
    }
}