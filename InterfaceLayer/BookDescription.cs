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
using BusinessLayer;
using DataLayer;

namespace InterfaceLayer
{
    public partial class BookDescription : ControlUserControl//UserControl
    {
        TabPage tb;
        Book b;
        //public static event BackButton BackButtonEvent;
        public BookDescription()
        {
            InitializeComponent();
        }

        public void setData(Book b, TabPage tb)
        {
            this.b = b;
            this.tb = tb;
            textName.Text = b.name;
            textRating.Text = b.rating.ToString();
            textAuthor.Text = b.author;
            textCategory.Text = b.category;
            textBoxDescription.Text = b.description;
            textRating.Text = b.rating.ToString();
            if (b.picture != null)
            {
                pictureBox.Image = byteArrayToImage(b.picture);
            }
            if (StarterForm.loggedStatus == true)
            {
                int uid = StarterForm.loggedInUser.id;
                int bid = b.id;
                User_Book combination = User_BookServices.DuplicateCombination(uid, bid);
                
                metroLabel11.Visible=true;
                textBoxGiveRating.Visible = true;
                btnSave.Visible = true;
                metroLabel12.Visible = true;
                
                comboSelect.Visible = true;

                if (combination != null)
                {
                    textBoxGiveRating.Text = combination.rating.ToString();
                    if (combination.subscribe == 0)
                    {
                        comboSelect.SelectedIndex=0;
                    }
                    else if (combination.subscribe == 1)
                    {
                        comboSelect.SelectedIndex = 1;
                    }
                    else if (combination.subscribe == 2)
                    {
                        comboSelect.SelectedIndex = 2;
                    }
                    else if (combination.subscribe == 3)
                    {
                        comboSelect.SelectedIndex = 3;
                    }
                }
               
            }
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void Condition_Changed(object sender, EventArgs e)
        {
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //User u = UserServices.GetByEmail(Form2.loggedInUser.email);
            int uid = StarterForm.loggedInUser.id;
            int bid = b.id;
            User_Book ub = new User_Book();
            ub.book_id = bid;
            ub.user_id = uid;

            User_Book combination = User_BookServices.DuplicateCombination(uid, bid);

            if (combination==null)
            {
                if (comboSelect.Text == "Want to Read")
                {
                    ub.subscribe = 1;
                }
                else if (comboSelect.Text == "Currently Reading")
                {
                    ub.subscribe = 2;
                }
                else if (comboSelect.Text == "Read")
                {
                    ub.subscribe = 3;
                }
                else
                {
                    ub.subscribe = 0;
                }

                if (textBoxGiveRating.Text != "")
                {
                    ub.rating = Convert.ToInt32(textBoxGiveRating.Text);
                }

            
                User_BookServices.Insert(ub);
            }
            else
            {
                if (comboSelect.Text == "Want to Read")
                {
                    combination.subscribe = 1;
                }
                else if (comboSelect.Text == "Currently Reading")
                {
                    combination.subscribe = 2;
                }
                else if (comboSelect.Text == "Read")
                {
                    combination.subscribe = 3;
                }
                else
                {
                    combination.subscribe = 0;
                }

                if (textBoxGiveRating.Text != "")
                {
                    combination.rating = Convert.ToInt32(textBoxGiveRating.Text);
                }
                User_BookServices.Update(combination);
            }

            double avg = User_BookServices.SpecificAvarageRating(bid);
            Book book = BookServices.GetById(bid);
            if (avg <= 10)
            {
                book.rating = Convert.ToInt32(avg);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Rating should be between (0-10).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BookServices.Update(book);

        }

        private void ValuChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel_Click(object sender, EventArgs e)
        {
            if (b.link != null)
            {
                System.Diagnostics.Process.Start(b.link);
            }
        }
    }
}
