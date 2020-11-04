using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Alena ma 2 ruce.";
            for (int i = 0; i < s1.Length; i = i + 1)
            {
                Console.Write(s1[i]);
            }
            Console.WriteLine();
            int ruznych = RuznychPismen(s1);
            Console.WriteLine("Ruznych pisem: {0}", ruznych);
            Console.ReadLine();
        }

        static int RuznychPismen(string s1)
        {
            int ruznych = 1;
            char[] c = s1.ToCharArray(0, s1.Length);
            int i, j, max;

            for (i = 0; i < c.Length; i++)
            {
                max = i;
                if (char.IsUpper(c[i]))
                    c[i] = char.ToLower(c[i]);
                for (j = i + 1; j < c.Length; j = j + 1)
                {
                    if (char.IsUpper(c[j]))
                        c[j] = char.ToLower(c[j]);
                    if (c[i].CompareTo(c[j]) > 0)
                        Vymena(ref c[i], ref c[j]);
                }
            }

            /* for (i = 0; i < c.Length; i++)
             {
                 Console.Write(c[i]);
             }*/
            Console.WriteLine();

            for (i = 1; i < c.Length; i++)
            {
                if (c[i] != c[i - 1] && char.IsLetter(c[i]) && char.IsLetter(c[i - 1]))
                    ruznych++;
            }
            return ruznych;
        }

        static void Vymena(ref char x, ref char y)
        {
            char tmp = x;
            x = y;
            y = tmp;
        }
    }
}
