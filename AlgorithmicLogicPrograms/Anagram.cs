using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/anagram?h_r=next-challenge&h_v=zen
    /// </summary>
    public class Anagram
    {
        public static void FindAnagramChanges()
        {
            //int count = int.Parse(Console.ReadLine());
            //for (int i = 0; i < count; i++)
            //{
            //    CheckAnagram(Console.ReadLine());
            //}
            CheckAnagram("aaabbb");
            CheckAnagram("ab");
            CheckAnagram("abc");
            CheckAnagram("mnop");
            CheckAnagram("xyyx");
            CheckAnagram("xaxbbbxx");
        }

        private static void CheckAnagram(string str)
        {
            int numberOfChanges = -1;
            if (str.Length % 2 == 0)
            {
                numberOfChanges = 0;
                Dictionary<char, int> leftPart = new Dictionary<char, int>();
                Dictionary<char, int> rightPart = new Dictionary<char, int>();
                for (int i = 0, j = str.Length / 2; i < str.Length / 2; i++, j++)
                {
                    if (!leftPart.ContainsKey(str[i]))
                    {
                        leftPart.Add(str[i], 1);
                    }
                    else
                    {
                        leftPart[str[i]] = leftPart[str[i]] + 1;
                    }
                    if (!rightPart.ContainsKey(str[j]))
                    {
                        rightPart.Add(str[j], 1);
                    }
                    else
                    {
                        rightPart[str[j]] = rightPart[str[j]] + 1;
                    }
                }
                foreach (var item in leftPart)
                {
                    if (rightPart.ContainsKey(item.Key))
                    {
                        if (item.Value > rightPart[item.Key])
                        { 
                            numberOfChanges += item.Value - rightPart[item.Key];
                        }
                    }
                    else
                    {
                        numberOfChanges += item.Value;
                    }
                }
            }

            Console.WriteLine(numberOfChanges);
        }
    }
}
