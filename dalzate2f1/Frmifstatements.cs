using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dalzate2f1
{
    public partial class Frmifstatements : Form
    {
        public Frmifstatements()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0.0m;
            decimal discountpercent = 0.0m;
            // #1: if
            result1TextBox.Text = Calculations.Calc01(input1AtextBox.Text);

            // #2: if {block}
            result2TextBox.Text = Calculations.Calc02(input2AtextBox.Text);

            // #3: if else
            result3TextBox.Text = Calculations.Calc03(input3AtextBox.Text);

            // #4: if else if
            result4TextBox.Text = Calculations.Calc04(input4AtextBox.Text);

            // #5: Better range test
            result5TextBox.Text = Calculations.Calc05(input5AtextBox.Text);

            // #6: Nested if else
            result6TextBox.Text = Calculations.Calc06(input6AtextBox.Text, input6BtextBox.Text);

            // #7: Validate input: non-empty string
            result7TextBox.Text = Calculations.Calc07(input7AtextBox.Text);

            // #8: Validate input, calculate quantity * price, shipping
            result8TextBox.Text = Calculations.Calc08(input8AtextBox.Text, input8BtextBox.Text);

            // #9: Validate input, calculate difference * rate
            result9TextBox.Text = Calculations.Calc09(input9AtextBox.Text, input9BtextBox.Text);

            // #10: Validate input, divide large num by small
            result10TextBox.Text = Calculations.Calc10(input10AtextBox.Text, input10BtextBox.Text);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
