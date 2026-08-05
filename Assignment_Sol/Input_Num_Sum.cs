using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Sol
{
    class Sum_Num
    {
        static void Main1()
        {
            // Declare variables
            int num1, num2;

            // Input
            Console.Write("Enter First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Display results
            Console.WriteLine("\n----- Arithmetic Operations -----");
            Console.WriteLine("Sum        = " + (num1 + num2));
            Console.WriteLine("Difference = " + (num1 - num2));
            Console.WriteLine("Product    = " + (num1 * num2));
            Console.WriteLine("Quotient   = " + (num1 / num2));
            Console.WriteLine("Remainder  = " + (num1 % num2));
        }
    }
}
