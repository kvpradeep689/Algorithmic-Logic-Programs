using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.CodeFights
{
    /// <summary>
    /// 
    //Given an array of string numbers (i.e. strings that contain only digits), return the greatest possible number of appending these numbers to each other as a string.

    //    Example

    //    For nums = [ "20", "3005", "2" ], the output should be
    //greatestNumber(nums) = "3005220".
    //Input/Output

    //[execution time limit] 3 seconds(cs)

    //[input] array.string nums

    //An array of string numbers(i.e.strings that contain only digits).
    //String numbers are valid integer non-negative numbers.

    //Guaranteed constraints:
    //0 < nums.length ≤ 50,
    //0 < nums[i].length ≤ 6.

    //[output] string

    //The greatest possible number of appending given array's numbers to each other as a string.

    //[C#] Syntax Tips

    //// Prints help message to the console
    //// Returns a string
    //string helloWorld(string name) {
    //        Console.Write("This prints to the console when you Run Tests");
    //        return "Hello, " + name;
    //    }
    /// </summary>
    class HugeNumber
    {
        public static void FindHugeNumber()
        {
            var input1 = new string[] { "20", "3005", "2" };
            Console.WriteLine(CalculateHugeNumber(input1));
            var input2 = new string[] { "10", "01", "11" };
            Console.WriteLine(CalculateHugeNumber(input2));
            var input3 = new string[] { "303", "43" };
            Console.WriteLine(CalculateHugeNumber(input3));
            var input4 = new string[] { "90", "9", "99", "990", "98", "9", "899" };
            Console.WriteLine(CalculateHugeNumber(input4));
            var input5 = new string[] { "2946", "4768", "43", "2948", "929", "3308", "2529", "956" };
            Console.WriteLine(CalculateHugeNumber(input5));
            var input6 = new string[] { "286", "973", "572", "907", "193", "929", "93", "552", "842", "789", "910", "11", "906", "998", "298", "12", "78", "294", "999", "24", "117" };
            Console.WriteLine(CalculateHugeNumber(input6));
            var input7 = new string[] { "796", "7967", "7103" };
            Console.WriteLine(CalculateHugeNumber(input7));
            var input8 = new string[] { "999991", "9", "998" };
            Console.WriteLine(CalculateHugeNumber(input8));
            var input9 = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            Console.WriteLine(CalculateHugeNumber(input9));
            var input10 = new string[] { "0", "0" };
            Console.WriteLine(CalculateHugeNumber(input10));
        }

        static string CalculateHugeNumber(string[] nums)
        {
            for (int index = 0; index < nums.Length; index++)
            {
                if (nums[index].Length > 1)
                {
                    nums[index] = nums[index].TrimStart('0');
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (DoNumbersNeedSwap(ref nums, i, j))
                    {
                        SwapNumbers(ref nums, i, j);
                    }
                }
            }
            string returnVal = string.Join("", nums).TrimStart('0');
            if (returnVal == "")
            {
                returnVal = "0";
            }
            return returnVal;
        }

        private static bool DoNumbersNeedSwap(ref string[] nums, int leftIndex, int rightIndex)
        {
            int index = 0;
            if (string.Equals(nums[leftIndex], nums[rightIndex]))
            {
                return false;
            }

            while (nums[leftIndex].Length >= index + 1 && nums[rightIndex].Length >= index + 1)
            {
                if (nums[leftIndex][index] > nums[rightIndex][index])
                {
                    return false;
                }
                else if (nums[leftIndex][index] < nums[rightIndex][index])
                {
                    return true;
                }
                else
                {
                    index++;
                }
            }
            if (nums[leftIndex].Length == index)
            {
                if (nums[rightIndex].Length >= index && nums[rightIndex][index] > nums[leftIndex][index - 1])
                {
                    return true;
                }
                return false;
            }
            if (nums[rightIndex].Length == index)
            {
                if (nums[leftIndex].Length >= index && nums[leftIndex][index] > nums[rightIndex][index - 1])
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        private static void SwapNumbers(ref string[] nums, int i, int j)
        {
            string temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
