using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day3HandsOnSession
{
    public partial class Example3_1 : Form
    {
        private Size originalSize;

        public Example3_1()
        {
            InitializeComponent();
            originalSize = new Size(this.pictureBox1.Width, this.pictureBox1.Height);
        }

        private void smallerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Width /= 2;
            this.pictureBox1.Height /= 2;
        }

        private void normalSizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Width = originalSize.Width;
            this.pictureBox1.Height = originalSize.Height;
        }

        private void enlargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Width *= 2;
            this.pictureBox1.Height *= 2;
        }
    }
}
