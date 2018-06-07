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
    public partial class CategoryDisplay : ControlUserControl//UserControl
    {
        public CategoryDisplay()
        {
            InitializeComponent();
            //ShowCategory(category, mc, tb);
        }

        public void ShowCategory(String category, MainControl mc, TabPage tb)
        {
            List<Book> book = BookServices.CatagorySearch(category);
            //List<Book> book = null;
            if (book.Count != 0)
            {
                foreach (var o in book)
                {
                    IndividualBook ib = new IndividualBook();
                    ib.setData(o, tb);
                    flowLayoutPanel.Controls.Add(ib);                    
                }
                //MessageBox.Show("Book available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(mc, "No Book available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("No Book available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Console.WriteLine("no book found");
            }
        }

        public Boolean ShowUserBook(int uid, MainControl mc, TabPage tb)
        {
            List<User_Book> booklist = User_BookServices.GetUserBooks(uid);
            //int i = Convert.ToInt32(booklist[1].book_id);
            //List<Book> book = null;
            if (booklist.Count != 0)
            {
                int i = 0;
                List<Book> book = new List<Book>();
                foreach(var b in booklist)
                {
                    book.Add(BookServices.GetById(Convert.ToInt32(booklist[i++].book_id)));
                }
                // = BookServices.CatagorySearch(category);
                
                foreach (var o in book)
                {
                    IndividualBook ib = new IndividualBook();
                    ib.setData(o, tb);
                    flowLayoutPanel.Controls.Add(ib);
                }

                return true;
                //MessageBox.Show("Book available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //MetroFramework.MetroMessageBox.Show(mc, "No Book available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("No Book available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Console.WriteLine("no book found");
                return false; 
            }
        }

        public void HomePage(MainControl mc, TabPage tb)
        {
            List<Book> book = BookServices.GroupByMaximum();
            //List<Book> book = null;
            if (book.Count != 0)
            {
                foreach (var o in book)
                {
                    IndividualBook ib = new IndividualBook();
                    ib.setData(o, tb);
                    flowLayoutPanel.Controls.Add(ib);
                }
                //MessageBox.Show("Book available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(mc, "No Book available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("No Book available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Console.WriteLine("no book found");
            }
        }
    }
}
