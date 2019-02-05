using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number for determining ");
            int no1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Second number for determining ");
            int no2 = int.Parse(Console.ReadLine());
            int gcf = GCF(no1, no2);
            Console.WriteLine("GCF for "+no1 +" and " + no2 + " is "+ gcf);
            Console.ReadLine();
        }

        static public int GCF(int a, int b)
        {
            int gcf =0;
            if (a > b)
            {
               int c = a % b;
                if(c==0)
                {
                    gcf = b;
                }
                else
                gcf = GCF(c, b);
            }
            else
            {
                int c = b % a;
                if (c == 0)
                {
                    gcf = a;
                }
                else
                gcf = GCF(a, c);
            }
            return gcf;
        }
    }
}
