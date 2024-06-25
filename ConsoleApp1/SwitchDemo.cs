using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SwitchDemo
    {
        static void Main()
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

            switch (ch)
            {
                case 1:
                    Console.WriteLine($"Sum of {num1} and {num2} is {num1 - num2}");
                    break;
                case 2:
                    Console.WriteLine($"Difference of {num1} and {num2} is {num1 * num2}");
                    break;
                case 3:
                    Console.WriteLine($"Product of {num1} and {num2} is {num1 * num2}");
                    break;
                case 4:
                    Console.WriteLine($"Remainder of {num1} and {num2} is {num1 % num2}");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            }
    }
}
