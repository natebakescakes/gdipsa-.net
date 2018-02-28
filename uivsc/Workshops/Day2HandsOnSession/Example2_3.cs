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
    public partial class Example2_3 : Form
    {
        public Example2_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You typed {this.textBox1.Text.Length} characters.");
        }
    }
}
