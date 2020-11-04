using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double x;
            Console.WriteLine("Napiste cislo: ");
            n = Convert.ToInt32(Console.ReadLine());
            x = Faktorial(n);
            Console.WriteLine("Faktorial pro cislo {0} = {1}", n, x);
            Console.ReadLine();
        }
        static double Faktorial(int n)
        {
            double d = 1;
            for (int i = 1; i <= n; i++)
                d = d * i;
            return d;
        }
    }
}
