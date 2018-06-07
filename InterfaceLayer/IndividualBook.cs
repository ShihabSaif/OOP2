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
    public delegate void IndividualBookShow(BookDescription bd, TabPage tb);
    public partial class IndividualBook : ControlUserControl//UserControl
    {
        public static event IndividualBookShow IndividualBookShowEvent;
        Book b;
        TabPage tb;
        public IndividualBook()
        {
            InitializeComponent();
            
        }

        public void setData(Book b, TabPage tb)
        {
            this.b = b;
            this.tb = tb;
            textName.Text = b.name;
            textAuthor.Text = b.author;
            textCategory.Text = b.category;
            textDescription.Text = b.description;
            textRating.Text = b.rating.ToString();
            metroToolTip.SetToolTip(pictureBox, b.category);
            if (b.picture != null)
            {
                pictureBox.Image = byteArrayToImage(b.picture);
            }
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void textRating_Click(object sender, EventArgs e)
        {

        }

        private void picture_Click(object sender, EventArgs e)
        {
            BookDescription bd = new BookDescription();
            bd.setData(b, tb);
            IndividualBookShowEvent?.Invoke(bd, tb);
        }
    }
}
