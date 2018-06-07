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

namespace InterfaceLayer
{
    public delegate void BookStoreTab();
    public delegate void UserInfoShow(User u);
    public partial class SignInForm : ControlForm//MetroFramework.Forms.MetroForm
    {
        public event BookStoreTab BookStoreEvent;
        public event UserInfoShow UserInfoShowEvent;
        public SignInForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextEmail.Text) || string.IsNullOrEmpty(TextPassword.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "All field should be filled up.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextEmail.Focus();
                return;
            }
            else
            {
                var user = UserServices.LogIn(TextEmail.Text, TextPassword.Text);
                if (user != null)
                {
                    if (user.type == "admin")
                    {
                        StarterForm.isAdmin = true;
                        StarterForm.loggedStatus = true;
                        StarterForm.loggedInUser = user;
                        if (BookStoreEvent != null)
                        {
                            BookStoreEvent();
                            UserInfoShowEvent(user);
                        }
                    }
                    else
                    {
                        StarterForm.loggedStatus = true;
                        StarterForm.loggedInUser = user;
                        UserInfoShowEvent(user);
                    }
                    this.Hide();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Wrong Email or Password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextEmail.Focus();
                    return;
                }
                
            }
        }
    }
}
