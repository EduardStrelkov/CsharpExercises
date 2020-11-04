using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12, b = 30, c = 15;
            Console.WriteLine("Hodnota prvni promenne je {0}, hodnota druhe promenne je {1}, hodnota treti promenne je {2}.", a, b, c);
            if (a % b == 0)
            {
                Console.WriteLine("Ze zadanych cisel {0}, {1} a {2} je cislo {3} delitelem cisla {4}.", a, b, c, b, a);
                goto end;
            }
            if (b % a == 0)
            {
                Console.WriteLine("Ze zadanych cisel {0}, {1} a {2} je cislo {3} delitelem cisla {4}.", a, b, c, a, b);
                goto end;
            }
            if (a % c == 0)
            {
                Console.WriteLine("Ze zadanych cisel {0}, {1} a {2} je cislo {3} delitelem cisla {4}.", a, b, c, c, a);
                goto end;
            }
            if (c % a == 0)
            {
                Console.WriteLine("Ze zadanych cisel {0}, {1} a {2} je cislo {3} delitelem cisla {4}.", a, b, c, a, c);
                goto end;
            }
            if (b % c == 0)
            {
                Console.WriteLine("Ze zadanych cisel {0}, {1} a {2} je cislo {3} delitelem cisla {4}.", a, b, c, c, b);
                goto end;
            }
            if (c % b == 0)
            {
                Console.WriteLine("Ze zadanych cisel {0}, {1} a {2} je cislo {3} delitelem cisla {4}.", a, b, c, b, c);
                goto end;
            }
            goto end1;
        end:
            Console.ReadLine();
        end1:
            Console.WriteLine("Ze zadanych cisel {0}, {1} a {2} neni zadne cislo delitelem jineho cisla.", a, b, c);
            Console.ReadLine();
        }
    }
}
