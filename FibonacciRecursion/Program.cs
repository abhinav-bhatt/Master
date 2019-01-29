using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number to Print First 'N' Fibonacci Series!!!");
            string n = Console.ReadLine();
            int no = int.Parse(n);
            //Console.WriteLine("Fibonacci series for " + no + " is :");
            for (int i = 1; i <= no; i++)
            {
                Console.Write(" " + Fibonacci(i));
            }

            Console.ReadLine();

        }

        public static int Fibonacci(int n)
        {
            if (n == 1 || n - 1 == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }

        }
    }
}
