using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dalzate1c1
{
    public partial class FrmFoodTruck : Form
    {
        public FrmFoodTruck()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtHotDogs_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Calculate_Click(object sender, EventArgs e)
        {
            txtHotDogsSubtotal.Text = ( 
                    4.0m * Convert.ToDecimal(txtHotDogs.Text)
                ).ToString("0.00");

            txtHamburgersSubtotal.Text = ( 
                    5.0m * Convert.ToDecimal(txtHamburgers.Text)
                ).ToString("0.00");

            txtPreTaxTotal.Text = ( 
                    Convert.ToDecimal(txtHotDogsSubtotal.Text) + Convert.ToDecimal(txtHamburgersSubtotal.Text)
            ).ToString("0.00");

            txtTax.Text = ( 
                0.06875m * Convert.ToDecimal(txtPreTaxTotal.Text)
                ).ToString("0.00");

            txtTotal.Text = ( 
                Convert.ToDecimal(txtPreTaxTotal) + Convert.ToDecimal(txtTax.Text)
                ).ToString("0.00");

            btnClear.Focus();
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void TxtHamburgers_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFoodTruck_Load(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotDogsSubtotal.Text = "";

            txtHotDogs.Focus();

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            txtHotDogsSubtotal.Text = (
                  4.0m * Convert.ToDecimal(txtHotDogs.Text)
              ).ToString("0.00");

            txtHamburgersSubtotal.Text = (
                    5.0m * Convert.ToDecimal(txtHamburgers.Text)
                ).ToString("0.00");

            txtPreTaxTotal.Text = (
                    Convert.ToDecimal(txtHotDogsSubtotal.Text) + Convert.ToDecimal(txtHamburgersSubtotal.Text)
            ).ToString("0.00");

            txtTax.Text = (
                0.06875m * Convert.ToDecimal(txtPreTaxTotal.Text)
                ).ToString("0.00");

            txtTotal.Text = (
                Convert.ToDecimal(txtPreTaxTotal.Text) + Convert.ToDecimal(txtTax.Text)
                ).ToString("0.00");

            btnClear.Focus();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TxtPreTaxTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTax_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtHamburgersSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
