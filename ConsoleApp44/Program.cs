using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {


            SumOfNumbers("cisla.txt", "soucet.txt");

            Console.WriteLine("Ok");
            Console.ReadKey();
        }
        static void SumOfNumbers(string nfsource, string nfout)
        {
            long sum = 0;
            StreamReader fin = null;
            StreamWriter sw;
            string str = "";

            Stream sf;

            try
            {
                sf = File.Open(nfsource, FileMode.Open);
                fin = new StreamReader(sf);
            }
            catch
            {
                Console.WriteLine("Nemuzu otevrit soubor");
                return;
            }


            try
            {
                sw = new StreamWriter(nfout);
            }
            catch
            {
                Console.WriteLine("Nemuzu vytvorit soubor");
                return;
            }

            while (true)
            {
                str = fin.ReadLine();
                if (str == null)
                {
                    break;
                }
                sum = CalcSumInStr(str);
                sw.Write("{0}", sum);
                sw.Write("\n");
            }

            sf.Close();
            sw.Close();
        }

        static long CalcSumInStr(string instr)
        {
            long summ = 0;
            int num = 0;
            string sym = "";
            string snum = "";


            for (int vi = 0; vi < instr.Length; vi++)
            {
                sym = instr.Substring(vi, 1);

                if (sym == " ")
                {
                    num = Convert.ToInt32(snum);
                    summ += num;
                    snum = "";
                    continue;
                }
                snum = snum + sym;

                if (vi == instr.Length - 1)
                {
                    num = Convert.ToInt32(snum);
                    summ += num;
                }

            }

            return summ;
        }

    }
}
