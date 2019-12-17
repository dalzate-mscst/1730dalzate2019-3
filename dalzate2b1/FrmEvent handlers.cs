using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dalzate2b1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            decimal amountAustralia = Convert.ToDecimal (txtAmountAustralia.Text);
            decimal rateAustralia = 0.684890m;
            decimal usdAustralia = amountAustralia * rateAustralia;
            txtUSDAustralia.Text = usdAustralia.ToString("0.00");

            decimal amountBhutan = Convert.ToDecimal (txtAmountBhutan.Text);
            decimal rateBhutan = 0.0139607m;
            decimal usdBhutan = amountBhutan * rateBhutan;
            txtUSDBhutan.Text = usdBhutan.ToString("0.00");

            decimal amountCostaRica = Convert.ToDecimal (txtAmountCostaRica.Text);
            decimal rateCostaRica = 0.00175937m;
            decimal usdCostaRica = amountCostaRica * rateCostaRica;
            txtUSDCostaRica.Text = usdCostaRica.ToString("0.00");

            decimal amountEuro = Convert.ToDecimal (txtAmountEuro.Text);
            decimal rateEuro = 1.10464m;
            decimal usdEuro = amountEuro * rateEuro;
            txtUSDEuro.Text = usdEuro.ToString("0.00");

            decimal totalUSD = usdAustralia + usdBhutan + usdCostaRica + usdEuro;
            txtTotalUSD.Text = totalUSD.ToString("0.00");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnResets_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtAmountBhutan.Text = "0.00";
            txtAmountCostaRica.Text = "0.00";
            txtAmountEuro.Text = "0.00";
        }
    }
}
