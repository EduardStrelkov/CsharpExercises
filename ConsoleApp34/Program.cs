using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static int prirazeni = 0, porovnani = 0;
        static void Main(string[] args)
        {
            int x = 5, y = 4, z = 3;
            bool je1, je2, je3;
            je1 = JeMensi(y, z);
            je2 = JeMensi(x, z);
            je3 = JeVetsi(x, y);
            Prirazeni(ref x, y);
            Prirazeni(ref y, z);
            Console.WriteLine("Prirazeni: {0}, Porovnani: {1}", prirazeni, porovnani);
            Console.ReadLine();
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
