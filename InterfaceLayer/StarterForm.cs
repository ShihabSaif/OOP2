using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using ModelLayer;
using BusinessLayer;

namespace InterfaceLayer
{
    public delegate void BackButton(UserControl uc, TabPage tb);
    public partial class StarterForm : ControlForm//MetroFramework.Forms.MetroForm
    {
        public static User loggedInUser;
        public static bool loggedStatus = false;
        public static bool isAdmin = false;
        public static event BackButton BackButtonEvent;
        public static List<UserControl> browserBackList = new List<UserControl>();
        public static List<TabPage> browseBackTabList = new List<TabPage>();
        FrontImage fi;
        public StarterForm()
        {
            InitializeComponent();
            fi = new FrontImage(panel, this);
            panel.Controls.Add(fi);
        }

        private void btnBack_click(object sender, EventArgs e)
        {
         
        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            UserControl uc;
            TabPage tb;
            if (browserBackList.Count >= 2 && browseBackTabList.Count >= 2)
            {
                uc = browserBackList[browserBackList.Count - 2];
                browserBackList.RemoveAt(browserBackList.Count - 1);

                tb = browseBackTabList[browseBackTabList.Count - 2];

                browseBackTabList.RemoveAt(browseBackTabList.Count - 1);

                BackButtonEvent?.Invoke(uc, tb);
            }
        }
    }
}
