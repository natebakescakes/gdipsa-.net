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
    public partial class KillARabbit : Form
    {
        Random random;

        public KillARabbit()
        {
            InitializeComponent();
            random = new Random();
        }

        private void KillARabbit_Load(object sender, EventArgs e)
        {
            this.button1.Location = new System.Drawing.Point(
                random.Next(0, this.ClientSize.Width - this.button1.Width),
                random.Next(0, this.ClientSize.Height - this.button1.Height)
                );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var btn = sender as System.Windows.Forms.Button;

            btn.Location = new System.Drawing.Point(
                random.Next(0, this.ClientSize.Width - btn.Width),
                random.Next(0, this.ClientSize.Height - btn.Height)
                );
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            var btn = sender as System.Windows.Forms.Button;

            btn.Image = global::Workshops.Day1HandsOnSession.Properties.Resources.Easter_Rabbit_PNG_Pic;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            var btn = sender as System.Windows.Forms.Button;

            btn.Image = global::Workshops.Day1HandsOnSession.Properties.Resources.White_Rabbit;
        }
    }
}
