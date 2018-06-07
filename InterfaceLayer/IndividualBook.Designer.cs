namespace InterfaceLayer
{
    partial class IndividualBook
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.textDescription = new MetroFramework.Controls.MetroTextBox();
            this.textName = new MetroFramework.Controls.MetroLabel();
            this.textAuthor = new MetroFramework.Controls.MetroLabel();
            this.textCategory = new MetroFramework.Controls.MetroLabel();
            this.textRating = new MetroFramework.Controls.MetroLabel();
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(32, 23);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(146, 160);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.picture_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(216, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(216, 82);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Author";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(216, 126);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Description";
            this.metroLabel3.Visible = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(518, 82);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Rating";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(518, 35);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(64, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Category";
            this.metroLabel5.Visible = false;
            // 
            // textDescription
            // 
            this.textDescription.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.textDescription.CustomButton.Image = null;
            this.textDescription.CustomButton.Location = new System.Drawing.Point(406, 1);
            this.textDescription.CustomButton.Name = "";
            this.textDescription.CustomButton.Size = new System.Drawing.Size(103, 103);
            this.textDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textDescription.CustomButton.TabIndex = 1;
            this.textDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textDescription.CustomButton.UseSelectable = true;
            this.textDescription.CustomButton.Visible = false;
            this.textDescription.Lines = new string[0];
            this.textDescription.Location = new System.Drawing.Point(314, 98);
            this.textDescription.MaxLength = 32767;
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.PasswordChar = '\0';
            this.textDescription.ReadOnly = true;
            this.textDescription.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textDescription.SelectedText = "";
            this.textDescription.SelectionLength = 0;
            this.textDescription.SelectionStart = 0;
            this.textDescription.ShortcutsEnabled = true;
            this.textDescription.Size = new System.Drawing.Size(510, 105);
            this.textDescription.TabIndex = 6;
            this.textDescription.UseSelectable = true;
            this.textDescription.Visible = false;
            this.textDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textName
            // 
            this.textName.AutoSize = true;
            this.textName.Location = new System.Drawing.Point(314, 35);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(0, 0);
            this.textName.TabIndex = 7;
            // 
            // textAuthor
            // 
            this.textAuthor.AutoSize = true;
            this.textAuthor.Location = new System.Drawing.Point(314, 82);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.Size = new System.Drawing.Size(0, 0);
            this.textAuthor.TabIndex = 8;
            // 
            // textCategory
            // 
            this.textCategory.AutoSize = true;
            this.textCategory.Location = new System.Drawing.Point(625, 35);
            this.textCategory.Name = "textCategory";
            this.textCategory.Size = new System.Drawing.Size(0, 0);
            this.textCategory.TabIndex = 9;
            this.textCategory.Visible = false;
            // 
            // textRating
            // 
            this.textRating.AutoSize = true;
            this.textRating.Location = new System.Drawing.Point(625, 82);
            this.textRating.Name = "textRating";
            this.textRating.Size = new System.Drawing.Size(0, 0);
            this.textRating.TabIndex = 10;
            this.textRating.Click += new System.EventHandler(this.textRating_Click);
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // IndividualBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.textRating);
            this.Controls.Add(this.textCategory);
            this.Controls.Add(this.textAuthor);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox);
            this.Name = "IndividualBook";
            this.Size = new System.Drawing.Size(207, 206);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox textDescription;
        private MetroFramework.Controls.MetroLabel textName;
        private MetroFramework.Controls.MetroLabel textAuthor;
        private MetroFramework.Controls.MetroLabel textCategory;
        private MetroFramework.Controls.MetroLabel textRating;
        private MetroFramework.Components.MetroToolTip metroToolTip;
    }
}
