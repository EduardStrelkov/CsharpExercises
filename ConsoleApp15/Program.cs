using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Zadej prvni cislo: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadej druhe cislo: ");
            b = Convert.ToInt32(Console.ReadLine());
            c = a * b;
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a = a % b;
                else
                    b = b % a;

            }
            if (a == 0)
                Console.WriteLine("Nejmensi spolecny nasobek je {0}", c / b);
            else
                Console.WriteLine("Nejmensi spolecny nasobek je {0}", c / a);
            Console.ReadLine();
        }
    }
}
