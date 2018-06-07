using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceLayer
{
    public partial class FrontImage : ControlUserControl//UserControl
    {
        Panel p;
        StarterForm sf;
        public FrontImage(Panel p, StarterForm sf)
        {
            this.sf = sf;
            this.p = p;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainControl mc = new MainControl();
            //sf.btnBack.Visible = true;
            sf.pictureBack.Visible = true;
            p.Controls.Add(mc);
            
        }
    }
}
