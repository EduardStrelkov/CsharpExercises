using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            BinToText("cisla.dat", "cisla.txt");

            Console.WriteLine("Ok");
            Console.ReadKey();
        }

        static void BinToText(string namefileb, string namefilet)
        {

            long numElem = 0;
            BinaryReader fin = null;
            Stream sf;

            try
            {
                sf = File.Open(namefileb, FileMode.Open);
                fin = new BinaryReader(sf);
            }
            catch
            {
                Console.WriteLine("Nemuzu otevrit soubor");
                return;
            }

            numElem = sf.Length / 4;

            uint[] mass = new uint[numElem];

            for (int vi = 0; vi < numElem; vi++)
            {

                mass[vi] = fin.ReadUInt32();
            }

            sf.Close();

            StreamWriter sw;

            try
            {
                sw = new StreamWriter(namefilet);
            }
            catch
            {
                Console.WriteLine("Nemuzu vytvorit soubor");
                return;
            }


            for (int vi = 1; vi <= numElem; vi++)
            {
                sw.Write("{0} ", mass[vi - 1]);
                if ((vi % 10) == 0)
                    sw.Write("\n");
            }

            sw.Close();

        }
    }
}
