using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 14, b = 6, c = 23, max;
            if (a <= b)
            {
                if (c <= b)
                    max = b;
                else max = c;
            }
            else
            {
                if (c <= a)
                    max = a;
                else max = c;
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
