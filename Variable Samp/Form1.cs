using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variable_Samp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //txtHotDogsSubtotal.Text = (
            //     4.0m * Convert.ToDecimal(txtHotDogs.Text)
            // ).ToString("0.00");
            int hotDogs = Convert.ToInt32(txtHotDogs.Text);
            decimal hotDogPrice = 4.0m;
            decimal hotDogSubtotal = hotDogs * hotDogPrice;
            txtHotDogsSubtotal.Text = hotDogSubtotal.ToString("0.00");

            //txtHamburgersSubtotal.Text = (
            //        5.0m * Convert.ToDecimal(txtHamburgers.Text)
            //    ).ToString("0.00");
            int hamburgers = Convert.ToInt32(txtHamburgers.Text);
            decimal hamburgerPrice = 5.0m;
            decimal hamburgerSubtotal = hamburgers * hamburgerPrice;
            txtHamburgersSubtotal.Text = hamburgerSubtotal.ToString("0.00");

            //txtPreTaxTotal.Text = (
            //        Convert.ToDecimal(txtHotDogsSubtotal.Text) + Convert.ToDecimal(txtHamburgersSubtotal.Text)
            //).ToString("0.00");
            decimal PreTaxTotal = hotDogSubtotal + hamburgerSubtotal;
            txtPreTaxTotal.Text = PreTaxTotal.ToString("0.00");


            //txtTax.Text = (
            //    0.06875m * Convert.ToDecimal(txtPreTaxTotal.Text) / 100m
            //    ).ToString("0.00");
            decimal Tax = 6.875m * PreTaxTotal / 100m;
            txtTax.Text = Tax.ToString("0.00");

            //txtTotal.Text = (
            //    Convert.ToDecimal(txtPreTaxTotal.Text) + Convert.ToDecimal(txtTax.Text)
            //    ).ToString("0.00");
            decimal Total = PreTaxTotal + Tax;
            txtTotal.Text = Total.ToString("0.00");

            btnClear.Focus();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotDogsSubtotal.Text = "";
            txtHamburgersSubtotal.Text = "";
            txtPreTaxTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";

            txtHotDogs.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
