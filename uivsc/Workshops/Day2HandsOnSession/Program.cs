using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshops.Day2HandsOnSession
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
            //Application.Run(new Example2_1());
            //Application.Run(new Example2_2());
            //Application.Run(new Example2_3());
            //Application.Run(new Example2_4());
            //Application.Run(new Example2_7());
            //Application.Run(new Example2_9());
            //Application.Run(new IceCreamParlour());
            Application.Run(new CustomerForm());
        }
    }
}
