using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        public struct complex
        {
            public double re;
            public double im;
        }

        static void Main(string[] args)
        {
            complex x;
            x.re = 5.2;
            x.im = 3.25;
            complex y;
            y.re = 1.6;
            y.im = -4;
            complex a = vynasob(x, y);
            if (a.im < 0)
                Console.WriteLine("{0}-{1}i", a.re, Math.Abs(a.im));
            else
                Console.WriteLine("{0}+{1}i", a.re, a.im);
            Console.ReadLine();
        }
        static complex vynasob(complex x, complex y)
        {
            complex a;
            a.re = x.re * y.re - x.im * y.im;
            a.im = x.re * y.im + x.im * y.re;
            return a;
        }
    }
}