using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Sol
{ 
}

class StudentDetails
{
    static void Main1()
    {
        // Declare variables
        string name;
        int rollNumber;
        float marks;

        // Input
        Console.Write("Enter Student Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Roll Number: ");
        rollNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Marks: ");
        marks = Convert.ToSingle(Console.ReadLine());

        // Display
        Console.WriteLine("\n----- Student Details -----");
        Console.WriteLine("Name        : " + name);
        Console.WriteLine("Roll Number : " + rollNumber);
        Console.WriteLine("Marks       : " + marks);
    }
}