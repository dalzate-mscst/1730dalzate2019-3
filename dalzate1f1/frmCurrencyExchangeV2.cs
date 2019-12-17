using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dalzate1f1
{
    public partial class FrmCurrencyExchangeV2 : Form
    {
        public FrmCurrencyExchangeV2()
        {
            InitializeComponent();
        }

        private void FrmCurrencyExchangeV2_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = ("0.684890");
            lblCurrency.Text = btnAustralia.Text + ":";
            txtUSDollars.Text = ("0.00");
            txtTotalUSD.Text = ("0.00");
            txtCurrency.Focus();
        }

        private void BtnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = ("0.684890");
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtUSDollars.Text = ("0.00");
            txtCurrency.Focus();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            btnCostaRica.BackgroundImage = picCostaRica.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = ("0.00175937");
            lblCurrency.Text = btnCostaRica.Text + ": ";
            txtUSDollars.Text = ("0.00");
            txtCurrency.Focus();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            btnEuro.BackgroundImage = picEuro.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            txtRate.Text = ("1.10464");
            lblCurrency.Text = btnEuro.Text + ": ";
            txtUSDollars.Text = ("0.00");
            txtCurrency.Focus();
        }

        private void BtnBhutan_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            txtRate.Text = ("0.0139607");
            lblCurrency.Text = btnBhutan.Text + ": ";
            txtUSDollars.Text = ("0.00");
            txtCurrency.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalcUSD(object sender, EventArgs e)
        {
            txtUSDollars.Text = (
                Convert.ToDecimal(txtCurrency.Text) * Convert.ToDecimal(txtRate.Text)
                ).ToString("0.00");
        }

        private void TxtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void TxtRate_Enter(object sender, EventArgs e)
        {
            txtRate.SelectAll();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDollars.Text) + Convert.ToDecimal(txtTotalUSD.Text)
                ).ToString("0.00");
            lblEquation.Text = lblEquation.Text + " + " + txtUSDollars.Text;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = ("0.684890");
            lblCurrency.Text = btnAustralia.Text + ":";
            txtUSDollars.Text = ("0.00");
            txtTotalUSD.Text = ("0.00");
            lblEquation.Text = ("");
        }
    }
}
