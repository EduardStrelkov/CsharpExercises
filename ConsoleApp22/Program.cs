using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            double n, x;
            Console.WriteLine("Napiste stupen :");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Napiste cislo :");
            n = Convert.ToDouble(Console.ReadLine());
            x = Power(n, k);
            Console.WriteLine("{0} ve stupeni {1} = {2} ", n, k, x);
            Console.ReadLine();
        }
        static double Power(double n, int k)
        {
            double d = 1;
            for (int i = 1; i <= k; i++)
                d = d * n;
            return d;
        }
    }
}
