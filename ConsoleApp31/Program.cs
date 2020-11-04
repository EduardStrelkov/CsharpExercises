using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = { 5, 7, 2, 1, 0, 6 };
            int length = pole.Length;
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", pole[i]);
            }
            ObratPole(pole);
            Console.WriteLine();
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", pole[i]);
            }
            Console.ReadLine();
        }

        static void ObratPole(int[] pole)
        {
            int length = pole.Length;
            int[] pole1 = new int[length];
            for (int i = 0; i < length; i++)
            {
                pole1[i] = pole[length - 1 - i];
            }
            for (int i = 0; i < length; i++)
            {
                pole[i] = pole1[i];
            }
        }
    }
}
