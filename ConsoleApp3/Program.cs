using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, prostredni;
            a = 123;
            b = 123;
            c = 123;
            if (a <= b)
            {
                if (b <= c)
                    prostredni = b;
                else
                {
                    if (c <= a)
                        prostredni = a;
                    else
                        prostredni = c;
                }
            }
            else
            {
                if (a < c)
                    prostredni = a;
                else
                {
                    if (c >= b)
                        prostredni = c;
                    else
                        prostredni = b;
                }
            }
            Console.WriteLine("Hodnota prvni promenne je {0}, hodnota druhe promenne je {1}, hodnota treti promenne je {2}", a, b, c);
            Console.WriteLine("Prostredni  z hodnot {0}, {1} a {2} je {3}.", a, b, c, prostredni);
            Console.ReadLine();

        }
    }
}
