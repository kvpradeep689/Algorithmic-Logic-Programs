using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class StringCount
    {
        public static void CountStrings()
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, int> hash = new Dictionary<string, int>();
            for (int i = 0; i < count; i++)
            {
                string st = Console.ReadLine();
                if (hash.ContainsKey(st))
                {
                    hash[st] = hash[st] + 1;
                }
                else
                {
                    hash.Add(st, 1);
                }
            }
            count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();
                if (hash.ContainsKey(str))
                {
                    Console.WriteLine(hash[str]);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
