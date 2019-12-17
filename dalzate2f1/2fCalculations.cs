using System;

namespace dalzate2f1
{
    public class Calculations
    {
        public static string Calc01(string input)
        {
            // #01: if 
            decimal subtotal = 0.0m;
            decimal discountpercent = 0.0m;
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100m)
                discountpercent = 0.2m;
            return discountpercent.ToString("n2");
        }
        public static string Calc02(string input)
        {
            // #02: if {block}
            decimal discountpercent = 0m;
            decimal subtotal = 0.0m;
            subtotal = Decimal.Parse(input);
            string status = "Standard rate: ";
            if (subtotal >= 100m)
            {
                discountpercent = 0.2m;
                status = "Bulk rate: " + discountpercent.ToString("n2");
            }
            return status;
        }
        public static string Calc03(string input)
        {
            // #03: if else 
            decimal subtotal = 0m;
            decimal discountpercent = 0m;
            subtotal = Decimal.Parse(input);
            discountpercent = 0m;
            if (subtotal >= 100m)
                discountpercent = 0.2m;
            else discountpercent = 0.1m;
            return discountpercent.ToString("n2");
        }
        public static string Calc04(string input)
        {
            // #04: if else if
            decimal subtotal = 0.0m;
            decimal discountpercent = 0.0m;
            subtotal = Decimal.Parse(input);
            discountpercent = 0m;
            if (subtotal >= 100m && subtotal < 200m)
                discountpercent = 0.2m;
            else if (subtotal >= 200m && subtotal < 300m)
                discountpercent = 0.3m;
            else if (subtotal >= 300m)
                discountpercent = 0.4m;
            else discountpercent = 0.1m;
            return discountpercent.ToString("n2");
        }
        public static string Calc05(string input)
        {
            // #05: Better range tests
            decimal subtotal = 0.0m;
            decimal discountpercent = 0.0m;
            subtotal = Decimal.Parse(input);
            discountpercent = 0m;
            if (subtotal >= 300)
                discountpercent = 0.4m;
            else if (subtotal >= 200m)
                discountpercent = 0.3m;
            else if (subtotal >= 100m)
                discountpercent = 0.2m;
            else discountpercent = 0.1m;
            return discountpercent.ToString("n2");
        }
        public static string Calc06(string inputA, string inputB)
        {
            // #06: Nested if else
            decimal discountpercent = 0m;
            decimal subtotal = 0m;
            subtotal = Decimal.Parse(inputA);
            string customerType = inputB;
            discountpercent = 0m;
            if (customerType == "R")
            {
                if (subtotal >= 100m)
                    discountpercent = 0.2m;
                else discountpercent = 0.1m;
            }
            else            // CustomerType isn't "R"
                discountpercent = 0.4m;
            return discountpercent.ToString("n2");
        }
        public static string Calc07(string input)
        {
            decimal ethereum = 0m;
            if (input != "")
            {
                decimal dollars = Decimal.Parse(input);
                ethereum = 200m * dollars;
                return ethereum.ToString("n2");
            }
            return "Invalid input";
        }
        public static string Calc08(string inputA, string inputB)
        {
            decimal total = 0m;
            if (inputA != "" && inputB != "")
            {
                decimal price = Decimal.Parse(inputA);
                decimal quantity = Decimal.Parse(inputB);
                total = quantity * price;
                if (price >= 50)
                    total = quantity * price + 2;
                return total.ToString("n2");
            }
            return "Invalid input";
        }
        public static string Calc09(string inputA, string inputB)
        {
            decimal kWh = 0m;
            if (inputB !="" && inputA !="")
            {
                decimal Difference = Decimal.Parse(inputA);
                decimal rate = Decimal.Parse(inputB);
                kWh = rate - Difference / 10;
                return kWh.ToString("n2");
            }
            return "Invalid input";
        }
        public static string Calc10(string inputA, string inputB)
        {
            double result = 0.0;
            if (inputA !="" && inputB != "")
            {
                double A = Convert.ToDouble(inputA);
                double B = Convert.ToDouble(inputB);
                result = B / A;
                return result.ToString("n2");
            }
            return "Invalid input";
        }
    }
}
