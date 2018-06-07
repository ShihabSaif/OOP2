using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ModelLayer;
using DataLayer;
using BusinessLayer;

namespace InterfaceLayer
{
    public partial class AdminBookStore : ControlUserControl//UserControl
    {
        public AdminBookStore()
        {
            InitializeComponent();
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void btnImageChoose_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()) //{ Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            if (string.IsNullOrEmpty(TextDescription.Text) || string.IsNullOrEmpty(TextAuthor.Text) || string.IsNullOrEmpty(TextName.Text) || string.IsNullOrEmpty(ComboCategory.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "All field should be filled up.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextName.Focus();
                return;
            }
            else
            {
                if (TextName.Text.Length <= 50)
                {
                    b.name = TextName.Text;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Book Name Too Big.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (TextAuthor.Text.Length <= 50)
                {
                    b.author = TextAuthor.Text;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Author Name Too Big.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (TextDescription.Text.Length <= 500)
                {
                    b.description = TextDescription.Text;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Description Too Big.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (pictureBox.Image != null)
                {
                    b.picture = imageToByteArray(pictureBox.Image);
                    //return;
                }

                if (!string.IsNullOrEmpty(TextLink.Text))
                {
                    b.link = TextLink.Text;
                }
                b.category = ComboCategory.Text;
                b.rating = 0;

                BookServices.Insert(b);
                MetroFramework.MetroMessageBox.Show(this, "Added successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Refresh();
                TextDescription.Clear();
                TextAuthor.Clear();
                TextName.Clear();
                ComboCategory.SelectedIndex = 0;
                TextLink.Clear();
                pictureBox.Image = null;

            }
        }
    }
}
