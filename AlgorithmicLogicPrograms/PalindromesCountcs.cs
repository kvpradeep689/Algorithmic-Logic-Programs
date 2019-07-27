using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PalindromesCountcs
    {
        public static void CountPalindromes()
        {
            Console.WriteLine(palindrome("aabaa"));
        }

        static int palindrome(string str)
        {
            HashSet<string> list = new HashSet<string>();
            HashSet<string> alreadyProcessed = new HashSet<string>();

            int count = 0;
            for(int i = 0; i < str.Length; i++)
            {
                for(int j = i; j < str.Length; j++)
                {
                    string subStr = str.Substring(i, j - i + 1);
                    if (!alreadyProcessed.Contains(subStr) && CheckPalindrome(subStr))
                    {
                        alreadyProcessed.Add(subStr);
                        if (!list.Contains(subStr))
                        {
                            list.Add(subStr);
                            count++;
                        }
                    }
                }
            }
            return count;
        }

        static bool CheckPalindrome(string str)
        {
            bool returnVal = true;
            int length = str.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (str[i] != str[length - i - 1])
                    returnVal = false;
            }
            return returnVal;
        }
    }
}
