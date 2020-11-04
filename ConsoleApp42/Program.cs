using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            uint N = 0;

            while (flag)
            {
                Console.Write("Napiste pocet N:  ");
                try
                {
                    N = Convert.ToUInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("N je spatny parametr");
                    Console.WriteLine("Zkuste jeste jednou");
                    continue;
                }

                if (N <= uint.MinValue || N > uint.MaxValue)
                {
                    Console.WriteLine("N je spatny parametr");
                    Console.WriteLine("Zkuste jeste jednou");
                    continue;
                }
                flag = false;

            }

            GenerationNumber("cisla.dat", N);

            Console.WriteLine("Ok");
            Console.ReadKey();
        }

        static void GenerationNumber(string filename, uint size)
        {
            BinaryWriter fout = null;
            Stream sf;

            uint[] Numbers = new uint[size];

            Random rnd = new Random();

            for (int vi = 0; vi < size; vi++)
            {
                Numbers[vi] = (uint)rnd.Next();
            }


            try
            {
                sf = File.Open(filename, FileMode.Create);
                fout = new BinaryWriter(sf);
            }
            catch
            {
                Console.WriteLine("Nemuzu otevrit soubor");
                return;
            }

            try
            {
                for (int vi = 0; vi < size; vi++)
                {
                    fout.Write(Numbers[vi]);
                }

            }
            catch
            {
                Console.WriteLine("Nemuzu zapsat ve soubor");
                return;
            }

            fout.Close();


        }
    }
}
