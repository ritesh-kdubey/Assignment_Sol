using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Sol
{
    internal class User_Input
    {
       

class MenuDrivenProgram
    {
        static void Main()
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Check Even/Odd");
                Console.WriteLine("2. Find Largest of Three Numbers");
                Console.WriteLine("3. Calculate Factorial");
                Console.WriteLine("4. Exit");

                Console.Write("Enter Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Check Even/Odd
                        Console.Write("Enter a Number: ");
                        int num = Convert.ToInt32(Console.ReadLine());

                        if (num % 2 == 0)
                            Console.WriteLine(num + " is Even.");
                        else
                            Console.WriteLine(num + " is Odd.");
                        break;

                    case 2:
                        // Find Largest of Three Numbers
                        Console.Write("Enter First Number: ");
                        int a = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Second Number: ");
                        int b = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Third Number: ");
                        int c = Convert.ToInt32(Console.ReadLine());

                        if (a >= b && a >= c)
                            Console.WriteLine("Largest Number = " + a);
                        else if (b >= a && b >= c)
                            Console.WriteLine("Largest Number = " + b);
                        else
                            Console.WriteLine("Largest Number = " + c);
                        break;

                    case 3:
                        // Calculate Factorial
                        Console.Write("Enter a Positive Integer: ");
                        int n = Convert.ToInt32(Console.ReadLine());

                        long fact = 1;

                        if (n < 0)
                        {
                            Console.WriteLine("Factorial is not defined for negative numbers.");
                        }
                        else
                        {
                            for (int i = 1; i <= n; i++)
                            {
                                fact = fact * i;
                            }

                            Console.WriteLine("Factorial = " + fact);
                        }
                        break;

                    case 4:
                        Console.WriteLine("Exiting Program...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice! Please try again.");
                        break;
                }

            } while (choice != 4);
        }
    }
}
}
