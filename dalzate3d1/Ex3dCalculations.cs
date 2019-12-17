using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dalzate3d1
{
    public class Ex3dCalculations
    {
        public static string ArrayToString(int[] values)
        {
            //Create StringBuilder object: sbResult
            //loop
            //     convert current value to string, append to sbResult
            //     append ", " to sbResult
            // convert sbResult to string: result
            // remove last ", " from result
            // return result
            StringBuilder sbResult = new StringBuilder(200);
            foreach (int value in values)
            {
                sbResult.Append(value.ToString());
                sbResult.Append(", ");
            }
            string result = sbResult.ToString();
            return result.Remove(result.LastIndexOf(','));
        }

        public static int ValueCount(int[] values, int searchValue)
        {
            // create counter variable
            // loop
            //     increment counter if current value equals searchValue
            // return counter
            int count = 0;
            foreach (int value in values)
            {
                if (value == searchValue)
                {
                    count = count + searchValue;
                }
            }
            return count;
        }

        public static int RangeCount(int[] values, int searchMin, int searchMax)
        {
            // create counter variable
            // loop
            //     increment counter if current value between min and max (inclusive)
            // return counter
            int count = 0;
            foreach (int value in values)
            {
                if (searchMin > searchMax)
                {
                    count = count + value;
                }
                return count;
            }
        }
    }
}
