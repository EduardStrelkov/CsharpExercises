using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Zadejte prvni cislo: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadejte druhe cislo: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
                Console.WriteLine("Setridena cisla jsou {0}, {1}", a, b);
            else
                Console.WriteLine("Setredena cisla jsou {0}, {1}", b, a);
            Console.ReadLine();
        }
    }
}
