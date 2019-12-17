using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dalzate2g1
{
    public partial class Frmdalzateswitchifelse : Form
    {
        public Frmdalzateswitchifelse()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // #1a) Switch with no default
            result1atextbox.Text = Ex2gCalculations.Switch01(Input1atextbox.Text);

            // 1b) Seperate if statements
            result2atextbox.Text = Ex2gCalculations.If01(Input1atextbox.Text);

            // 1C) if elseif
            result3atextbox.Text = Ex2gCalculations.ElseIf01(Input1atextbox.Text);

            // 1D) nested if
            result4atexbox.Text = Ex2gCalculations.NestedIfElse01(Input1atextbox.Text);

            // 1E) Switch w/ default
            result5atextbox.Text = Ex2gCalculations.SwitchDefault01(Input1atextbox.Text);

            // 1F) Seperate if statements
            result6atextbox.Text = Ex2gCalculations.IfDefault01(Input1atextbox.Text);

            // 1G) if elseif
            result7atextbox.Text = Ex2gCalculations.ElseIfDefault01(Input1atextbox.Text);

            // 1H) nested if else
            result8atextbox.Text = Ex2gCalculations.NestedIfElseDefault01(Input1atextbox.Text);

            // 2A) Switch with no default
            result9atextbox.Text = Ex2gCalculations.Switch02(Input2atextbox.Text);
            // 2B) Seperate if statements
            result10atextbox.Text = Ex2gCalculations.If02(Input2atextbox.Text);
            // 2C) if else if
            result11atextbox.Text = Ex2gCalculations.ElseIf02(Input2atextbox.Text);
            // 2D Nested if else
            result12atextbox.Text = Ex2gCalculations.NestedIfElse02(Input2atextbox.Text);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
