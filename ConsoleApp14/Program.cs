using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b = 1;
            Console.Write("Zadejte cislo: ");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
                b = b * i;
            Console.WriteLine("Faktorial je {0}", b);
            Console.ReadLine();
        }
    }
}
