using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = { 15, 16, 9, 9, 8, 5, 2, 2, 1 };
            for (int i = 0; i < pole.Length; i++)
            {
                Console.WriteLine("{0}", pole[i]);
            }
            Console.WriteLine();
            bool je = JeSestupne(pole);
            Console.WriteLine("{0}", je);
            Console.ReadLine();
        }

        static bool JeSestupne(int[] pole)
        {
            bool je = true;

            int i, j;

            for (i = 0; i < pole.Length; i++)
            {
                for (j = i; j < pole.Length; j++)
                    if (pole[j] > pole[i])
                    {
                        je = false;
                    }
            }
            return je;
        }
    }
}
