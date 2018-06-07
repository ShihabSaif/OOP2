namespace InterfaceLayer
{
    partial class AdminBookStore
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
            this.btnImageChoose = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TextName = new MetroFramework.Controls.MetroTextBox();
            this.TextAuthor = new MetroFramework.Controls.MetroTextBox();
            this.TextDescription = new MetroFramework.Controls.MetroTextBox();
            this.ComboCategory = new MetroFramework.Controls.MetroComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.TextLink = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(69, 42);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(195, 230);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // btnImageChoose
            // 
            this.btnImageChoose.Location = new System.Drawing.Point(69, 311);
            this.btnImageChoose.Name = "btnImageChoose";
            this.btnImageChoose.Size = new System.Drawing.Size(195, 38);
            this.btnImageChoose.TabIndex = 4;
            this.btnImageChoose.Text = "Choose Image";
            this.btnImageChoose.UseVisualStyleBackColor = true;
            this.btnImageChoose.Click += new System.EventHandler(this.btnImageChoose_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(289, 42);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(553, 53);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Author";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(289, 93);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Category";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(289, 147);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Description";
            // 
            // TextName
            // 
            // 
            // 
            // 
            this.TextName.CustomButton.Image = null;
            this.TextName.CustomButton.Location = new System.Drawing.Point(127, 2);
            this.TextName.CustomButton.Name = "";
            this.TextName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TextName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextName.CustomButton.TabIndex = 1;
            this.TextName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextName.CustomButton.UseSelectable = true;
            this.TextName.CustomButton.Visible = false;
            this.TextName.Lines = new string[0];
            this.TextName.Location = new System.Drawing.Point(378, 42);
            this.TextName.MaxLength = 32767;
            this.TextName.Multiline = true;
            this.TextName.Name = "TextName";
            this.TextName.PasswordChar = '\0';
            this.TextName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextName.SelectedText = "";
            this.TextName.SelectionLength = 0;
            this.TextName.SelectionStart = 0;
            this.TextName.ShortcutsEnabled = true;
            this.TextName.Size = new System.Drawing.Size(155, 30);
            this.TextName.TabIndex = 0;
            this.TextName.UseSelectable = true;
            this.TextName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextAuthor
            // 
            // 
            // 
            // 
            this.TextAuthor.CustomButton.Image = null;
            this.TextAuthor.CustomButton.Location = new System.Drawing.Point(152, 2);
            this.TextAuthor.CustomButton.Name = "";
            this.TextAuthor.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TextAuthor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextAuthor.CustomButton.TabIndex = 1;
            this.TextAuthor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextAuthor.CustomButton.UseSelectable = true;
            this.TextAuthor.CustomButton.Visible = false;
            this.TextAuthor.Lines = new string[0];
            this.TextAuthor.Location = new System.Drawing.Point(608, 42);
            this.TextAuthor.MaxLength = 32767;
            this.TextAuthor.Multiline = true;
            this.TextAuthor.Name = "TextAuthor";
            this.TextAuthor.PasswordChar = '\0';
            this.TextAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextAuthor.SelectedText = "";
            this.TextAuthor.SelectionLength = 0;
            this.TextAuthor.SelectionStart = 0;
            this.TextAuthor.ShortcutsEnabled = true;
            this.TextAuthor.Size = new System.Drawing.Size(180, 30);
            this.TextAuthor.TabIndex = 2;
            this.TextAuthor.UseSelectable = true;
            this.TextAuthor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextAuthor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextDescription
            // 
            // 
            // 
            // 
            this.TextDescription.CustomButton.Image = null;
            this.TextDescription.CustomButton.Location = new System.Drawing.Point(286, 1);
            this.TextDescription.CustomButton.Name = "";
            this.TextDescription.CustomButton.Size = new System.Drawing.Size(123, 123);
            this.TextDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextDescription.CustomButton.TabIndex = 1;
            this.TextDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextDescription.CustomButton.UseSelectable = true;
            this.TextDescription.CustomButton.Visible = false;
            this.TextDescription.Lines = new string[0];
            this.TextDescription.Location = new System.Drawing.Point(378, 147);
            this.TextDescription.MaxLength = 32767;
            this.TextDescription.Multiline = true;
            this.TextDescription.Name = "TextDescription";
            this.TextDescription.PasswordChar = '\0';
            this.TextDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextDescription.SelectedText = "";
            this.TextDescription.SelectionLength = 0;
            this.TextDescription.SelectionStart = 0;
            this.TextDescription.ShortcutsEnabled = true;
            this.TextDescription.Size = new System.Drawing.Size(410, 125);
            this.TextDescription.TabIndex = 3;
            this.TextDescription.UseSelectable = true;
            this.TextDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ComboCategory
            // 
            this.ComboCategory.FormattingEnabled = true;
            this.ComboCategory.ItemHeight = 23;
            this.ComboCategory.Items.AddRange(new object[] {
            "Art",
            "Biography",
            "Business",
            "Children\'s",
            "Comic",
            "Cookbook",
            "Crime",
            "Educational",
            "Fantasy",
            "Horror",
            "Music",
            "Mystery",
            "Romance",
            "Science Fiction",
            "Sports",
            "Thriller"});
            this.ComboCategory.Location = new System.Drawing.Point(378, 93);
            this.ComboCategory.Name = "ComboCategory";
            this.ComboCategory.Size = new System.Drawing.Size(155, 29);
            this.ComboCategory.TabIndex = 1;
            this.ComboCategory.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(378, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(410, 38);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(553, 93);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(31, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Link";
            // 
            // TextLink
            // 
            // 
            // 
            // 
            this.TextLink.CustomButton.Image = null;
            this.TextLink.CustomButton.Location = new System.Drawing.Point(152, 2);
            this.TextLink.CustomButton.Name = "";
            this.TextLink.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TextLink.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextLink.CustomButton.TabIndex = 1;
            this.TextLink.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextLink.CustomButton.UseSelectable = true;
            this.TextLink.CustomButton.Visible = false;
            this.TextLink.Lines = new string[0];
            this.TextLink.Location = new System.Drawing.Point(608, 92);
            this.TextLink.MaxLength = 32767;
            this.TextLink.Multiline = true;
            this.TextLink.Name = "TextLink";
            this.TextLink.PasswordChar = '\0';
            this.TextLink.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextLink.SelectedText = "";
            this.TextLink.SelectionLength = 0;
            this.TextLink.SelectionStart = 0;
            this.TextLink.ShortcutsEnabled = true;
            this.TextLink.Size = new System.Drawing.Size(180, 30);
            this.TextLink.TabIndex = 7;
            this.TextLink.UseSelectable = true;
            this.TextLink.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextLink.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AdminBookStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextLink);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ComboCategory);
            this.Controls.Add(this.TextDescription);
            this.Controls.Add(this.TextAuthor);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnImageChoose);
            this.Controls.Add(this.pictureBox);
            this.Name = "AdminBookStore";
            this.Size = new System.Drawing.Size(886, 473);
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
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox TextName;
        private MetroFramework.Controls.MetroTextBox TextAuthor;
        private MetroFramework.Controls.MetroTextBox TextDescription;
        private MetroFramework.Controls.MetroComboBox ComboCategory;
        private System.Windows.Forms.Button btnSave;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox TextLink;
    }
}
