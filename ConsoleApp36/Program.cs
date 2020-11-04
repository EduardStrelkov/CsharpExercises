using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static int prirazeni = 0, porovnani = 0;
        static void Main(string[] args)
        {
            int[] pole = { 5, 7, 1, 5, 6, 8, 9, 0, 1, 2 };
            for (int i = 0; i < pole.Length; i = i + 1)
            {
                Console.Write("{0} ", pole[i]);
            }
            Console.WriteLine();
            SelectionSort(pole);
            for (int i = 0; i < pole.Length; i = i + 1)
            {
                Console.Write("{0} ", pole[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Prirazeni: {0}, Porovnani: {1}", prirazeni, porovnani);
            Console.ReadLine();
        }
        static void SelectionSort(int[] pole)
        {
            int i, j, max;
            for (i = 0; i < pole.Length; i = i + 1)
            {
                max = i;
                for (j = i; j < pole.Length; j = j + 1)
                    if (JeVetsi(pole[j], pole[max]))
                        Prirazeni(ref max, j);
                Vymena(ref pole[max], ref pole[i]);
            }
        }
        static void Vymena(ref int x, ref int y)
        {
            int tmp = x;
            Prirazeni(ref x, y);
            Prirazeni(ref y, tmp);
        }
        static bool JeMensi(int a, int b)
        {
            porovnani++;

            bool je;
            if (a < b)
                je = true;
            else je = false;
            return je;
        }
        static bool JeVetsi(int a, int b)
        {
            porovnani++;

            bool je;
            if (a > b)
                je = true;
            else je = false;
            return je;
        }
        static void Prirazeni(ref int a, int b)
        {
            prirazeni++;
            a = b;
        }

    }
}
