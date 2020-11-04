using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        enum DPH { Zakladni, PrvniSnizena, DruhaSnizena };
        static void Main(string[] args)
        {
            double a, b, x;
            Console.WriteLine("Zadekte rust: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadejte massu: ");
            a = Convert.ToDouble(Console.ReadLine());
            x = SpoctiBMI1(b, a);
            Console.WriteLine("BMI pri masse {0} i ruste {1} = {2}", b, a, x);
            Console.ReadLine();     
        }
        static double SpoctiBMI1(double a, double b)
        {
            return a / (b * b);
        }
    }
}
