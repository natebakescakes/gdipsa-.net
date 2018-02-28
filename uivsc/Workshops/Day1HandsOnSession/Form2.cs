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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button1 has been clicked");
            MessageBox.Show($"Height is {btnButton1.Height}, Width is {btnButton1.Width}");
        }
    }
}
