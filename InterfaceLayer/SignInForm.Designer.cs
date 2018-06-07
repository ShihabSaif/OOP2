namespace InterfaceLayer
{
    partial class SignInForm
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
            this.btnSignIn = new System.Windows.Forms.Button();
            this.TextPassword = new MetroFramework.Controls.MetroTextBox();
            this.TextEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(161, 227);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(261, 33);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // TextPassword
            // 
            // 
            // 
            // 
            this.TextPassword.CustomButton.Image = null;
            this.TextPassword.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.TextPassword.CustomButton.Name = "";
            this.TextPassword.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.TextPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextPassword.CustomButton.TabIndex = 1;
            this.TextPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextPassword.CustomButton.UseSelectable = true;
            this.TextPassword.CustomButton.Visible = false;
            this.TextPassword.Lines = new string[0];
            this.TextPassword.Location = new System.Drawing.Point(260, 139);
            this.TextPassword.MaxLength = 32767;
            this.TextPassword.Multiline = true;
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.PasswordChar = '*';
            this.TextPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextPassword.SelectedText = "";
            this.TextPassword.SelectionLength = 0;
            this.TextPassword.SelectionStart = 0;
            this.TextPassword.ShortcutsEnabled = true;
            this.TextPassword.Size = new System.Drawing.Size(162, 33);
            this.TextPassword.TabIndex = 1;
            this.TextPassword.UseSelectable = true;
            this.TextPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextEmail
            // 
            // 
            // 
            // 
            this.TextEmail.CustomButton.Image = null;
            this.TextEmail.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.TextEmail.CustomButton.Name = "";
            this.TextEmail.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.TextEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextEmail.CustomButton.TabIndex = 1;
            this.TextEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextEmail.CustomButton.UseSelectable = true;
            this.TextEmail.CustomButton.Visible = false;
            this.TextEmail.Lines = new string[0];
            this.TextEmail.Location = new System.Drawing.Point(260, 91);
            this.TextEmail.MaxLength = 32767;
            this.TextEmail.Multiline = true;
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.PasswordChar = '\0';
            this.TextEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextEmail.SelectedText = "";
            this.TextEmail.SelectionLength = 0;
            this.TextEmail.SelectionStart = 0;
            this.TextEmail.ShortcutsEnabled = true;
            this.TextEmail.Size = new System.Drawing.Size(162, 33);
            this.TextEmail.TabIndex = 0;
            this.TextEmail.UseSelectable = true;
            this.TextEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(161, 139);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Password";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(161, 91);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Email";
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 314);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextEmail);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignInForm";
            this.Text = "Sign In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TextEmail;
        private MetroFramework.Controls.MetroTextBox TextPassword;
        private System.Windows.Forms.Button btnSignIn;
    }
}