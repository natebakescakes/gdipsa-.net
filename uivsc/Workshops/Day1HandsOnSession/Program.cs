using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshops.Day1HandsOnSession
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new Form2());
            //Application.Run(new frmDetails());
            //Application.Run(new MySecondForm());
            //Application.Run(new CatchARabbit());
            //Application.Run(new KillARabbit());
            //Application.Run(new CatchAFish());
            Application.Run(new CatchAGenie());
        }
    }
}
