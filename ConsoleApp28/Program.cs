using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            SetridSestupne(ref a, ref b);
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.ReadLine();
        }

        static void SetridSestupne(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
