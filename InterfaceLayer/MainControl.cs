using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
    //public delegate void BackButton(UserControl uc);
    public partial class MainControl : ControlUserControl//UserControl
    {
        TabPage tabProfile;
        //public event BackButton BackButtonEvent;
        public MainControl()
        {
            InitializeComponent();
            //BrowseControl bc = new BrowseControl();
            //CategoryDisplayEvent += ShowCategoryDisplay;
            //BrowseControl bc = new BrowseControl(tabBrowse);
            //bc.ShowCategoryListEvent += ShowCategoryDisplay;
            StarterForm.BackButtonEvent += implementBack;
            IndividualBook.IndividualBookShowEvent += BookDescriptionShow;
            //Form2.Back(bc);
            //tabBrowse.Controls.Add(bc);
            //SearchControl sc = new SearchControl(tabSearch);
            //sc.SeachEvent += SearchDisplay();
            //tabSearch.Controls.Add(sc);
            //tabHome.Controls.Add(new CategoryDisplay("Educational"));
            CategoryDisplay cd = new CategoryDisplay();
            cd.HomePage(this, tabHome);
            StarterForm.browserBackList.Add(cd);
            StarterForm.browseBackTabList.Add(tabHome);
            tabHome.Controls.Add(cd);

        }

        public void implementBack(UserControl uc, TabPage tb)
        {
            //Form2.Back(uc);
            //StarterForm.browserBackList.RemoveAt(StarterForm.browserBackList.Count - 1);
            //StarterForm.browseBackTabList.RemoveAt(StarterForm.browseBackTabList.Count - 1);
            //StarterForm.browserBackList.Add(uc);
            //StarterForm.browseBackTabList.Add(tb);
            tb.Controls.Clear();
            tb.Controls.Add(uc);
        }

        public void BookAddTab()
        {
            AdminBookStore bookAdd = new AdminBookStore();
            StarterForm.browserBackList.Add(bookAdd);
            StarterForm.browseBackTabList.Add(tabMyBook);
            this.tabMyBook.Controls.Add(bookAdd);
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        public void ShowUserInfo(User u)
        {
            btnJoin.Hide();
            btnSighIn.Hide();
            if (u.picture != null)
            {
                userImage.Image = byteArrayToImage(u.picture);
                userImage.Show();
            }
            btnLogout.Visible = true;
            tabProfile = new TabPage();
            tabProfile.Location = new System.Drawing.Point(4, 44);
            tabProfile.Name = "tabProfile";
            tabProfile.Size = new System.Drawing.Size(886, 473);
            tabProfile.TabIndex = 4;
            tabProfile.Text = "My Profile";
           
            this.tabControl.Controls.Add(tabProfile);
            ProfilePage pp = new ProfilePage(u);
            StarterForm.browserBackList.Add(pp);
            StarterForm.browseBackTabList.Add(tabProfile);
            tabProfile.Controls.Add(pp);

            if (StarterForm.isAdmin == true)
            {
                AdminBookStore bookAdd = new AdminBookStore();
                StarterForm.browserBackList.Add(bookAdd);
                StarterForm.browseBackTabList.Add(tabMyBook);
                tabMyBook.Controls.Clear();
                this.tabMyBook.Controls.Add(bookAdd);
            }
            else
            {
                CategoryDisplay cd = new CategoryDisplay();
                if (cd.ShowUserBook(StarterForm.loggedInUser.id, this, tabMyBook))
                {
                    StarterForm.browserBackList.Add(cd);
                    StarterForm.browseBackTabList.Add(tabMyBook);
                    tabMyBook.Controls.Clear();
                    tabMyBook.Controls.Add(cd);
                }
            }
        }

        public void BookDescriptionShow(BookDescription bd, TabPage tb)
        {
            StarterForm.browserBackList.Add(bd);
            StarterForm.browseBackTabList.Add(tb);
            tb.Controls.Clear();
            tb.Controls.Add(bd);
        }

        public void ShowCategoryDisplay(string category, TabPage tb)
        {
            CategoryDisplay cd = new CategoryDisplay();
            cd.ShowCategory(category, this, tb);
            StarterForm.browserBackList.Add(cd);
            StarterForm.browseBackTabList.Add(tb);
            tabBrowse.Controls.Clear();
            //TabPage tb = new TabPage();
            //tb.Controls.Add(new lala());
            tabBrowse.Controls.Add(cd);
           
            //StarterForm.Back(cd);
            //tabControl.Controls.Add(tabBrowse);
        }

        private void btnSighIn_Click(object sender, EventArgs e)
        {
            SignInForm sif = new SignInForm();
            sif.BookStoreEvent += BookAddTab;
            sif.UserInfoShowEvent += ShowUserInfo;
            sif.Show();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            JoinForm jf = new JoinForm();
            jf.Show();
        }

        private void userImage_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            StarterForm.loggedStatus = false;
            StarterForm.loggedInUser = null;
            StarterForm.isAdmin = false;
            btnJoin.Show();
            btnSighIn.Show();
           
            userImage.Hide();
            btnLogout.Visible = false;
            this.tabControl.Controls.Remove(tabProfile);
            tabMyBook.Controls.Clear();
            tabControl.SelectedIndex = 0;
            this.Refresh();
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabHome)
            {
                CategoryDisplay cd = new CategoryDisplay();
                cd.HomePage(this, tabHome);
                StarterForm.browserBackList.Add(cd);
                StarterForm.browseBackTabList.Add(tabHome);
                tabHome.Controls.Clear();
                tabHome.Controls.Add(cd);                
            }
            else if (e.TabPage == tabMyBook)
            {
                if (StarterForm.loggedStatus == true)
                {
                    if (StarterForm.isAdmin==true)
                    {
                        AdminBookStore bookAdd = new AdminBookStore();
                        StarterForm.browserBackList.Add(bookAdd);
                        StarterForm.browseBackTabList.Add(tabMyBook);
                        tabMyBook.Controls.Clear();
                        this.tabMyBook.Controls.Add(bookAdd);
                    }
                    else
                    {
                        CategoryDisplay cd = new CategoryDisplay();
                        if (cd.ShowUserBook(StarterForm.loggedInUser.id, this, tabMyBook))
                        {
                            StarterForm.browserBackList.Add(cd);
                            StarterForm.browseBackTabList.Add(tabMyBook);
                            tabMyBook.Controls.Clear();
                            tabMyBook.Controls.Add(cd);
                        }
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Join Us to get access.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabControl.SelectedIndex=0;
                }
            }
            else if (e.TabPage == tabBrowse)
            {
                    BrowseControl bc = new BrowseControl(tabBrowse);
                    bc.ShowCategoryListEvent += ShowCategoryDisplay;
                    StarterForm.browserBackList.Add(bc);
                    StarterForm.browseBackTabList.Add(tabBrowse);
                    tabBrowse.Controls.Clear();
                    tabBrowse.Controls.Add(bc);              
            }
            else if (e.TabPage == tabSearch)
            {
                    SearchControl sc = new SearchControl(tabSearch);
                    StarterForm.browserBackList.Add(sc);
                    StarterForm.browseBackTabList.Add(tabSearch);
                    tabSearch.Controls.Clear();
                    tabSearch.Controls.Add(sc);
            }
            else if (e.TabPage == tabProfile)
            {
                if (StarterForm.loggedStatus == true)
                {

                }
                else
                {

                }
            }
        }
    }
}
