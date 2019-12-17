using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dalzate1d1
{
    public partial class frmCurrencyConverter : Form
    {
        public frmCurrencyConverter()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtAmountAustralia_TextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (
                Convert.ToDecimal(txtAmountAustralia.Text) * Convert.ToDecimal(txtRateAustralia.Text)
                ).ToString("0.00");
        }

        private void TxtRateAustralia_TextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (
                Convert.ToDecimal(txtAmountAustralia.Text) * Convert.ToDecimal(txtRateAustralia.Text)
                ).ToString("0.00");
        }

        private void AustraliaTextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (
                Convert.ToDecimal(txtAmountAustralia.Text) * Convert.ToDecimal(txtRateAustralia.Text)
                ).ToString("0.00");
        }

        private void TxtTotalUSD_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BhutanTextChanged(object sender, EventArgs e)
        {
            txtUSDBhutan.Text = (
                   Convert.ToDecimal(txtAmountBhutan.Text) * Convert.ToDecimal(txtRateBhutan.Text)
                   ).ToString("0.00");
        }

        private void CostaRicaTextChanged(object sender, EventArgs e)
        {
            txtUSDCostaRica.Text = (
                   Convert.ToDecimal(txtAmountCostaRica.Text) * Convert.ToDecimal(txtRateCostaRica.Text)
                   ).ToString("0.00");
        }

        private void EuroTextChanged(object sender, EventArgs e)
        {
            txtUSDEuro.Text = (
                   Convert.ToDecimal(txtAmountEuro.Text) * Convert.ToDecimal(txtRateEuro.Text)
                   ).ToString("0.00");
        }

        private void USTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDAustralia.Text) + Convert.ToDecimal(txtUSDBhutan.Text)
                + Convert.ToDecimal(txtUSDCostaRica.Text) + Convert.ToDecimal(txtUSDEuro.Text)
                ).ToString("0.00");
        }

        private void BtnResets_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtRateAustralia.Text = "0.684890";
            txtAmountBhutan.Text = "0.00";
            txtRateBhutan.Text = "0.0139607";
            txtAmountCostaRica.Text = "0.00";
            txtRateCostaRica.Text = "0.00175937";
            txtAmountEuro.Text = "0.00";
            txtRateEuro.Text = "1.10464";
        }
    }
}
