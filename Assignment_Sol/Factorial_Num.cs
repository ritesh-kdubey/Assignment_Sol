using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Sol
{
    internal class Factorial_Num
    {
       

class Factorial
    {
        static void Main1()
        {
            int num;
            long factorial = 1;

            // Input
            Console.Write("Enter a Positive Integer: ");
            num = Convert.ToInt32(Console.ReadLine());

            // Check for negative number
            if (num < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
            }
            else
            {
                // Calculate factorial
                for (int i = 1; i <= num; i++)
                {
                    factorial = factorial * i;
                }

                // Display result
                Console.WriteLine("Factorial of " + num + " = " + factorial);
            }
        }
    }
}
}
