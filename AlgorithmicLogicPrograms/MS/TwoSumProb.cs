using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.MS
{
    static class TwoSumProb
    {
        public static void Run()
        {
            //TwoSum(new int[] { 0, 4, 3, 0 }, 0);
            //TwoSum(new int[] { -1, -2, -3, -4, -5 }, -8);
            TwoSumV2(new int[] { 0, 4, 3, 0 }, 0);
            TwoSumV2(new int[] { -1, -2, -3, -4, -5 }, -8);
        }

        private static int[] TwoSumV2(int[] nums, int target)
        {
            Dictionary<int, int> foundKeys = new Dictionary<int, int>();

            int secondNumber;
            for (int index = 0; index < nums.Length; index++)
            {
                secondNumber = target - nums[index];

                if (foundKeys.ContainsKey(secondNumber))
                {
                    return new int[] { foundKeys[secondNumber], index };
                }

                if (!foundKeys.ContainsKey(nums[index]))
                {
                    foundKeys.Add(nums[index], index);
                }
            }

            return new int[] { };
        }

        private static int[] TwoSum(int[] nums, int target)
        {
            int[] numsClone = nums.Clone() as int[];
            Array.Sort(nums);
            int leftIndex = 0;
            int rightIndex = nums.Length - 1;

            while (leftIndex < rightIndex)
            {
                int sum = nums[leftIndex] + nums[rightIndex];

                if (sum == target)
                {
                    break;
                }
                if (sum > target)
                {
                    rightIndex--;
                }
                if (sum < target)
                {
                    leftIndex++;
                }
            }
            Console.WriteLine(leftIndex);
            Console.WriteLine(rightIndex);
            //int indexCount = 0;
            bool leftIndexSet = false;
            bool rightIndexSet = false;
            int[] output = new int[2];
            int index = 0;
            for (int i = 0; i < nums.Length && !(leftIndexSet && rightIndexSet); i++)
            {
                if (!leftIndexSet && numsClone[i] == nums[leftIndex])
                {
                    output[index] = i;
                    leftIndexSet = true;
                    index++;
                }
                else if (!rightIndexSet && numsClone[i] == nums[rightIndex])
                {
                    output[index] = i;
                    rightIndexSet = true;
                    index++;
                }
            }

            Console.WriteLine(output[0]);
            Console.WriteLine(output[1]);
            return output;
        }
    }
}
