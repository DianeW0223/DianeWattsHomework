using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)

        {
            float Length, Width, Area, Perimeter;
            string Input = "0";

            do
            {
                Console.WriteLine("Enter The Length");
                Length = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter The Width");
                Width = float.Parse(Console.ReadLine());

                Area = (Length * Width);
                Console.WriteLine("Area is {0}", Area);
                Perimeter = (Length * 2) + (Width * 2);
                Console.WriteLine("Perimeter is {0}", Perimeter);

                Console.WriteLine("Do you want to continue? y/n");
                Input = Console.ReadLine();

            } while (Input == "y");


                
         }

    }
}
