using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopsdemo
{
    internal class SumOfNumbers
    {
        static void Main()
        {
            int sum = 0;
            int num;
            //for(int i = 0;i<=10;i++)
            //{
            //    num = sbyte.Parse(Console.ReadLine());
            //    sum += num;
            //}
            // Take sum of positive numbers and quit once u get 0
            for (int i = 0; i <= 10; i++)
            {
                num = sbyte.Parse(Console.ReadLine());
                if (num < 0) continue;
                if (num == 0) break;
                sum += num;
            }

            float average = (float)sum / 10;
            Console.WriteLine($"Sum is {sum} Average is {average}");
        }
    }
}
