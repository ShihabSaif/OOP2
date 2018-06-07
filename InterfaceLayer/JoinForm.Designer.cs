namespace InterfaceLayer
{
    partial class JoinForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnImageChoose = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TextName = new MetroFramework.Controls.MetroTextBox();
            this.TextEmail = new MetroFramework.Controls.MetroTextBox();
            this.TextPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnJoin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(23, 63);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(170, 170);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // btnImageChoose
            // 
            this.btnImageChoose.Location = new System.Drawing.Point(23, 257);
            this.btnImageChoose.Name = "btnImageChoose";
            this.btnImageChoose.Size = new System.Drawing.Size(170, 34);
            this.btnImageChoose.TabIndex = 3;
            this.btnImageChoose.Text = "Choose Image";
            this.btnImageChoose.UseVisualStyleBackColor = true;
            this.btnImageChoose.Click += new System.EventHandler(this.btnImageChoose_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(255, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(255, 134);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Email";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(255, 201);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Password";
            // 
            // TextName
            // 
            // 
            // 
            // 
            this.TextName.CustomButton.Image = null;
            this.TextName.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.TextName.CustomButton.Name = "";
            this.TextName.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.TextName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextName.CustomButton.TabIndex = 1;
            this.TextName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextName.CustomButton.UseSelectable = true;
            this.TextName.CustomButton.Visible = false;
            this.TextName.Lines = new string[0];
            this.TextName.Location = new System.Drawing.Point(364, 64);
            this.TextName.MaxLength = 32767;
            this.TextName.Multiline = true;
            this.TextName.Name = "TextName";
            this.TextName.PasswordChar = '\0';
            this.TextName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextName.SelectedText = "";
            this.TextName.SelectionLength = 0;
            this.TextName.SelectionStart = 0;
            this.TextName.ShortcutsEnabled = true;
            this.TextName.Size = new System.Drawing.Size(161, 33);
            this.TextName.TabIndex = 0;
            this.TextName.UseSelectable = true;
            this.TextName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextEmail
            // 
            // 
            // 
            // 
            this.TextEmail.CustomButton.Image = null;
            this.TextEmail.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.TextEmail.CustomButton.Name = "";
            this.TextEmail.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.TextEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextEmail.CustomButton.TabIndex = 1;
            this.TextEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextEmail.CustomButton.UseSelectable = true;
            this.TextEmail.CustomButton.Visible = false;
            this.TextEmail.Lines = new string[0];
            this.TextEmail.Location = new System.Drawing.Point(364, 134);
            this.TextEmail.MaxLength = 32767;
            this.TextEmail.Multiline = true;
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.PasswordChar = '\0';
            this.TextEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextEmail.SelectedText = "";
            this.TextEmail.SelectionLength = 0;
            this.TextEmail.SelectionStart = 0;
            this.TextEmail.ShortcutsEnabled = true;
            this.TextEmail.Size = new System.Drawing.Size(161, 33);
            this.TextEmail.TabIndex = 1;
            this.TextEmail.UseSelectable = true;
            this.TextEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextPassword
            // 
            // 
            // 
            // 
            this.TextPassword.CustomButton.Image = null;
            this.TextPassword.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.TextPassword.CustomButton.Name = "";
            this.TextPassword.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.TextPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextPassword.CustomButton.TabIndex = 1;
            this.TextPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextPassword.CustomButton.UseSelectable = true;
            this.TextPassword.CustomButton.Visible = false;
            this.TextPassword.Lines = new string[0];
            this.TextPassword.Location = new System.Drawing.Point(364, 201);
            this.TextPassword.MaxLength = 32767;
            this.TextPassword.Multiline = true;
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.PasswordChar = '*';
            this.TextPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextPassword.SelectedText = "";
            this.TextPassword.SelectionLength = 0;
            this.TextPassword.SelectionStart = 0;
            this.TextPassword.ShortcutsEnabled = true;
            this.TextPassword.Size = new System.Drawing.Size(161, 33);
            this.TextPassword.TabIndex = 2;
            this.TextPassword.UseSelectable = true;
            this.TextPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(255, 258);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(270, 34);
            this.btnJoin.TabIndex = 4;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // JoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 314);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextEmail);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnImageChoose);
            this.Controls.Add(this.pictureBox);
            this.Name = "JoinForm";
            this.Text = "Join";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnImageChoose;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TextName;
        private MetroFramework.Controls.MetroTextBox TextEmail;
        private MetroFramework.Controls.MetroTextBox TextPassword;
        private System.Windows.Forms.Button btnJoin;
    }
}