using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = { 5, -2, 0, -1, 7, -12, 2, 4 };
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write("{0} ", pole[i]);
            }
            Console.WriteLine();
            AbsolutniHodnotaPole(pole);
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write("{0} ", pole[i]);
            }
            Console.ReadLine();
        }

        static void AbsolutniHodnotaPole(int[] pole)
        {
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = Math.Abs(pole[i]);
            }
        }
    }
}
