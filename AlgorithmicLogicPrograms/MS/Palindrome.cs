using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.MS
{
    static class Palindrome
    {

        public static void Run()
        {
            IsPalindrome("A man, a plan, a canal: Panama");
            IsPalindrome("race a car");
        }
        private static bool IsPalindrome(string s)
        {
            int leftIndex = 0;
            int rightIndex = s.Length - 1;
            char[] chars = s.ToLower().ToCharArray();
            while (leftIndex < rightIndex)
            {
                while (!Char.IsLetterOrDigit(chars[leftIndex])
                      && leftIndex < rightIndex)
                {
                    leftIndex++;
                }
                while (!Char.IsLetterOrDigit(chars[rightIndex])
                      && leftIndex < rightIndex)
                {
                    rightIndex--;
                }
                if (leftIndex != rightIndex && chars[leftIndex] != chars[rightIndex])
                    return false;

                leftIndex++;
                rightIndex--;
            }
            return true;
        }
    }
}
