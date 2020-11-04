using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 9, b = 2, c = 6;
            int sud = 0, lich = 0;

            if (a % 2 == 0)
                sud = sud + a;
            else
                lich = lich + a;
            if (b % 2 == 0)
                sud = sud + b;
            else
                lich = lich + b;
            if (c % 2 == 0)
                sud = sud + c;
            else
                lich = lich + c;
            if (sud >= lich)
                Console.WriteLine("sud vice");
            else
                Console.WriteLine("lich vice");
            Console.ReadLine();
        }
    }
}
