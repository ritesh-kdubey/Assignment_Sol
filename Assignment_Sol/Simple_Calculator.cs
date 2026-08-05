using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Sol
{
    internal class Simple_Calculator
    {
       

class SimpleCalculator
    {
        static void Main1()
        {
            double num1, num2;
            int choice;

            // Input numbers
            Console.Write("Enter First Number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Display menu
            Console.WriteLine("\nChoose an Operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Enter Your Choice (1-4): ");
            choice = Convert.ToInt32(Console.ReadLine());

            // Perform operation
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Result = " + (num1 + num2));
                    break;

                case 2:
                    Console.WriteLine("Result = " + (num1 - num2));
                    break;

                case 3:
                    Console.WriteLine("Result = " + (num1 * num2));
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        Console.WriteLine("Result = " + (num1 / num2));
                    }
                    else
                    {
                        Console.WriteLine("Error! Division by zero is not allowed.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }
    }
}
}
