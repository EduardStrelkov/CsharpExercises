using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 5;
            int c = 9;
            Console.WriteLine("Hodnota prvni promene je {0}, hodnota druhe promene je {1}, hodnota treti promene je {2}", a, b, c);
            Console.WriteLine("Vysledek vyrazu {0}", b * c - a);
            Console.ReadLine();
        }
    }
}
