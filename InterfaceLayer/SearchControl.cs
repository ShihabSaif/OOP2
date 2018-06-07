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

namespace InterfaceLayer
{
    public partial class SearchControl : ControlUserControl//UserControl
    {
        TabPage tb;
        public SearchControl(TabPage tb)
        {
            this.tb = tb;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchFlowLayout.Controls.Clear();
            List<Book> book = BookServices.BookSearch(searchTextBox.Text);
            //List<Book> book = null;
            if (book.Count != 0)
            {
                foreach (var o in book)
                {
                    IndividualBook ib = new IndividualBook();
                    ib.setData(o, tb);
                    searchFlowLayout.Controls.Add(ib);
                }
                //MessageBox.Show("Book available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //MetroFramework.MetroMessageBox.Show(mc, "No Book available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("No Book available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Console.WriteLine("no book found");
            }
        }
    }
}
