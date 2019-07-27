using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ArrayHourglass
    {
        public static void CalculateHourglass()
        {
            //int[][] arr = new int[6][];
            //for (int arr_i = 0; arr_i < 6; arr_i++)
            //{
            //    string[] arr_temp = Console.ReadLine().Split(' ');
            //    arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            //}
            int[][] arr = new int[6][];
            arr = new int[][]
            {
                new int[] { 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 0, 2, 4, 4, 0 },
                new int[] { 0, 0, 0, 2, 0, 0 },
                new int[] { 0, 0, 1, 2, 4, 0 },
            };
            arr = new int[][]
            {
                new int[] { -1, -1, 0, -9, -2, -2 },
                new int[] { -2, -1, -6, -8, -2, -5 },
                new int[] { -1, -1, -1, -2, -3, -4 },
                new int[] { -1, -9, -2, -4, -4, -5 },
                new int[] { -7, -3, -3, -2, -9, -9 },
                new int[] { -1, -3, -1, -2, -4, -5 },
            };
            Console.Write(FindMaxHourglass(arr));
        }

        private static int FindMaxHourglass(int[][] arr)
        {
            int endPointX = 2;
            int endPointY = 2;
            int maxSum = int.MinValue;
            while(endPointX < arr.Length)
            {
                endPointY = 2;
                while (endPointY < arr[endPointX].Length)
                {
                    int currentSum = SumHourglass(arr, endPointX, endPointY);
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                    endPointY++;
                }
                endPointX++;
            }

            return maxSum;
        }

        private static int SumHourglass(int[][] arr, int endPointX, int endPointY)
        {
            return arr[endPointX - 2][endPointY - 2] + arr[endPointX - 2][endPointY - 1] + arr[endPointX - 2][endPointY]
                                                     + arr[endPointX - 1][endPointY - 1] +
                   arr[endPointX][endPointY - 2]     + arr[endPointX][endPointY - 1]     + arr[endPointX][endPointY];
        }
    }
}
