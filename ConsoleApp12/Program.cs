using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Zadejte prvni cislo: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadejte druhe cislo: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadejte treti cislo: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (b > c)
                    Console.WriteLine("Setridena cisla jsou {0}, {1}, {2}", c, b, a);
                else
                {
                    if (a < c)
                        Console.WriteLine("Setridena cisla jsou {0}, {1}, {2}", b, a, c);
                    else
                        Console.WriteLine("Setridena cisla jsou {0}, {1}, {2}", b, c, a);
                }
            }
            else
            {
                if (b > c)

                {
                    if (a > c)
                        Console.WriteLine("Setridena cisla jsou {0}, {1}, {2}", c, a, b);
                    else
                        Console.WriteLine("Setridena cisla jsou {0}, {1}, {2}", a, c, b);
                }
                else
                    Console.WriteLine("Setridena cisla jsou {0}, {1}, {2}", a, b, c);
            }
            Console.ReadLine();
        }
    }
}
