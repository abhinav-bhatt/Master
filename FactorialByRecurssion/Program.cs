using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialByRecurssion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the integer whose factorial to find!!!");
            string input = Console.ReadLine();
            uint a = uint.Parse(input);
            ulong factorial = Fact(a);
            if (factorial == 0)
            {
                Console.WriteLine("factorial of " + a + " is out of memory limit");
            }
            else
            {
                Console.WriteLine("factorial of " + a + " is " + +factorial);
            }
            Console.ReadLine();
        }

        static public ulong Fact(uint a)
        {
            ulong fc;
            if (a == 1)
                return 1;
            else
                fc = a * Fact(a - 1);
            return fc;
        }
    }
}
