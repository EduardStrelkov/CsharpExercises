using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7, b = 3, c = 7;
            bool ruz;

            if (a != b)
            {
                if (a != c)
                {
                    if (b != c)
                        ruz = true;
                    else ruz = false;
                }
                else ruz = false;
            }
            else ruz = false;

            if (ruz == true)
                Console.WriteLine("ruzna");
            else
                Console.WriteLine("Neruzna");
            Console.ReadLine();
        }
    }
}
