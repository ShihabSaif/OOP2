namespace InterfaceLayer
{
    partial class StarterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StarterForm));
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBack = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pictureBack);
            this.panel.Controls.Add(this.btnBack);
            this.panel.Location = new System.Drawing.Point(0, 42);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(900, 658);
            this.panel.TabIndex = 0;
            // 
            // pictureBack
            // 
            this.pictureBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBack.BackgroundImage")));
            this.pictureBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBack.Location = new System.Drawing.Point(23, 72);
            this.pictureBack.Name = "pictureBack";
            this.pictureBack.Size = new System.Drawing.Size(49, 43);
            this.pictureBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBack.TabIndex = 1;
            this.pictureBack.TabStop = false;
            this.pictureBack.Visible = false;
            this.pictureBack.Click += new System.EventHandler(this.pictureBack_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(45, 47);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 36);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_click);
            // 
            // StarterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.panel);
            this.Name = "StarterForm";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        public System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.PictureBox pictureBack;
    }
}