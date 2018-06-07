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
    public delegate void ShowCategoryList(string category, TabPage tb);
    public partial class BrowseControl : ControlUserControl//UserControl
    {
        TabPage tb;
        public event ShowCategoryList ShowCategoryListEvent;
        public BrowseControl(TabPage tb)
        {
            this.tb = tb;
            InitializeComponent();
        }

        private void Educational_Click(object sender, EventArgs e)
        {
            if (ShowCategoryListEvent != null)
            {
                ShowCategoryListEvent("Educational", tb);
            }

        }

        private void Thriller_Click(object sender, EventArgs e)
        {
            if (ShowCategoryListEvent != null)
            {
                ShowCategoryListEvent("Thriller", tb);
            }
        }

        private void Romance_Click(object sender, EventArgs e)
        {
            if (ShowCategoryListEvent != null)
            {
                ShowCategoryListEvent("Romance", tb);
            }
        }

        private void ScienceFiction_Click(object sender, EventArgs e)
        {
            if (ShowCategoryListEvent != null)
            {
                ShowCategoryListEvent("Science Fiction", tb);
            }
        }

        private void Fantasy_Click(object sender, EventArgs e)
        {
            if (ShowCategoryListEvent != null)
            {
                ShowCategoryListEvent("Fantasy", tb);
            }
        }

        private void Horror_Click(object sender, EventArgs e)
        {
            if (ShowCategoryListEvent != null)
            {
                ShowCategoryListEvent("Horror", tb);
            }
        }

        private void Music_Click(object sender, EventArgs e)
        {
            if (ShowCategoryListEvent != null)
            {
                ShowCategoryListEvent("Music", tb);
            }
        }

        private void Sports_Click(object sender, EventArgs e)
        {
            if (ShowCategoryListEvent != null)
            {
                ShowCategoryListEvent("Sports", tb);
            }
        }

        private void Mystery_Click(object sender, EventArgs e)
        {
            if (ShowCategoryListEvent != null)
            {
                ShowCategoryListEvent("Mystery", tb);
            }
        }

        private void Comic_Click(object sender, EventArgs e)
        {
            if (ShowCategoryListEvent != null)
            {
                ShowCategoryListEvent("Comic", tb);
            }
        }

        private void CookBook_Click(object sender, EventArgs e)
        {
            if (ShowCategoryListEvent != null)
            {
                ShowCategoryListEvent("Cookbook", tb);
            }
        }

        private void Crime_Click(object sender, EventArgs e)
        {
            if (ShowCategoryListEvent != null)
            {
                ShowCategoryListEvent("Crime", tb);
            }
        }

        private void Children_Click(object sender, EventArgs e)
        {
            if (ShowCategoryListEvent != null)
            {
                ShowCategoryListEvent("Children's", tb);
            }
        }

        private void Art_Click(object sender, EventArgs e)
        {
            if (ShowCategoryListEvent != null)
            {
                ShowCategoryListEvent("Art", tb);
            }
        }

        private void Biography_Click(object sender, EventArgs e)
        {
            if (ShowCategoryListEvent != null)
            {
                ShowCategoryListEvent("Biography", tb);
            }
        }

        private void Business_Click(object sender, EventArgs e)
        {
            if (ShowCategoryListEvent != null)
            {
                ShowCategoryListEvent("Business", tb);
            }
        }
    }
}
