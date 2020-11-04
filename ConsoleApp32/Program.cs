using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = { 2, 5, 7, 1, 4, 6, 10, 5, 2 };
            int length = pole.Length;
            int max = 0, max2 = 0, max3 = 0;
            MaxPole(pole, ref max, ref max2, ref max3);
            Console.WriteLine("{0}, {1}, {2}", max, max2, max3);
            Console.ReadLine();
        }
        static void MaxPole(int[] pole, ref int max, ref int max2, ref int max3)
        {
            int length = pole.Length;
            int[] pole2 = new int[length];
            int[] pole3 = new int[length];
            max = pole[0];

            for (int i = 1; i < length; i++)
            {
                max = Math.Max(pole[i], max);
            }

            for (int i = 0; i < length; i++)
            {
                if (pole[i] != max)
                    pole2[i] = pole[i];
                else
                    pole2[i] = int.MinValue;
            }

            max2 = pole2[0];
            for (int i = 1; i < length; i++)
            {
                max2 = Math.Max(pole2[i], max2);
            }

            for (int i = 0; i < length; i++)
            {
                if (pole2[i] != max2)
                    pole3[i] = pole2[i];
                else
                    pole2[i] = int.MinValue;
            }

            max3 = pole3[0];
            for (int i = 1; i < length; i++)
            {
                max3 = Math.Max(pole3[i], max3);
            }
        }
    }
}
