using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.CodeFights
{
    public class SortStringChars
    {
        public static void SortString()
        {
            Console.WriteLine(sortIt("Pradeep"));
            Console.WriteLine(sortIt("Vaibhav"));
            Console.WriteLine(sortIt("AbCcBAaaDaEe"));
        }

        static string sortIt(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = i; j < chars.Length; j++)
                {
                    if (char.ToLowerInvariant(chars[j]) < char.ToLowerInvariant(chars[i]) || 
                        (char.ToLowerInvariant(chars[j]) == char.ToLowerInvariant(chars[i]) && chars[j] < chars[i]))
                    {
                        char c = chars[j];
                        chars[j] = chars[i];
                        chars[i] = c;
                    }
                }
            }
            return new string(chars);
        }
    }
}
