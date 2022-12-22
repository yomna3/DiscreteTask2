using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" Enter the Minimum number : ");
            int N1 = int.Parse(Console.ReadLine());
            Console.Write(" Enter the Maximum number : ");
            int N2 = int.Parse(Console.ReadLine());
            for (int x = N1; x <= N2; x++)
            {
                int sum = 0;
                for (int y = 1; y <= x/2; y++)
                {

                    if (x % y == 0)
                    {

                        sum += y;

                    }

                }
                if (sum == x)
                {

                    Console.WriteLine(x + " is prefect ");

                }
            }


        }
    }
}
