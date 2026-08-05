using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Sol
{
    internal class Palindrome_Num
    {
        

class PalindromeNumber
    {
        static void Main()
        {
            int num, originalNum, remainder, reverse = 0;

            // Input
            Console.Write("Enter a Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            originalNum = num;

            // Reverse the number
            while (num > 0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num = num / 10;
            }

            // Check palindrome
            if (originalNum == reverse)
            {
                Console.WriteLine(originalNum + " is a Palindrome Number.");
            }
            else
            {
                Console.WriteLine(originalNum + " is Not a Palindrome Number.");
            }
        }
    }
}
}
