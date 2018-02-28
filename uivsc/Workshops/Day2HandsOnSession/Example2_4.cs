using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshops.Day2HandsOnSession
{
    public partial class Example2_4 : Form
    {
        public Example2_4()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (this.optSmall.Checked)
                MessageBox.Show("Small is selected.");
            else if (this.optMedium.Checked)
                MessageBox.Show("Medium is selected.");
            else if (this.optBig.Checked)
                MessageBox.Show("Big is selected.");
        }
    }
}
