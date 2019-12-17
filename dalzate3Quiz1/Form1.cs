using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dalzate3Quiz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y, z;
            x = 10;
            y = 28;
            z = 4;
            resultTextBox.Text = "";

            for (int i = x; i <= y; i += z)
            {
                resultTextBox.Text += i.ToString() + " /r/n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x, y, z;
            y = 28;
            z = 5;
            resultTextBox.Text = "";

            x = 10;
            while ( x < y)
            {
                resultTextBox.Text += x.ToString() + " /r/n";
                x = x + z;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] a = new int[6];
            int x, y, z;
            x = 2;
            y = 5;
            z = 0;
            resultTextBox.Text = "";

            a[0] = 6;
            a[1] = 2;
            a[2] = 9;
            a[3] = 7;
            a[4] = 3;
            a[5] = 8;

            for (int i = x; i <= y; i++)
            {
                resultTextBox.Text += a[i].ToString() + " /r/n";
                z = z + a[i];
            }
            resultTextBox.Text += "Total: " + z.ToString() + " /r/n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] a = { 6, 2, 9, 7, 3 };
            string[] strArray = { "AAA", "BBB", "CCC", "DDD", "EEE" };

            int x, y, z;
            x = 1;
            y = 4;
            z = 0;
            resultTextBox.Text = "";

            for (int i = x; i <= y; i++)
            {
                resultTextBox.Text += strArray[i] +
                    ": " + a[i].ToString() + " /r/n";
            }
            resultTextBox.Text += "Total: " + z.ToString() + " /r/n";
        }
        private void method5(int x, ref int y, ref int z)
        {
            y = x + y;
            z = 0;
            x = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = string.Empty;
            int a = 3;
            int b = 6;
            int c = 2;

            method5(b, ref c, ref a);

            resultTextBox.Text = a.ToString() + " /r/n";
            resultTextBox.Text += b.ToString() + " /r/n";
            resultTextBox.Text += c.ToString() + " /r/n";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string str = "Red Wing";
            resultTextBox.Text = String.Empty;
            for (int i = 2; i <= str.Length - 3; i++)
            {
                resultTextBox.Text += str.Substring(i, 2);
            }
        }
    }
}
