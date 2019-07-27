using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetCode
{
    public class _01142017
    {
        public static void FindMaxConsecutiveOnesFlipAZero()
        {
            Console.WriteLine("4: " + FindMaxConsecutiveOnes(new int[] { 1, 0, 1, 1, 0 }));
            Console.WriteLine("12: " + FindMaxConsecutiveOnes(new int[] { 1, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
            Console.WriteLine("4: " + FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1 }));
            Console.WriteLine("1: " + FindMaxConsecutiveOnes(new int[] { 1 }));
            Console.WriteLine("1: " + FindMaxConsecutiveOnes(new int[] { 0 }));
            Console.WriteLine("3: " + FindMaxConsecutiveOnes(new int[] { 0, 1, 1 }));
            Console.WriteLine("3: " + FindMaxConsecutiveOnes(new int[] { 1, 1, 0 }));
            Console.WriteLine("3: " + FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 0 }));
            Console.WriteLine("3: " + FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 0, 1, 1 }));
            Console.WriteLine("2: " + FindMaxConsecutiveOnes(new int[] { 0, 1 }));
            Console.WriteLine("2: " + FindMaxConsecutiveOnes(new int[] { 1, 1 }));
            Console.WriteLine("1: " + FindMaxConsecutiveOnes(new int[] { 0, 0 }));
        }

        public static int FindMaxConsecutiveOnes(int[] nums)
        {

            int count = 0;
            int maxCount = 0;
            int lastCount = 0;
            bool stillCounting = false;
            int zeroIndex = -1;
            int i = 0;
            for(i = 0; i < nums.Length; i++)
            {
                if(nums[i] == 0)
                {
                    if (count + lastCount + 1 > maxCount)
                    {
                        maxCount = count + lastCount + 1;
                        stillCounting = true;
                    }
                    else
                    {
                        stillCounting = false;
                    }
                    lastCount = count;
                    count = 0;
                    zeroIndex = i;
                }
                else
                {
                    count++;
                }
            }
            //if ((stillCounting || (nums[i - 1] == 0 && !stillCounting)) && count + lastCount + 1 > maxCount)
            if (zeroIndex == -1)
            {
                maxCount = count;
            }
            else if (stillCounting && count + lastCount + 1 > maxCount)
            {
                maxCount = count + lastCount + 1;
            }
            return maxCount;
        }

        public static void FindMinStepOutput()
        {
            Console.WriteLine(FindMinStep("WRRBBW", "RB"));
            Console.WriteLine(FindMinStep("WWRRBBWW", "WRBRW"));
            Console.WriteLine(FindMinStep("G", "GGGGG"));
            Console.WriteLine(FindMinStep("RBYYBBRRB", "YRBGB"));
        }

        public static int FindMinStep(string board, string hand)
        {
            SortedDictionary<char, int> boardDict = new SortedDictionary<char, int>();
            Dictionary<char, int> handDict = new Dictionary<char, int>();
            int returnVal = -1;
            bool continueProcessing = true;
            foreach (char c in hand)
            {
                if (handDict.ContainsKey(c))
                {
                    handDict[c]++;
                }
                else
                {
                    handDict.Add(c, 1);
                }
            }
            foreach (char c in board)
            {
                if (handDict.ContainsKey(c))
                {
                    if (boardDict.ContainsKey(c))
                    {
                        boardDict[c]++;
                    }
                    else
                    {
                        boardDict.Add(c, 1);
                    }
                }
                else
                {
                    continueProcessing = false;
                    break;
                }
            }
            if (continueProcessing)
            {
                foreach(var kvp in boardDict)
                {
                    if(kvp.Value + handDict[kvp.Key] < 3)
                    {
                        continueProcessing = false;
                    }
                }
            }
            return returnVal;
        }
    }
}
