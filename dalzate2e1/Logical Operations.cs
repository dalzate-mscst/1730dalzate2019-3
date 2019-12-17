using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dalzate2e1
{
    public class Logical_Operations
    {
        public static bool Q01(decimal subtotal)
        {
            return subtotal >= 250 && subtotal < 500;
        }
        public static bool Q02(int timeinservice)
        {
            return timeinservice <= 4 || timeinservice >= 12;
        }
        public static bool Q03(bool isvalid, int years, int counter)
        {
            return isvalid == true && counter++ < years;
        }
        public static bool Q04(bool isvalid, int years, int counter)
        {
            return isvalid == true & counter++ < years;
        }
        public static bool Q05(bool isvalid, int years, int counter)
        {
            return isvalid == true || counter++ < years;
        }
        public static bool Q06(bool isvalid, int years, int counter)
        {
            return isvalid == true | counter++ < years;
        }
        public static bool Q07(DateTime startdate, DateTime expirationdate, DateTime date, bool isvalid)
        {
            return date > startdate && date < expirationdate || isvalid == true;
        }
        public static bool Q08(decimal thisYTP, decimal lastYTP, string emptype, int startyear, int currentyear)
        {
            return (thisYTP > lastYTP || emptype == "Part time") && startyear < currentyear;
        }
        public static bool Q09(int counter, int years)
        {
            return !(counter++ >= years);
        }
        public static bool Q10(int a, int b, int c, int d)
        {
            return a > b && b < c || c < d;
        }
        public static bool Q11(bool member, decimal price, float weight)
        {
            return member == true || price >= 25m || weight <= 1.0;
        }
        public static bool Q12(bool member, decimal price, float weight)
        {
            return member == true || price >= 25m && weight <= 1.0;
        }
        public static bool Q13(string shipstate, string itemtype)
        {
            return shipstate == "MN" && itemtype == "Electronics";
        }
    }
}
