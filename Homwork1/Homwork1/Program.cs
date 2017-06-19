using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homwork1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Diane Watts
             * Homework 1
             * 06/14/2017
             */
            Console.WriteLine("Enter a Number");
            int InputNumber = Convert.ToInt32(Console.ReadLine());
            //Converting number to integer
            int Reverse = 0;
            while (InputNumber > 0)
            {
                //Reversing the numbers through math until the number is no longer greater than zero
                int Remainder = InputNumber % 10; 
                Reverse = Remainder + (Reverse * 10); 
                InputNumber = InputNumber / 10; 

            }
            Console.WriteLine("Reverse Number = {0}", Reverse);
            //End of Code
        }
    }
}
