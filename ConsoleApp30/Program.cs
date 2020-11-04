using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] pole = { 5.12, -3.5996, 156, 7.9 };
            double[] zaokrouhli;
            zaokrouhli = ZaokrouhliPole(pole);
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write("{0} ", zaokrouhli[i]);
            }
            Console.ReadLine();
        }

        static double[] ZaokrouhliPole(double[] pole)
        {
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = Math.Round(pole[i]);
            }
            return pole;
        }
    }
}
