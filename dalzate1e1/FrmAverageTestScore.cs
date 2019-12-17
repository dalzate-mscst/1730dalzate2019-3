using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dalzate1e1
{
    public partial class FrmAverageTestScore : Form
    {
        public FrmAverageTestScore()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            txtAverage.Text = (
               Convert.ToDecimal(txtTest1.Text) + Convert.ToDecimal(txtTest3.Text) + Convert.ToDecimal(txtTest2.Text)
                ).ToString("0.00");
            txtAverage.Text = (
            Convert.ToDecimal(txtAverage.Text) /3m).ToString("0.00");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtAverage.Text = ("");
            txtTest1.Text = ("0");
            txtTest2.Text = ("0");
            txtTest3.Text = ("0");
        }
    }
}
