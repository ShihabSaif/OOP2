namespace InterfaceLayer
{
    partial class MainControl
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
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabMyBook = new System.Windows.Forms.TabPage();
            this.tabBrowse = new System.Windows.Forms.TabPage();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnSighIn = new System.Windows.Forms.Button();
            this.userImage = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHome);
            this.tabControl.Controls.Add(this.tabMyBook);
            this.tabControl.Controls.Add(this.tabBrowse);
            this.tabControl.Controls.Add(this.tabSearch);
            this.tabControl.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.tabControl.Location = new System.Drawing.Point(3, 137);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(894, 521);
            this.tabControl.Style = MetroFramework.MetroColorStyle.Teal;
            this.tabControl.TabIndex = 0;
            this.tabControl.UseSelectable = true;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabHome
            // 
            this.tabHome.Location = new System.Drawing.Point(4, 44);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(886, 473);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            // 
            // tabMyBook
            // 
            this.tabMyBook.Location = new System.Drawing.Point(4, 44);
            this.tabMyBook.Name = "tabMyBook";
            this.tabMyBook.Size = new System.Drawing.Size(886, 473);
            this.tabMyBook.TabIndex = 1;
            this.tabMyBook.Text = "MyBook";
            // 
            // tabBrowse
            // 
            this.tabBrowse.Location = new System.Drawing.Point(4, 44);
            this.tabBrowse.Name = "tabBrowse";
            this.tabBrowse.Size = new System.Drawing.Size(886, 473);
            this.tabBrowse.TabIndex = 2;
            this.tabBrowse.Text = "Browse";
            // 
            // tabSearch
            // 
            this.tabSearch.Location = new System.Drawing.Point(4, 44);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Size = new System.Drawing.Size(886, 473);
            this.tabSearch.TabIndex = 3;
            this.tabSearch.Text = "Search";
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnJoin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJoin.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoin.Location = new System.Drawing.Point(796, 69);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(101, 40);
            this.btnJoin.TabIndex = 1;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = false;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnSighIn
            // 
            this.btnSighIn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSighIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSighIn.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSighIn.Location = new System.Drawing.Point(689, 69);
            this.btnSighIn.Name = "btnSighIn";
            this.btnSighIn.Size = new System.Drawing.Size(101, 40);
            this.btnSighIn.TabIndex = 2;
            this.btnSighIn.Text = "Sign In";
            this.btnSighIn.UseVisualStyleBackColor = false;
            this.btnSighIn.Click += new System.EventHandler(this.btnSighIn_Click);
            // 
            // userImage
            // 
            this.userImage.Location = new System.Drawing.Point(817, 69);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(80, 40);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImage.TabIndex = 3;
            this.userImage.TabStop = false;
            this.userImage.Visible = false;
            this.userImage.Click += new System.EventHandler(this.userImage_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(710, 69);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(101, 40);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.userImage);
            this.Controls.Add(this.btnSighIn);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.tabControl);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(900, 658);
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabMyBook;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnSighIn;
        private System.Windows.Forms.PictureBox userImage;
        private System.Windows.Forms.TabPage tabBrowse;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private System.Windows.Forms.Button btnLogout;
    }
}
