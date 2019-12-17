using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dalzate3b1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, RoutedEventArgs e)
        {
            //0
            try
            {
            decimal subtotal = decimal.Parse(inputTextBox0a.Text);
            decimal discountPercent = Ex3bCalculations.GetDiscountPercent(subtotal);
            resultTextBox0.Text = discountPercent.ToString("f3");
            }
            catch { resultTextBox0.Text = ""; MessageBox.Show("Invalid input: " + this.inputTextBox0a.Text); }

            //2
            try
            {
                int months = Int32.Parse(this.inputTextBox2a.Text);
                decimal monthlyInvestment = Decimal.Parse(this.inputTextBox2b.Text);
                decimal monthlyInterestRate = Decimal.Parse(this.inputTextBox2c.Text);
                decimal futureValue = Ex3bCalculations.CalculateFutureValue(monthlyInvestment * 1.0m, monthlyInterestRate, months);
                resultTextBox2.Text = futureValue.ToString("c2");
            }
            catch {
                resultTextBox2.Text = "";
                MessageBox.Show("Invalid input: \n"
                + this.inputTextBox2a.Text + "\n"
                + this.inputTextBox2b.Text + "\n"
                + this.inputTextBox2c.Text + "\n"); }

            //4
            try
            {
                double fahrenheit = double.Parse(inputTextBox4a.Text);
                double celsius = Ex3bCalculations.FahrenheitToCelsius(fahrenheit);
                resultTextBox4.Text = celsius.ToString("f1");
            }
            catch { resultTextBox4.Text = ""; MessageBox.Show("Invalid input: " + this.inputTextBox4a.Text); }

            //6
            try
            {
                decimal hours = decimal.Parse(inputTextBox6a.Text);
                decimal rate = decimal.Parse(inputTextBox6b.Text);
                this.resultTextBox6.Text = Ex3bCalculations.GrossPay(hours, rate).ToString("f3");
            }
            catch
            {
                resultTextBox6.Text = "";
                MessageBox.Show("Invalid input: \n"
                + this.inputTextBox6a.Text + "\n"
                + this.inputTextBox6b.Text);
            }
        }
    }
}
