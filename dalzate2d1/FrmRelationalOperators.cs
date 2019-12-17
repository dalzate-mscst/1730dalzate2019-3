using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dalzate2d1
{
    public partial class FrmRelationalOperators : Form
    {
        public FrmRelationalOperators()
        {
            InitializeComponent();
        }

        private void FrmRelationalOperators_Load(object sender, EventArgs e)
        {

        }

        private void BtnSetFailValues_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "xyz";
            textBox2Input.Text = "xyz";
            textBox3Input.Text = "3.4";
            textBox4Input.Text = "true";
            textBox5InputA.Text = "8";
            textBox5InputB.Text = "5";
            textBox6Input.Text = "Jones";
            textBox7Input.Text = "0";
            textBox8InputA.Text = "9";
            textBox8InputB.Text = "6";
            textBox9Input.Text = "499";
            textBox10InputA.Text = "21";
            textBox10InputB.Text = "420";
        }

        private void BtnSetPassValues_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "Frank";
            textBox2Input.Text = "";
            textBox3Input.Text = "2.3";
            textBox4Input.Text = "false";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "2";
            textBox6Input.Text = "xyz";
            textBox7Input.Text = "1";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "2";
            textBox9Input.Text = "500";
            textBox10InputA.Text = "2";
            textBox10InputB.Text = "3";
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            textBox1ResultA.Text = "fail";
            textBox2ResultA.Text = "fail";
            textBox3ResultA.Text = "fail";
            textBox4ResultA.Text = "fail";
            textBox5ResultA.Text = "fail";
            textBox6ResultA.Text = "fail";
            textBox7ResultA.Text = "fail";
            textBox8ResultA.Text = "fail";
            textBox9ResultA.Text = "fail";
            textBox10ResultA.Text = "fail";

            textBox1ResultB.Text = "success";
            textBox2ResultB.Text = "success";
            textBox3ResultB.Text = "success";
            textBox4ResultB.Text = "success";
            textBox5ResultB.Text = "success";
            textBox6ResultB.Text = "success";
            textBox7ResultB.Text = "success";
            textBox8ResultB.Text = "success";
            textBox9ResultB.Text = "success";
            textBox10ResultB.Text = "success";

            if (textBox1Input.Text == "Frank")
                textBox1ResultA.Text = "success";
            if (textBox2Input.Text == "")
                textBox2ResultA.Text = "success";
            decimal val3 = Convert.ToDecimal(textBox3Input.Text);
            if (val3 == 2.3m)
                textBox3ResultA.Text = "success";
            bool val4 = Convert.ToBoolean(textBox4Input.Text);
            if (val4 == false)
                textBox4ResultA.Text = "success";
            decimal val5A = Convert.ToDecimal(textBox5InputA.Text);
            decimal val5B = Convert.ToDecimal(textBox5InputB.Text);
            if (val5A == 2m) 
                textBox5ResultA.Text = "success";
            if (val5B == 2m)
                textBox5ResultA.Text = "success";
            if (textBox6Input.Text == "xyz")
                textBox6ResultA.Text = "success";
            decimal val7 = Convert.ToDecimal(textBox7Input.Text);
            if (val7 == 1m)
                textBox7ResultA.Text = "success";
            decimal val8A = Convert.ToDecimal(textBox8InputA.Text);
            decimal val8B = Convert.ToDecimal(textBox8InputB.Text);
            if (val8A == 1m) 
                textBox8ResultA.Text = "success";
            if (val8B == 2m)
                textBox8ResultA.Text = "success";
            decimal val9 = Convert.ToDecimal(textBox9Input.Text);
            if (val9 == 500m)
                textBox9ResultA.Text = "success";
            decimal val10A = Convert.ToDecimal(textBox10InputA.Text);
            decimal val10B = Convert.ToDecimal(textBox10InputB.Text);
            if (val10A == 2m) 
                textBox10ResultA.Text = "success";
            if (val10B == 3m)
                textBox10ResultA.Text = "success";

            if (textBox1Input.Text != "Frank")
                textBox1ResultB.Text = "fail";
            if (textBox2Input.Text != "")
                textBox2ResultB.Text = "fail";
            if (val3 != 2.3m)
                textBox3ResultB.Text = "fail";
            if (val4 != false)
                textBox4ResultB.Text = "Fail";
            if (val5A != 2m)
                textBox5ResultB.Text = "fail";
            if (val5B != 2m)
                textBox5ResultB.Text = "fail";
            if (textBox6Input.Text != "xyz")
                textBox6ResultB.Text = "fail";
            if (val7 != 1m)
                textBox7ResultB.Text = "fail";
            if (val8A != 1m)
                textBox8ResultB.Text = "fail";
            if (val8B != 2m)
                textBox8ResultB.Text = "fail";
            if (val9 != 500m)
                textBox9ResultB.Text = "fail";
            if (val10A != 2m)
               textBox10ResultB.Text = "fail";
            if (val10B != 3m)
                textBox10ResultB.Text = "fail";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
