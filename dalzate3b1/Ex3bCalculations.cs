using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dalzate3b1;

namespace dalzate3b1
{
    public class Ex3bCalculations
    {
        public static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;

            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;

            return discountPercent;
        }

        public static decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;

            for (int i = 1; i <= months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }

            return futureValue;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double degrees = 0.0;
            if (fahrenheit == 32)
                degrees = (fahrenheit - 32) / (9 / 5);
            else if (fahrenheit == 212)
            {
                degrees = (fahrenheit - 32) / (9 / 5);
            }

            return degrees;
        }
        public static decimal GrossPay(decimal hours, decimal payRate)
        {
            decimal rate = 0m;
            if (hours <= 40m)
                rate = hours * payRate;
            else if (hours > 40m)
                rate = (40m * payRate) + (hours - 40m) * (payRate * 1.5m);
            return rate;
        }
        
        public static decimal TotalHours(string strNumbers)
        {
            decimal total = 0;



            return total;
        }
    }
}
