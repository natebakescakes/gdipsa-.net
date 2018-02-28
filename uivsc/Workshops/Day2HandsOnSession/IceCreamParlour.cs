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
    public partial class IceCreamParlour : Form
    {
        public IceCreamParlour()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string size = "", flavour = "";
            var toppings = new List<string>();

            //Size
            switch (this.sizeComboBox.Text)
            {
                case "Small":
                    size = "Small";
                    break;
                case "Medium":
                    size = "Medium";
                    break;
                case "Big":
                    size = "Big";
                    break;
                default:
                    break;
            }

            //Flavour
            if (this.optChocolate.Checked)
                flavour = "Chocolate";
            else if (this.optStrawberry.Checked)
                flavour = "Strawberry";

            //Toppings
            if (this.optNuts.Checked)
                toppings.Add("Nuts");
            if (this.optRaisins.Checked)
                toppings.Add("Raisins");
            if (this.optChocolateTopping.Checked)
                toppings.Add("Chocolate");

            MessageBox.Show($"Your order is a {size} {flavour} Ice-cream!\n" +
                (toppings.Count != 0 ? $"Toppings are {String.Join(", ", toppings)}." : "No Toppings."));
        }
    }
}
