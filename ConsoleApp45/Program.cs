using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            int d;

        begin:
            try
            {
                Console.Write("Napiste cislo n ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("chyba {0}", fe.Message);
                goto begin;
            }

        begin1:
            try
            {
                Console.Write("Napiste cisla Fibonacci ");
                d = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("chyba : {0}", fe.Message);
                goto begin1;
            }
            int c = FibonacciRek(n, d);
            Console.WriteLine("Vasi cislo {0}", c);
            Console.ReadLine();
        }

        static int FibonacciRek(int n, int d)
        {
            int c = 0;
            int tmp = 0;
            if (n < d)
                c = 0;
            if (n == d)
                c = 1;
            if (n > d)
            {
                tmp = 0;
                for (int i = 1; i <= d; i++)
                {
                    tmp = tmp + FibonacciRek(n - i, d);
                }
                c = tmp;
            }

            return c;
        }
    }
}
