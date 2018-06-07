namespace InterfaceLayer
{
    partial class ProfilePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.textEmail = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.textTotalRead = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.textAverageRating = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(77, 73);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(210, 304);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(344, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Name";
            // 
            // textName
            // 
            this.textName.AutoSize = true;
            this.textName.Location = new System.Drawing.Point(476, 88);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(0, 0);
            this.textName.TabIndex = 2;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(344, 145);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Email";
            // 
            // textEmail
            // 
            this.textEmail.AutoSize = true;
            this.textEmail.Location = new System.Drawing.Point(476, 145);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(0, 0);
            this.textEmail.TabIndex = 4;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(344, 197);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(70, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Total Read";
            // 
            // textTotalRead
            // 
            this.textTotalRead.AutoSize = true;
            this.textTotalRead.Location = new System.Drawing.Point(476, 197);
            this.textTotalRead.Name = "textTotalRead";
            this.textTotalRead.Size = new System.Drawing.Size(0, 0);
            this.textTotalRead.TabIndex = 6;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(344, 243);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(99, 19);
            this.metroLabel7.TabIndex = 7;
            this.metroLabel7.Text = "Average Rating";
            // 
            // textAverageRating
            // 
            this.textAverageRating.AutoSize = true;
            this.textAverageRating.Location = new System.Drawing.Point(476, 243);
            this.textAverageRating.Name = "textAverageRating";
            this.textAverageRating.Size = new System.Drawing.Size(0, 0);
            this.textAverageRating.TabIndex = 8;
            // 
            // ProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textAverageRating);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.textTotalRead);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox);
            this.Name = "ProfilePage";
            this.Size = new System.Drawing.Size(886, 473);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel textName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel textEmail;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel textTotalRead;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel textAverageRating;
    }
}
