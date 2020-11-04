using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 43;
            Console.WriteLine("Hodnota promenne je {0}", age);
            if (age < 6)
                Console.WriteLine("Cestujici ve veku {0} let zaplati jizdne 0 Kc.", age);
            else
            {
                if (age < 15 || age >= 60)
                    Console.WriteLine("Cestujici ve veku {0} let zaplati jizdne 12 Kc.", age);
                else
                    Console.WriteLine("Cestujici ve veku {0} let zaplati jizdne 24 Kc.", age);
            }
            Console.ReadLine();
        }
    }
}
