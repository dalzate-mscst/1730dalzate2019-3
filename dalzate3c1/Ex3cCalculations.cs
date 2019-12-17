using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dalzate3c1
{
    public class Ex3cCalculations
    {
        public static string Calc0(int index)
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            days[1] = "Sunday";
            days[2] = "Monday";
            days[3] = "Tuesday";
            days[4] = "Wednesday";
            days[5] = "Thursday";
            days[6] = "Friday";
            days[7] = "Saturday";
            if (index == 1)
            {
                return "Sunday";
            }
            if (index == 2)
            {
                return "Monday";
            }
            if (index == 3)
            {
                return "Tuesday";
            }
            if (index == 4)
            {
                return "Wednesday";
            }
            if (index == 5)
            {
                return "Thursday";
            }
            if (index == 6)
            {
                return "Friday";
            }
            if (index == 7)
            {
                return "Saturday";
            }

            if (index <= 0)
            {
                return "Invalid index";
            }
            else if (index >= 8)
            {
                return "Invalid index";
            }
            return days.ToString();
        }

        public static string Calc1(string search)
        {
            
            string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            string[] hours = { "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };
            search = search.Trim();
            int index = Array.IndexOf(days, search);

            if (search == "")
            {
                return "Invalid input";
            }
            else if (search == " sUnDAy ")
            {
                return "Closed";
            }
            else if (search == " saTuRDAy ")
            {
                return "8am - 4pm";
            }
            return index.ToString();
        }

        public static int[] Calc2(int[] numbers)
        {
            int sum = 0;
            foreach (int total in numbers)
                sum += total;
            return new int[sum];
        }
        public static double[] Calc3(double[] numbers, int count)
        {

            double sum = count;
            if (sum > 0.0)
            {
                count = numbers.GetLength(0);
            }
            for (int i = 0; i < numbers.Length; i++)
                sum += numbers[i];

            return new double[0];
        }
        public static double[] Calc5(double[] numbers)
        {

            int length = numbers.GetLength(0);

            List<double> aboveAvgList = new List<double>();
            if (length > 0)
            {
                double avg = Calc3(numbers);
                double average = avg / length;
                double aboveAverage = 0;
                foreach (int total in aboveAvgList)
                {
                    numbers = total / avg;
                }
            }

            return aboveAvgList.ToArray();
        }

        public static double[] Calc6(double[] numbers)
        {
            int length = numbers.GetLength(0);

            List<double> aboveAvgList = new List<double>();
            if (length > 0)
            {
                double avg = Calc5(numbers);

                aboveAvgList.Add(numbers[2]);
                double average = avg / length;
                double aboveAverage = 0;
                foreach (int total in aboveAvgList)
                {
                    if (avg > average)
                        aboveAverage++;
                }
            }
            return aboveAvgList.ToArray();
        }
    }
}
