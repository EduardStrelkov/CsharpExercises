using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            int n;
            double x;
            Console.Write("Napiste cislo k: ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Napiste cislo n: ");
            n = Convert.ToInt32(Console.ReadLine());
            x = Kombinace(n, k);
            Console.WriteLine("Kombinace {0} a {1} = {2} ", n, k, x);
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
        static double Kombinace(int n, int k)
        {
            double d;
            if (n >= k && k >= 0)
                d = Faktorial(n) / (Faktorial(k) * Faktorial(n - k));
            else
                d = 0;
            return d;
        }
    }
}
