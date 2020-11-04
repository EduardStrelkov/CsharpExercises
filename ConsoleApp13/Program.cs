using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.Write("Vsechna dvojciferna cisla jsou: {0}", a);
            for (int i = 1; i < 90; i++)
                Console.Write(", {0}", a + i);
            Console.ReadLine();
        }
    }
}
