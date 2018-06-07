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
using BusinessLayer;
using DataLayer;
using System.IO;

namespace InterfaceLayer
{
    public partial class ProfilePage : ControlUserControl//UserControl
    {
        public ProfilePage(User u)
        {
            InitializeComponent();
            setData(u);
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public void setData(User u)
        {
            textName.Text = u.name;
            textEmail.Text = u.email;
            if (u.picture != null)
            {
                pictureBox.Image = byteArrayToImage(u.picture);
            }

            textAverageRating.Text = User_BookServices.AvarageRating(u.id).ToString();
            textTotalRead.Text = User_BookServices.CountBook(u.id).ToString();

        }
    }
}
