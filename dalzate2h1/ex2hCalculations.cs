using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace dalzate2h1
{
    public class Ex2hCalculations
    {
        public static String DateCalc06(string strYear, string strmonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strmonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
            result = date.ToShortDateString();
            }
            catch { }

            return result;
        }
        public static String DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }
        public static String DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();
            return result;
        }
        public static String DateCalc09(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            try
            {
                DateTime dueDate = DateTime.Parse(strDateA);
                DateTime currentDate= DateTime.Parse(strDateB);
                TimeSpan timeTilldue = dueDate - currentDate;
                result = timeTilldue.ToString();
            }
            catch { }
            
            return result;
        }
        public static String DateCalc10(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                DateTime currentDate = DateTime.Parse(strDateA);
                DateTime dueDate = DateTime.Parse(strDateB);
                bool pastDue = false;
                if (currentDate > dueDate)
                    pastDue = true;
                else if (currentDate <= dueDate)
                    result = "On time";
                result = pastDue.ToString();
            }
            catch { }

            return result;
        }

        public static String StringCalc01(string s)
        {
            StringBuilder sb = new StringBuilder(100);
            return sb.ToString();
        }
        public static String StringCalc02(string s)
        {
            StringBuilder sb = new StringBuilder(100);
            return sb.ToString();
        }
            public static String StringCalc03(string s)
        {
            StringBuilder sb = new StringBuilder(100);
            return sb.ToString();
        }
        public static String StringCalc04(string s)
        {
            StringBuilder sb = new StringBuilder(100);
            return sb.ToString();
        }
        public static String StringCalc05(string s)
        {
            StringBuilder sb = new StringBuilder(100);
            return sb.ToString();
        }
        public static String StringCalc06(string s)
        {
            StringBuilder sb = new StringBuilder(100);
            return sb.ToString();
        }
        public static String StringCalc07(string s)
        {
            StringBuilder sb = new StringBuilder(100);
            return sb.ToString();
        }
        public static String StringCalc08(string s)
        {
            StringBuilder sb = new StringBuilder(100);
            return sb.ToString();
        }
        public static String StringCalc09(string s)
        {
            StringBuilder sb = new StringBuilder(100);
            return sb.ToString();
        }
        public static String StringCalc10(string s1, string s2, string s3)
        {
           StringBuilder sb = new StringBuilder(100);
            //int string1 = int.Parse(s1);
            //int string2 = int.Parse(s2);
            //int string3 = int.Parse(s3);
            //sb = StringBuilder.Append(string1, string2, string3);
            return sb.ToString();
        }
    }
}