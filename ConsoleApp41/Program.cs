using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s1 = "klobouk".ToCharArray();
            for (int i = 0; i < s1.Length; i = i + 1)
            {
                Console.Write(s1[i]);
            }
            Console.WriteLine();
            char[] s2 = Remove(s1, 3, 2);
            Console.WriteLine(s2);
            Console.ReadLine();
        }

        static char[] Remove(char[] s1, int index, int length)
        {
            if (index < 0 || index > s1.Length - 1)
                return "index prevysil max index radku nebo zaporny".ToCharArray();
            if (length > s1.Length)
                return "length of the part to be removed is higher than the overall length".ToCharArray();
            char[] s2 = new char[s1.Length - length];
            for (int i = 0; i < index; i++)
                s2[i] = s1[i];
            for (int i = index; i < s2.Length; i++)
            {
                s2[i] = s1[i + length];
            }
            return s2;
        }
    }
}
