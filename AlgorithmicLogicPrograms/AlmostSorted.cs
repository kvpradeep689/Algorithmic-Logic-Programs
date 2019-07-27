using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/almost-sorted
    /// </summary>
    public class AlmostSorted
    {
        enum Progression { None, Descending, Ascending };

        /// <summary>
        /// Incomplete logic
        /// </summary>
        public static void CheckSwapReverse()
        {
            int count = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(nums, Int32.Parse);
            int index = 0;
            int lastKnownLowerIndex = -1;
            int lastKnownHigherIndex = -1;
            Progression progression = Progression.None;
            while (index < count)
            {
                if (arr[index + 1] < arr[index])
                {
                    lastKnownHigherIndex = index;
                    if (index > 0)
                    {
                        lastKnownLowerIndex = index - 1;
                    }
                }
                while (arr[index + 1] < arr[lastKnownHigherIndex] && index < count - 1)
                {
                    index++;
                }

                if (arr[index + 1] > arr[index])
                {
                    progression = Progression.Ascending;
                }
                index++;
            }
        }
    }
}
