using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s1 = "Eduard ".ToCharArray();
            for (int i = 0; i < s1.Length; i = i + 1)
            {
                Console.Write(s1[i]);
            }
            Console.WriteLine();
            char[] s3 = Insert(s1, 6, " Strelkov".ToCharArray());
            Console.WriteLine(s3);
            Console.ReadLine();
        }

        static char[] Insert(char[] s1, int index, char[] s2)
        {
            if (index < 0 || index > s1.Length - 1)
                return "index prevysil max index radku nebo zaporny".ToCharArray();
            char[] s3 = new char[s1.Length + s2.Length];
            for (int i = 0; i < index; i++)
                s3[i] = s1[i];
            for (int i = index; i < index + s2.Length; i++)
                s3[i] = s2[i - index];
            for (int i = index + s2.Length; i < s2.Length + s1.Length; i++)
                s3[i] = s1[i - s2.Length];

            return s3;
        }
    }
}
