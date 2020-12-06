namespace APP
{
    partial class StartingWindow
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
            this.userLogin = new System.Windows.Forms.Button();
            this.adminLogin = new System.Windows.Forms.Button();
            this.registration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userLogin
            // 
            this.userLogin.Location = new System.Drawing.Point(117, 213);
            this.userLogin.Margin = new System.Windows.Forms.Padding(4);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(128, 36);
            this.userLogin.TabIndex = 0;
            this.userLogin.Text = "Login as User";
            this.userLogin.UseVisualStyleBackColor = true;
            this.userLogin.Click += new System.EventHandler(this.userLogin_Click);
            // 
            // adminLogin
            // 
            this.adminLogin.Location = new System.Drawing.Point(117, 256);
            this.adminLogin.Margin = new System.Windows.Forms.Padding(4);
            this.adminLogin.Name = "adminLogin";
            this.adminLogin.Size = new System.Drawing.Size(128, 36);
            this.adminLogin.TabIndex = 1;
            this.adminLogin.Text = "Login as Admin";
            this.adminLogin.UseVisualStyleBackColor = true;
            this.adminLogin.Click += new System.EventHandler(this.adminLogin_Click);
            // 
            // registration
            // 
            this.registration.Location = new System.Drawing.Point(117, 299);
            this.registration.Margin = new System.Windows.Forms.Padding(4);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(128, 36);
            this.registration.TabIndex = 2;
            this.registration.Text = "Registration";
            this.registration.UseVisualStyleBackColor = true;
            this.registration.Click += new System.EventHandler(this.registration_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(304, 98);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to the \"Games4You\" \r\n  Choose what you want to do.";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(117, 342);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(128, 36);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // StartingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 554);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.adminLogin);
            this.Controls.Add(this.userLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StartingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartingWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userLogin;
        private System.Windows.Forms.Button adminLogin;
        private System.Windows.Forms.Button registration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
    }
}