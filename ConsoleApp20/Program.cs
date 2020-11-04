using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        enum DPH { Zakladni, PrvniSnizena, DruhaSnizena };
        static void Main(string[] args)
        {
            double a, b;
            string x;
            Console.WriteLine("Napiste rust: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Napiste massu: ");
            a = Convert.ToDouble(Console.ReadLine());
            x = SpoctiBMI2(b, a);
            Console.WriteLine("BMI pri masse {0} i roste {1} = {2}", a, b, x);
            Console.ReadLine();
        }
        static string SpoctiBMI2(double b, double a)
        {
            double d = a / (b * b);
            string bmi = "0";
            if (d >= 0 && d < 16.5)
                bmi = "Tezka podvyziva";
            if (d >= 16.5 && d < 18.5)
                bmi = "Podvaha";
            if (d >= 18.5 && d < 25)
                bmi = "Optimalni vaha";
            if (d >= 25 && d < 30)
                bmi = "Nadvaha";
            if (d >= 30 && d < 35)
                bmi = "Obezita prvniho stupne";
            if (d >= 35 && d < 40)
                bmi = "Obezita druheho stupne";
            if (d >= 40)
                bmi = "Obezita tretiho stupne";
            return bmi;
        }
    }
}
