using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Sol
{
    internal class Even_Odd
    {
       

class EvenOddNumbers
    {
        static void Main1()
        {
            int n;

            // Input
            Console.Write("Enter the value of N: ");
            n = Convert.ToInt32(Console.ReadLine());

            // Print Even Numbers
            Console.WriteLine("\nEven Numbers:");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            // Print Odd Numbers
            Console.WriteLine("\n\nOdd Numbers:");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
}
