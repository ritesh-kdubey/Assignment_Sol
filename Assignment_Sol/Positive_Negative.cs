using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Sol
{
    internal class Positive_Negative
    {
       

class PositiveNegativeZero
    {
        static void Main1()
        {
            // Declare variable
            int num;

            // Input
            Console.Write("Enter a Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            // Check the number
            if (num > 0)
            {
                Console.WriteLine("The number is Positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine("The number is Negative.");
            }
            else
            {
                Console.WriteLine("The number is Zero.");
            }
        }
    }
}
}
