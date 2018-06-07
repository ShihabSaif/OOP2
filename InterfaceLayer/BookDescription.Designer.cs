namespace InterfaceLayer
{
    partial class BookDescription
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
            this.textAuthor = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.textRating = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.textCategory = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.comboSelect = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.textBoxGiveRating = new MetroFramework.Controls.MetroTextBox();
            this.textBoxDescription = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(61, 71);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(197, 254);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(290, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Name";
            // 
            // textName
            // 
            this.textName.AutoSize = true;
            this.textName.Location = new System.Drawing.Point(382, 71);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(0, 0);
            this.textName.TabIndex = 2;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(290, 124);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Author";
            // 
            // textAuthor
            // 
            this.textAuthor.AutoSize = true;
            this.textAuthor.Location = new System.Drawing.Point(382, 124);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.Size = new System.Drawing.Size(0, 0);
            this.textAuthor.TabIndex = 4;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(288, 176);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(46, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Rating";
            // 
            // textRating
            // 
            this.textRating.AutoSize = true;
            this.textRating.Location = new System.Drawing.Point(382, 176);
            this.textRating.Name = "textRating";
            this.textRating.Size = new System.Drawing.Size(0, 0);
            this.textRating.TabIndex = 6;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(288, 221);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(64, 19);
            this.metroLabel7.TabIndex = 7;
            this.metroLabel7.Text = "Category";
            // 
            // textCategory
            // 
            this.textCategory.AutoSize = true;
            this.textCategory.Location = new System.Drawing.Point(382, 221);
            this.textCategory.Name = "textCategory";
            this.textCategory.Size = new System.Drawing.Size(0, 0);
            this.textCategory.TabIndex = 8;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(290, 271);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(74, 19);
            this.metroLabel9.TabIndex = 9;
            this.metroLabel9.Text = "Description";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 473);
            this.splitter1.TabIndex = 12;
            this.splitter1.TabStop = false;
            // 
            // comboSelect
            // 
            this.comboSelect.FormattingEnabled = true;
            this.comboSelect.ItemHeight = 23;
            this.comboSelect.Items.AddRange(new object[] {
            "",
            "Want to Read",
            "Currently Reading",
            "Read"});
            this.comboSelect.Location = new System.Drawing.Point(61, 358);
            this.comboSelect.Name = "comboSelect";
            this.comboSelect.Size = new System.Drawing.Size(197, 29);
            this.comboSelect.TabIndex = 0;
            this.comboSelect.UseSelectable = true;
            this.comboSelect.Visible = false;
            this.comboSelect.SelectedIndexChanged += new System.EventHandler(this.Condition_Changed);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(645, 176);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(128, 19);
            this.metroLabel11.TabIndex = 14;
            this.metroLabel11.Text = "Rate the Book (0-10)";
            this.metroLabel11.Visible = false;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(753, 211);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(20, 19);
            this.metroLabel12.TabIndex = 15;
            this.metroLabel12.Text = "%";
            this.metroLabel12.Visible = false;
            // 
            // textBoxGiveRating
            // 
            // 
            // 
            // 
            this.textBoxGiveRating.CustomButton.Image = null;
            this.textBoxGiveRating.CustomButton.Location = new System.Drawing.Point(43, 1);
            this.textBoxGiveRating.CustomButton.Name = "";
            this.textBoxGiveRating.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxGiveRating.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxGiveRating.CustomButton.TabIndex = 1;
            this.textBoxGiveRating.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxGiveRating.CustomButton.UseSelectable = true;
            this.textBoxGiveRating.CustomButton.Visible = false;
            this.textBoxGiveRating.Lines = new string[0];
            this.textBoxGiveRating.Location = new System.Drawing.Point(687, 211);
            this.textBoxGiveRating.MaxLength = 32767;
            this.textBoxGiveRating.Name = "textBoxGiveRating";
            this.textBoxGiveRating.PasswordChar = '\0';
            this.textBoxGiveRating.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxGiveRating.SelectedText = "";
            this.textBoxGiveRating.SelectionLength = 0;
            this.textBoxGiveRating.SelectionStart = 0;
            this.textBoxGiveRating.ShortcutsEnabled = true;
            this.textBoxGiveRating.Size = new System.Drawing.Size(65, 23);
            this.textBoxGiveRating.TabIndex = 1;
            this.textBoxGiveRating.UseSelectable = true;
            this.textBoxGiveRating.Visible = false;
            this.textBoxGiveRating.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxGiveRating.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxGiveRating.TextChanged += new System.EventHandler(this.ValuChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.AppWorkspace;
            // 
            // 
            // 
            this.textBoxDescription.CustomButton.Image = null;
            this.textBoxDescription.CustomButton.Location = new System.Drawing.Point(277, 1);
            this.textBoxDescription.CustomButton.Name = "";
            this.textBoxDescription.CustomButton.Size = new System.Drawing.Size(163, 163);
            this.textBoxDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxDescription.CustomButton.TabIndex = 1;
            this.textBoxDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxDescription.CustomButton.UseSelectable = true;
            this.textBoxDescription.CustomButton.Visible = false;
            this.textBoxDescription.Lines = new string[0];
            this.textBoxDescription.Location = new System.Drawing.Point(382, 271);
            this.textBoxDescription.MaxLength = 32767;
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.PasswordChar = '\0';
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxDescription.SelectedText = "";
            this.textBoxDescription.SelectionLength = 0;
            this.textBoxDescription.SelectionStart = 0;
            this.textBoxDescription.ShortcutsEnabled = true;
            this.textBoxDescription.Size = new System.Drawing.Size(441, 165);
            this.textBoxDescription.TabIndex = 18;
            this.textBoxDescription.UseSelectable = true;
            this.textBoxDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(61, 407);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(197, 29);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel.Location = new System.Drawing.Point(697, 126);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(126, 17);
            this.linkLabel.TabIndex = 19;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Buy from Amazon";
            this.linkLabel.Click += new System.EventHandler(this.linkLabel_Click);
            // 
            // BookDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxGiveRating);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.comboSelect);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.textCategory);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.textRating);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.textAuthor);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox);
            this.Name = "BookDescription";
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
        private MetroFramework.Controls.MetroLabel textAuthor;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel textRating;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel textCategory;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.Splitter splitter1;
        private MetroFramework.Controls.MetroComboBox comboSelect;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox textBoxGiveRating;
        private MetroFramework.Controls.MetroTextBox textBoxDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel linkLabel;
    }
}
