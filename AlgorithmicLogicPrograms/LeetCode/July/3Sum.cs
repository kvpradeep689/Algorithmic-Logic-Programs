using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetCode.July
{
    public class ThreeSumClass
    {
        public static void Run()
        {
            ThreeSumClass threeSum = new ThreeSumClass();
            var arr = new int[] { -1, 0, 1, 2, -1, -4 };
            //threeSum.ThreeSum(arr);
            arr = new int[] {-2, 0, 0, 2, 2};
            threeSum.ThreeSum(arr);
        }
        private IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            int leftIndex, rightIndex;
            var threeSumList = new List<IList<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i - 1] == nums[i])
                {
                    continue;
                }
                leftIndex = i + 1;
                rightIndex = nums.Length - 1;
                while (leftIndex < rightIndex)
                {
                    int sum = nums[i] + nums[leftIndex] + nums[rightIndex];
                    if (sum == 0)
                    {
                        threeSumList.Add(new List<int> { nums[i], nums[leftIndex], nums[rightIndex] });
                        leftIndex++;
                        while (leftIndex < rightIndex && nums[leftIndex - 1] == nums[leftIndex])
                        {
                            leftIndex++;
                        }
                        rightIndex--;
                        while (rightIndex > leftIndex && nums[rightIndex + 1] == nums[rightIndex])
                        {
                            rightIndex--;
                        }
                    }
                    else if (sum < 0)
                    {
                        leftIndex++;
                    }
                    else
                    {
                        rightIndex--;
                    }
                    
                }
            }
            return threeSumList;
        }
    }
}
