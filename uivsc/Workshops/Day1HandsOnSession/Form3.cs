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
    public partial class frmDetails : Form
    {
        public frmDetails()
        {
            InitializeComponent();
        }

        private void frmDetails_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.btnReset.Font = new System.Drawing.Font(
                "Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(200, 200);
            this.btnReset.Text = "Reset";
        }
    }
}
