using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, x;
            Console.WriteLine("Napiste cenu: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadejte DPH: ");
            b = Convert.ToDouble(Console.ReadLine());
            x = SpoctiDPH1(a, b);
            Console.WriteLine("Cena zbozi s DPH: {0}", x);
            Console.ReadLine();
        }
        static double SpoctiDPH1(double a, double b)
        {
            return a + (b / 100) * a;
        }
    }
}
