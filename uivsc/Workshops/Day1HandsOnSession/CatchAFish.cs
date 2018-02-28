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
    public partial class CatchAFish : Form
    {
        private Random random;
        private DateTime prevTime;
        private double highScore;

        public CatchAFish()
        {
            InitializeComponent();
            random = new Random();
            prevTime = DateTime.Now;
            highScore = Double.MaxValue;
        }

        private void CatchAFish_Load(object sender, EventArgs e)
        {
            this.button1.Location = new System.Drawing.Point(
                random.Next(0, this.ClientSize.Width - this.button1.Width),
                random.Next(0, this.ClientSize.Height - this.button1.Height)
                );

            this.timeSpanLabel.Text = prevTime.ToLongTimeString();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            var btn = sender as System.Windows.Forms.Button;

            //Move fish to random location
            btn.Location = new System.Drawing.Point(
                random.Next(0, this.ClientSize.Width - btn.Width),
                random.Next(0, this.ClientSize.Height - btn.Height)
                );

            //Update timeSpanLabel with Latest time difference
            this.timeSpanLabel.Text = $"{(DateTime.Now - prevTime).TotalMilliseconds.ToString():0.####} ms";

            //Update highScore if latest time difference lower than previous highScore
            if ((DateTime.Now - prevTime).TotalMilliseconds < highScore)
            {
                highScore = (DateTime.Now - prevTime).TotalMilliseconds;
                this.highScoreLabel.Text = $"{highScore:0.####} ms";
            }

            //Update previousTime
            prevTime = DateTime.Now;
            
        }
    }
}
