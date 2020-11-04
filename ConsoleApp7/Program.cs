using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 7, c = 5;
            Console.WriteLine("Hodnota prvni promenne je {0}, hodnota druhe promenne je {1} hodnota treti promenne je {2}.", a, b, c);
            if (a + b == c)
            {
                Console.WriteLine("Ze zadanych cisel {0}, {1} a {2} je cislo {3} souctem cisel {4} a {5}.", a, b, c, c, a, b);
                goto end;
            }
            if (a + c == b)
            {
                Console.WriteLine("Ze zadanych cisel {0}, {1} a {2} je cislo {3} souctem cisel {4} a {5}.", a, b, c, b, a, c);
                goto end;
            }
            if (b + c == a)
            {
                Console.WriteLine("Ze zadanych cisel {0}, {1} a {2} je cislo {3} souctem cisel {4} a {5}.", a, b, c, a, b, c);
                goto end;
            }
            goto end1;
        end:
            Console.ReadLine();
        end1:
            Console.WriteLine("Ze zadanych cisel {0}, {1} a {2} zda zadne dve cisla netvori soucet tretiho cisla", a, b, c);
            Console.ReadLine();
        }
    }
}
