using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshops.Day3HandsOnSession
{
    public partial class BusCase3_1 : Form
    {
        public BusCase3_1()
        {
            InitializeComponent();
        }

        private void menuStrip1_MouseEnter(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
                this.toolStripStatusLabel1.Text = ((ToolStripMenuItem)sender).Text;
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new CustomerForm();
            f.MdiParent = this;
            f.Show();
        }

        private void closeActiveWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
        }
    }
}