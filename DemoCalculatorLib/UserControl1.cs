using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCalculatorLib
{
    public partial class UserControl1: UserControl
    {

        const double pricePizza = 1.99;
        const double priceSalad = 2.99;
        const double priceCoffee = 1.99;
        const double priceLatte = 5.99;
        const double priceSandwich = 10.00;
        const double pricePasta = 5.49;
        const double priceSauce = 0.50;
        const double priceWater = 1.10;

        double decTotal = 0.0;
        double decTotalTax = 0.0;
        double decCompleteTotal = 0.0;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            receiptItems.AppendText("Purchased: Pizza for $" + pricePizza.ToString());
            receiptItems.AppendText(Environment.NewLine);
            decTotal += pricePizza;
        }

        private void btnSalad_Click(object sender, EventArgs e)
        {
            receiptItems.AppendText("Purchased: Salad for $" + priceSalad.ToString());
            receiptItems.AppendText(Environment.NewLine);
            decTotal += priceSalad;
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            receiptItems.AppendText("Purchased: Coffee for $" + priceCoffee.ToString());
            receiptItems.AppendText(Environment.NewLine);
            decTotal += priceCoffee;
        }

        private void btnLatte_Click(object sender, EventArgs e)
        {
            receiptItems.AppendText("Purchased: Latte for $" + priceLatte.ToString());
            receiptItems.AppendText(Environment.NewLine);
            decTotal += priceLatte;
        }

        private void btnSandwich_Click(object sender, EventArgs e)
        {
            receiptItems.AppendText("Purchased: Sandwich for $" + priceSandwich.ToString());
            receiptItems.AppendText(Environment.NewLine);
            decTotal += priceSandwich;
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            receiptItems.AppendText("Purchased: Pasta for $" + pricePasta.ToString());
            receiptItems.AppendText(Environment.NewLine);
            decTotal += pricePasta;
        }

        private void btnSauce_Click(object sender, EventArgs e)
        {
            receiptItems.AppendText("Purchased: Sauce for $" + priceSauce.ToString());
            receiptItems.AppendText(Environment.NewLine);
            decTotal += priceSauce;
        }

        private void btnWater_Click(object sender, EventArgs e)
        {
            receiptItems.AppendText("Purchased: Water for $" + priceWater.ToString());
            receiptItems.AppendText(Environment.NewLine);
            decTotal += priceWater;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            lblTotal.Text = "$" + decTotal.ToString();
        }

        private void btnTotalTax_Click(object sender, EventArgs e)
        {
            double tax = decTotal * 0.12; //Putting the Tax at 12%
            double complete = decTotal + tax;
            lblTotalTax.Text = "$" + tax.ToString();
            lblCompleteTotal.Text = "$" + complete.ToString();
        }
    }
}
