using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime FirstDate, SecondDate;
            String NumDays;

            Console.Write("Enter First Date\n\n");
            FirstDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("\nEnter Second Date\n\n");
            SecondDate = Convert.ToDateTime(Console.ReadLine());

            //assumes second date is greater than first date
            if (FirstDate < SecondDate)
            {
                TimeSpan DayDifference = SecondDate - FirstDate;
                NumDays = DayDifference.TotalDays.ToString();
                Console.WriteLine("\nDays = {0} \n", NumDays);

                int NumMonths = ((SecondDate.Year - FirstDate.Year) * 12) + SecondDate.Month - FirstDate.Month;
                Console.WriteLine("Months = {0} \n", NumMonths);

                int NumYears = (SecondDate.Year - FirstDate.Year);
                Console.WriteLine("Years = {0} \n", NumYears);
            }

            else
            {
                TimeSpan DayDifference = FirstDate - SecondDate;
                NumDays = DayDifference.TotalDays.ToString();
                Console.WriteLine("\nDays = {0} \n", NumDays);

                int NumMonths = ((FirstDate.Year - SecondDate.Year) * 12) + FirstDate.Month - SecondDate.Month;
                Console.WriteLine("Months = {0} \n", NumMonths);

                int NumYears = (FirstDate.Year - SecondDate.Year);
                Console.WriteLine("Years = {0} \n", NumYears);


            }


        }
    }
}
