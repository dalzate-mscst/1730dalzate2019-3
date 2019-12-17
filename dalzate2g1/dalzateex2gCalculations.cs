using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dalzate2g1
{
    public class Ex2gCalculations
    {
        public static string Switch01(string customertype)
        {
            // #1a) Switch with no default
            decimal discountpercent = -1m;

            switch (customertype)
            {
                case "R":
                    discountpercent = .1m;
                    break;
                case "C":
                    discountpercent = .2m;
                    break;
            }
            return discountpercent.ToString("0.0");
        }
        public static string If01(string customertype)
        {
            // 1b) Seperate if statements
            decimal discountpercent = -1m;
            if (customertype == "R")
                discountpercent = .1m;
            if (customertype == "C")
                discountpercent = .2m;

            return discountpercent.ToString("0.0");
        }
        public static String ElseIf01(string customertype)
        {
            // 1C) if elseif
            decimal discountpercent = -1m;
            if (customertype == "R")
                discountpercent = .1m;
            else if (customertype == "C")
                discountpercent = .2m;

            return discountpercent.ToString("0.0");
        }
        public static string NestedIfElse01(string customertype)
        {
            // 1D) nested if
            decimal discountpercent = -1m;
            if (customertype == "R")
            {
                discountpercent = .1m;
            }
            else
            {
                if (customertype == "C")
                {
                    discountpercent = .2m;
                }
            }

            return discountpercent.ToString("0.0");
        }
        public static string SwitchDefault01(string customertype)
        {
            // 1E) Switch w/ default
            decimal discountpercent = -1m;
            switch (customertype)
            {
                case "R":
                    discountpercent = .1m;
                    break;
                case "C":
                    discountpercent = .2m;
                    break;
                default:
                    discountpercent = 0m;
                    break;
            }
            return discountpercent.ToString("0.0");
        }
        public static string IfDefault01(string customertype)
        {
            // 1F) Seperate if statements
            decimal discountpercent = -1m;
            if (customertype == "R")
                discountpercent = .1m;
            if (customertype == "C")
                discountpercent = .2m;
            if (customertype != "R" && customertype != "C")
                discountpercent = 0m;

            return discountpercent.ToString("0.0");
        }
        public static String ElseIfDefault01(string customertype)
        {
            // 1G) if elseif
            decimal discountpercent = -1m;
            if (customertype == "R")
                discountpercent = .1m;
            else if (customertype == "C")
                discountpercent = .2m;
            else discountpercent = 0m;

            return discountpercent.ToString("0.0");
        }
        public static string NestedIfElseDefault01(string customertype)
        {
            // 1H) nested if else
            decimal discountpercent = -1m;
            if (customertype == "R")
            {
                discountpercent = .1m;
            }
            else
            {
                if (customertype == "C")
                {
                    discountpercent = .2m;
                }
                else
                {
                    discountpercent = 0m;
                }
            }

            return discountpercent.ToString("0.0");
        }
        public static string Switch02(string customertype)
        {
            // 2A) Switch with no default
            decimal discountpercent = -1m;
            switch (customertype)
            {
                case "R":
                case "C":
                    discountpercent = .2m;
                    break;
                case "T":
                    discountpercent = .4m;
                    break;
            }
            return discountpercent.ToString("0.0");
        }
        public static string If02(string customertype)
        {
            // 2B) Seperate if statements
            decimal discountpercent = -1m;
            if (customertype == "R")
                discountpercent = .2m;
            if (customertype == "C")
                discountpercent = .2m;
            if (customertype == "T")
                discountpercent = .4m;

            return discountpercent.ToString("0.0");
        }
        public static string ElseIf02(string customertype)
        {
            // 2C) if else if
            decimal discountpercent = -1m;
            if (customertype == "R")
                discountpercent = .2m;
            else if (customertype == "C")
                discountpercent = .2m;
            else if (customertype == "T")
                  discountpercent = .4m;

            return discountpercent.ToString("0.0");
        }
        public static string NestedIfElse02(string customertype)
        {
            // 2D Nested if else
            decimal discountpercent = -1m;
            if (customertype == "R")
            {
                discountpercent = .2m;
            }
            else
            {
                if (customertype == "C")
                {
                    discountpercent = .2m;
                }
                if (customertype == "T")
                {
                    discountpercent = .4m;
                }
            }

            return discountpercent.ToString("0.0");
        }
    }
}
