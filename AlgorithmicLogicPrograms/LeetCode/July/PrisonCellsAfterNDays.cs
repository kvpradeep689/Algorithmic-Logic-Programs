using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetCode.July
{
    /// <summary>
    /// https://leetcode.com/explore/challenge/card/july-leetcoding-challenge/544/week-1-july-1st-july-7th/3379/
    /// </summary>
    public class PrisonCellsAfterNDays
    {
        public static void Run()
        {
            var arr = PrisonAfterNDays(new int[] { 1, 0, 0, 1, 0, 0, 1, 0 }, 1000000000);
            Console.WriteLine(string.Join(",", arr));
            Console.WriteLine(string.Join(",", PrisonAfterNDays(new int[] { 0, 1, 0, 1, 1, 0, 0, 1 }, 7)));
        }

        private static int[] PrisonAfterNDays(int[] cells, int N)
        {
            var currentStatus = cells;
            Dictionary<string, int> uniqueStates = new Dictionary<string, int>();
            int remainingIterations = 0;
            for (int i = 0; i < N; i++)
            {
                currentStatus = PrisonAfterOneDay(currentStatus);
                string currestStatusStr = string.Join(",", currentStatus);
                if (uniqueStates.ContainsKey(currestStatusStr))
                {
                    int cycleLength = i + 1 - uniqueStates[currestStatusStr];
                    remainingIterations = (N - i) % cycleLength;
                    break;
                }
                else
                {
                    uniqueStates.Add(currestStatusStr, i + 1);
                }
                //Console.WriteLine(currestStatusStr);
            }
            if (remainingIterations == 0) { remainingIterations = uniqueStates.Count; }
            var currentStatusStr = uniqueStates.Where(state => state.Value == (remainingIterations)).FirstOrDefault();
            return Array.ConvertAll(currentStatusStr.Key.Split(new[] { "," }, StringSplitOptions.None), int.Parse);
            //return currentStatus;
        }

        private static int[] PrisonAfterOneDay(int[] cells)
        {
            var newStatus = new int[cells.Length];
            for (int i = 1; i < cells.Length - 1; i++)
            {
                newStatus[i] = cells[i - 1] == cells[i + 1] ? 1 : 0;
            }
            return newStatus;
        }
    }
}
