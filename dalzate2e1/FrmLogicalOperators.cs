using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dalzate2e1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            result01TextBox.Text = "";
            result02TextBox.Text = "";
            result03TextBox.Text = "";
            result03bTextBox.Text = "";
            result04TextBox.Text = "";
            result04bTextBox.Text = "";
            result05TextBox.Text = "";
            result05bTextBox.Text = "";
            result06TextBox.Text = "";
            result06bTextBox.Text = "";
            result07TextBox.Text = "";
            result08TextBox.Text = "";
            result09TextBox.Text = "";
            result09bTextBox.Text = "";
            result10textBox.Text = "";

            // #01
            decimal subtotal = Convert.ToDecimal(input01aTextBox.Text);
            //result01TextBox.Text = (subtotal >= 250 && subtotal < 500).ToString();
            result01TextBox.Text = (Logical_Operations.Q01(subtotal)).ToString();

            // #02
            int timeinservice = Convert.ToInt32(input02aTextBox.Text);
            //result02TextBox.Text = (timeinservice <= 4 || timeinservice >= 12).ToString();
            result02TextBox.Text = (Logical_Operations.Q02(timeinservice)).ToString();

            // #03 - 06 initialization
            bool isvalid = Convert.ToBoolean(input03aTextBox.Text);
            int years = Convert.ToInt32(input03cTextBox.Text);

            // #03
            int counter = Convert.ToInt32(input03bTextBox.Text);
            //result03TextBox.Text = (isvalid == true && counter++ < years).ToString();
            result03TextBox.Text = (Logical_Operations.Q03(isvalid, years, counter)).ToString();
            result03bTextBox.Text = counter.ToString();

            // #04
            counter = Convert.ToInt32(input03bTextBox.Text);
            //result04TextBox.Text = (isvalid == true & counter++ < years).ToString();
            result04TextBox.Text = (Logical_Operations.Q04(isvalid, years, counter)).ToString();
            result04bTextBox.Text = counter.ToString();

            // #05
            counter = Convert.ToInt32(input03bTextBox.Text);
            //result05TextBox.Text = (isvalid == true || counter++ < years).ToString();
            result05TextBox.Text = (Logical_Operations.Q05(isvalid, years, counter)).ToString();
            result05bTextBox.Text = counter.ToString();

            // #06
            counter = Convert.ToInt32(input03bTextBox.Text);
            //result06TextBox.Text = (isvalid == true | counter++ < years).ToString();
            result06TextBox.Text = (Logical_Operations.Q06(isvalid, years, counter)).ToString();
            result06bTextBox.Text = counter.ToString();

            // #07
            DateTime startdate = Convert.ToDateTime(input07aTextBox.Text);
            DateTime expirationdate = Convert.ToDateTime(input07bTextBox.Text);
            DateTime date = Convert.ToDateTime(input07cTextBox.Text);
            isvalid = Convert.ToBoolean(input07dTextBox.Text);
            //result07TextBox.Text = (date > startdate && date < expirationdate || isvalid == true).ToString();
            result07TextBox.Text = (Logical_Operations.Q07(startdate, expirationdate, date, isvalid)).ToString();

            // #08
            decimal thisYTP = Convert.ToDecimal(input08aTextBox.Text);
            decimal lastYTP = Convert.ToDecimal(input08bTextBox.Text);
            string emptype = input08cTextBox.Text;
            int startyear = Convert.ToInt32(input08dTextBox.Text);
            int currentyear = Convert.ToInt32(input08eTextBox.Text);
            //result08TextBox.Text = ((thisYTP > lastYTP || emptype == "Part time") && startyear < currentyear).ToString();
            result08TextBox.Text = (Logical_Operations.Q08(thisYTP, lastYTP, emptype, startyear, currentyear)).ToString();

            // #09
            counter = Convert.ToInt32(input09aTextBox.Text);
            years = Convert.ToInt32(input09bTextBox.Text);
            //result09TextBox.Text = (!(counter++ >= years)).ToString();
            result09TextBox.Text = (Logical_Operations.Q09(counter, years)).ToString();
            result09bTextBox.Text = counter.ToString();

            // #10
            int a = Convert.ToInt32(input10atextBox.Text);
            int b = Convert.ToInt32(input10btextBox.Text);
            int c = Convert.ToInt32(input10ctextBox.Text);
            int d = Convert.ToInt32(input10dtextBox.Text);
            //result10textBox.Text = (a > b && b < c || c < d).ToString();
            result10textBox.Text = (Logical_Operations.Q10(a, b, c, d)).ToString();

            //bool v = a > b;
            //bool w = b < c;
            //bool x = c < d;
            //bool y = v && w;
            //bool z = y || x;
            //result10textbox.Text = z.ToString();

            // #11
            bool member = Convert.ToBoolean(input11atextBox.Text);
            decimal price = Convert.ToDecimal(input11btextBox.Text);
            float weight = Convert.ToSingle(input11ctextBox.Text);
            result11textBox.Text = (Logical_Operations.Q11(member, price, weight)).ToString();
            // #12
            member = Convert.ToBoolean(input12atextBox.Text);
            price = Convert.ToDecimal(input12btextBox.Text);
            weight = Convert.ToSingle(input12ctextBox.Text);
            result12textBox.Text = (Logical_Operations.Q12(member, price, weight)).ToString();
            // #13
            string shipstate = input13atextBox.Text;
            string itemtype = input13btextBox.Text;
            result13textBox.Text = (Logical_Operations.Q13(shipstate, itemtype)).ToString();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
