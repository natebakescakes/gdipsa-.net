using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshops.Day1HandsOnSession
{
    public partial class CatchAGenie : Form
    {
        public CatchAGenie()
        {
            InitializeComponent();
        }

        private void Lamp_Click(object sender, EventArgs e)
        {
            this.Genie.Visible = true;
        }

        private void Genie_MouseMove(object sender, MouseEventArgs e)
        {
            this.Genie.Visible = false;
        }

        private void Lamp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Original size 728, 815
            this.Genie.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Genie.Size = new System.Drawing.Size(1500, 1500);
            //this.Genie.Visible = true;
        }
    }
}
