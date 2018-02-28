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
    public partial class MySecondForm : Form
    {
        public MySecondForm()
        {
            InitializeComponent();
        }

        private void MySecondForm_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(199, 264);
            MessageBox.Show("This is MySecondForm");
        }

        private void MySecondForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Bye Bye");
        }
    }
}
