using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s1 = "eduard 123".ToCharArray();
            char[] s2 = "eduard 987".ToCharArray();
            for (int i = 0; i < s1.Length; i = i + 1)
            {
                Console.Write("{0} ", s1[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < s2.Length; i = i + 1)
            {
                Console.Write("{0} ", s2[i]);
            }
            int result = Compare(s1, s2);
            Console.WriteLine();
            Console.Write(result);
            Console.ReadLine();
        }
        static int Compare(char[] s1, char[] s2)
        {
            int result = 0;
            int length = Math.Min(s1.Length, s2.Length);
            for (int i = 0; i < length; i++)
            {
                if (s1[i].CompareTo(s2[i]) < 0)
                {
                    result = -1;
                    break;
                }
                if (s1[i].Equals(s2[i]))
                    continue;
                if (s1[i].CompareTo(s2[i]) > 0)
                {
                    result = 1;
                    break;
                }
            }
            if (result == 0 && s1.Length != s2.Length)
            {
                if (s1.Length > s2.Length)
                {
                    result = 1;
                }
                if (s1.Length < s2.Length)
                {
                    result = -1;
                }
            }
            return result;
        }
    }
}
