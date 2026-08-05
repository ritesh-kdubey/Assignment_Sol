using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Sol
{
    internal class Prime_Non_Prime
    {
       

class PrimeNumber
    {
        static void Main1()
        {
            int num;
            bool isPrime = true;

            // Input
            Console.Write("Enter a Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            // Check prime
            if (num <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            // Display result
            if (isPrime)
            {
                Console.WriteLine(num + " is a Prime Number.");
            }
            else
            {
                Console.WriteLine(num + " is Not a Prime Number.");
            }
        }
    }
}
}
