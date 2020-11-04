using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
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
            char[] s3 = SubString(s1, 2, 3);
            Console.WriteLine(s3);
            Console.ReadLine();
        }

        static char[] SubString(char[] s1, int index, int length)
        {
            if (index > s1.Length - 1 || index < 0)
                return "index prevysil max index radku nebo zaporny".ToCharArray();

            char[] s = new char[Math.Min(length, s1.Length - index)];
            for (int i = index; i < Math.Min(index + length, s1.Length); i++)
            {
                s[i - index] = s1[i];
            }
            return s;
        }
}
