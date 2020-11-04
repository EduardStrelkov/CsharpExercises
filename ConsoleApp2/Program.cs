using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8, b = 22, c = 10, k = 0;
            if (a < 10)
                k++;
            if (b < 10)
                k++;
            if (c < 10)
                k++;
            Console.WriteLine(k);
            Console.ReadLine();
        }
    }
}
