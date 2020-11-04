using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        enum DPH { Zakladni, PrvniSnizena, DruhaSnizena };
        static void Main(string[] args)
        {
            double a, x;
            string b;
            Console.WriteLine("Zadejte cenu: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadaejte DPH: ");
            b = Console.ReadLine();
            x = SpoctiDPH2(a, b);
            Console.WriteLine("Cena posle DPH {0} % ot {1} = {2}", b, a, x);
            Console.ReadLine();
        }
        static double SpoctiDPH2(double a, string procent)
        {
            double b = 0;
            if (procent == "Zakladni")
                b = 21;
            if (procent == "PrvniSnizena")
                b = 15;
            if (procent == "DruhaSnizena")
                b = 10;
            return a + (b / 100) * a;
        }
    }
}
