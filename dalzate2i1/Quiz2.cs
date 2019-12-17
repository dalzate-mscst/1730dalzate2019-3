using System;
using System.Windows.Forms;

namespace dalzate2i1
{
    public partial class Quiz2 : Form
    {
        private int i1 = 0, i2 = 0, i3 = 0;

        public Quiz2()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            resultTextBox1a.Text = "" .ToString();
            resultTextBox1b.Text = "" .ToString();
            resultTextBox1c.Text = "" .ToString();
            resultTextBox1d.Text = "" .ToString();
            resultTextBox1e.Text = "" .ToString();
            resultTextBox1f.Text = "" .ToString();
            resultTextBox1g.Text = "" .ToString();
            resultTextBox1h.Text = "" .ToString();
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calculate1_Click(object sender, EventArgs e)
        {
            float float1 = Convert.ToSingle(inputTextBox1.Text);
            resultTextBox1a.Text = float1.ToString();
            resultTextBox1b.Text = float1.ToString("c");
            resultTextBox1c.Text = float1.ToString("n3");
            resultTextBox1d.Text = float1.ToString("p4");
            resultTextBox1e.Text = float1.ToString("0.00");
            resultTextBox1f.Text = float1.ToString("f5");
        }

        private void Calculate2_Click(object sender, EventArgs e)
        {
            short short1 = Convert.ToInt16(inputTextBox1.Text);
            int int1 = Convert.ToInt32(inputTextBox1.Text);
            float float1 = Convert.ToSingle(inputTextBox1.Text);
            long long1 = Convert.ToInt64(inputTextBox1.Text);
            double double1 = Convert.ToDouble(inputTextBox1.Text);

            resultTextBox1a.Text = (short1 + 0.03F).ToString();
            resultTextBox1b.Text = (int1 / 0.0003F).ToString("f0");
            resultTextBox1c.Text = (short1 + 3000).ToString();
            resultTextBox1d.Text = (short1 + int1).ToString();
            resultTextBox1e.Text = (int1 + 0.0003).ToString();
            resultTextBox1f.Text = (int1 / 100 == 30 || short1 + short1 > 50000).ToString();
            resultTextBox1g.Text = (float1 * 0.00001).ToString();
            resultTextBox1h.Text = (float1 - 0.00001F).ToString();
        }

        private void Calculate3_Click(object sender, EventArgs e)
        {
            int i = 3;
            i -= 1;
            i2 = i2 + 1;
            i3 += i1 + 2;

            resultTextBox1a.Text = i1.ToString();
            resultTextBox1b.Text = i2.ToString();
            resultTextBox1c.Text = i3.ToString();
        }

        private void Quiz2_Load(object sender, EventArgs e)
        {

        }

        private void Calculate6_Click(object sender, EventArgs e)
        {
            i1 = Int32.Parse(inputTextBox1.Text);
        }

        private void Quiz2_Load_1(object sender, EventArgs e)
        {

        }

        private void Calculate4_Click(object sender, EventArgs e)
        {
            i1 = Int32.Parse(inputTextBox1.Text);
        }

        private void Calculate5_Click(object sender, EventArgs e)
        {
            int input1 = Int32.Parse(inputTextBox1.Text);
            int input2 = Int32.Parse(inputTextBox2.Text);
            int input3 = Int32.Parse(inputTextBox3.Text);
            string input4 = inputTextBox4.Text;
            string input5 = inputTextBox5.Text;
            string result = "";

            result += input5.Substring(input1, 1) + " ";

            if (input1 > input2)
            {
                if (input4.Substring(1, 1) == "3")
                {
                    result += "D ";
                }
                else
                {
                    result += "E ";
                }
                result += "F ";

                if (input1 < 2)
                    result += "G ";
                else if (input1 < 4)
                    result += "H ";
                else if (input1 < 6)
                    result += "I ";

                result += "J ";
            }
            else
            {
                result += "K ";

                switch (input1)
                {
                    case 0:
                        result += "L ";
                        break;
                    case 1:
                        result += "M ";
                        break;
                    default:
                        result += "N ";
                        break;
                }
                if (input2 == 4 && input3 > 0)
                {
                    result += "O ";
                }
                else
                {
                    result += "P ";
                }
            }
            resultTextBox1a.Text = result;
        }
    }
}
