using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int speed = 148;
            int k = 0;
            int imax = (int)Math.Ceiling((double)(speed - 150) / 5);
            Console.WriteLine("Hodnota promenne je {0}", speed);
            if (speed <= 60)
                Console.WriteLine("Rychlost {0} km/h je pokutovana castkou 0 Kc.", speed);
            else
            {
                if (speed <= 130)
                    Console.WriteLine("Rychlost {0} km/h je pokutovana castkou 1000 Kc.", speed);
                else
                {
                    if (speed <= 150)
                        Console.WriteLine("Rychlost {0} km/h je pokutovana castkou 2000 Kc.", speed);
                    else
                    {
                        for (int i = 0; i < imax; i++)
                            k = k + 500;
                        Console.WriteLine("Rychlost {0} km/h je pokutovana castkou {1} Kc.", speed, 2000 + k);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
