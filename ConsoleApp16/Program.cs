using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] A = new bool[1001];

            for (int i = 2; i <= 1000; i++)
            {
                A[i] = true;
            }
            for (int i = 2; i <= 1000; i++)
            {
                if (A[i])
                {
                    for (int j = i * i; j <= 1000; j = j + i)
                    {
                        A[j] = false;
                    }
                }
            }
            Console.Write("Vsechna prvocisla mensi nez 1000: 2");
            for (int i = 3; i <= 1000; i++)
            {
                if (A[i])
                    Console.Write(", {0}", i);
            }
            Console.ReadLine();
        }
    }
}
