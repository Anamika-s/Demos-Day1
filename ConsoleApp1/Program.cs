// #include <stdio.h>  printf scanf
// in java, we use packages
// in C# , we use namespace
using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int ch;
            // Take input from user
            Console.WriteLine("Enter value of num1");
            num1 = Convert.ToByte(Console.ReadLine());  // 2bytes
            Console.WriteLine("Enter Number 2");
            num2 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Enter your choice");
            ch = Convert.ToByte(Console.ReadLine());

            if (ch == 1)
                Console.WriteLine($"Sum of {num1} and {num2} is {num1 - num2}");
            else if (ch == 2)
                Console.WriteLine($"Difference of {num1} and {num2} is {num1 * num2}");
            else if (ch == 3)
                Console.WriteLine($"Product of {num1} and {num2} is {num1 * num2}");
            else if (ch == 4)
                Console.WriteLine($"Remainder of {num1} and {num2} is {num1 % num2}");
            else
                Console.WriteLine("Invalid choice");
        }
    }
}
