using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dalzate2a1
{
    public partial class FrmInvoicecalcs : Form
    {
        public FrmInvoicecalcs()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //txtDiscountAmount.Text =
            //   (Convert.ToDecimal(txtSubtotal.Text)
            //   * Convert.ToDecimal(txtDiscountPercent.Text) / 100).ToString("0.00");
            decimal sub = Convert.ToDecimal(txtSubtotal.Text);
            decimal subtotal = sub * Convert.ToDecimal(txtDiscountPercent.Text) /100m;
            txtDiscountAmount.Text = subtotal.ToString("0.00");


            //txtTotal.Text =
            //    (Convert.ToDecimal(txtSubtotal.Text)
            //    - Convert.ToDecimal(txtDiscountAmount.Text)).ToString("0.00");
            decimal total = subtotal + sub;
            txtTotal.Text = total.ToString("0.00");
        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtDiscountAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtDiscountPercent_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
