using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, x;

            Console.WriteLine("Napiste cislo :");
            n = Convert.ToDouble(Console.ReadLine());
            x = Vyraz(n);
            Console.WriteLine("Vyraz {0} = {1} ", n, x);
            Console.ReadLine();
        }

        static double Faktorial(int n)
        {
            double d = 1;
            int b = 1;
            for (int i = 1; i <= n; i++)
                d = d * i;
            return d;

        }
        static double Power(double n, int k)
        {
            double d = 1;
            for (int i = 1; i <= k; i++)
                d = d * n;
            return d;
        }
        static double Vyraz(double n)
        {
            double a = 0;
            for (int k = 0; k <= 100; k++)
                a = a + Power(n, k) / Faktorial(k);
            return a;
        }
    }
}
