using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Sol
{
    internal class Student_Grade
    {
        

class StudentGrade
    {
        static void Main1()
        {
            int marks;

            // Input
            Console.Write("Enter Student Marks (0-100): ");
            marks = Convert.ToInt32(Console.ReadLine());

            // Check valid range
            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Invalid Marks! Please enter marks between 0 and 100.");
            }
            else if (marks >= 91)
            {
                Console.WriteLine("Grade: O");
            }
            else if (marks >= 81)
            {
                Console.WriteLine("Grade: A+");
            }
            else if (marks >= 71)
            {
                Console.WriteLine("Grade: A");
            }
            else if (marks >= 61)
            {
                Console.WriteLine("Grade: B+");
            }
            else if (marks >= 51)
            {
                Console.WriteLine("Grade: B");
            }
            else
            {
                Console.WriteLine("Grade: Fail");
            }
        }
    }
}
}
