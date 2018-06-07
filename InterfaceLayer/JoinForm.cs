using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelLayer;
using DataLayer;
using BusinessLayer;
using System.IO;

namespace InterfaceLayer
{
    public partial class JoinForm : ControlForm//MetroFramework.Forms.MetroForm
    {
        public JoinForm()
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

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextName.Text) || string.IsNullOrEmpty(TextEmail.Text) || string.IsNullOrEmpty(TextPassword.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "All field should be filled up.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextName.Focus();
                return;
            }
            else
            {

                if (UserServices.DuplicateMail(TextEmail.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Mail Already Existed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                User u = new User();

                if (TextName.Text.Length <= 50 && TextEmail.Text.Length <= 50 && TextPassword.Text.Length <= 50)
                {
                    u.name = TextName.Text;

                    if (IsValidEmail(TextEmail.Text))
                    {
                        u.email = TextEmail.Text;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Invalid mail.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    u.password = TextPassword.Text;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Name, Password or Email is Too Big.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (pictureBox.Image != null)
                {
                    u.picture = imageToByteArray(pictureBox.Image);
                }

                else
                    u.picture = null;

                UserServices.Insert(u);
                MetroFramework.MetroMessageBox.Show(this, "Joined successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }
    }
}
