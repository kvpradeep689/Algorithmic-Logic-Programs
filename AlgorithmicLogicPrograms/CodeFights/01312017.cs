using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.CodeFights
{
    public class _01312017
    {
        public static void Method1()
        {
            //Console.WriteLine(zerosAndOnes("111*000"));
            //Console.WriteLine(zerosAndOnes("1110000"));
            //Console.WriteLine(zerosAndOnes("00"));
            //Console.WriteLine(zerosAndOnes("11"));
            //Console.WriteLine(zerosAndOnes("***111000"));
            //Console.WriteLine(zerosAndOnes("1011*01001"));
            //Console.WriteLine(zerosAndOnes("*000*"));
            //  int[,] matrix = new int[,] { { 2, 7, 1 },
            //{ 0, 2, 0 },
            //{ 1, 3, 1} };
            //  Console.WriteLine(rowsRearranging(matrix));

            //  matrix = new int[,] { { 6, 4, },
            //{ 2, 2 },
            //{ 4, 3} };
            //  Console.WriteLine(rowsRearranging(matrix));

            //Console.WriteLine(subarrayCount(new int[] { 7, 1, 2, 4, 5 }, 3));


        }

        static int subarrayCount(int[] a, int k)
        {

            int result = 0;
            int left = 0;
            for (int i = 0; i <= a.Length; i++)
            {
                if (i == a.Length || a[i] <= k)
                {
                    result += (i - left) * (i - left + 1) / 2;
                    left = i + 1;
                }
            }

            return result;
        }

        class Helper
        {
            public void swapRows(int row1, int row2, int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    int tmp = matrix[row1,i];
                    matrix[row1,i] = matrix[row2,i];
                    matrix[row2,i] = tmp;
                }
            }
        };
        static bool rowsRearranging(int[,] matrix)
        {
            Helper h = new Helper();

            for (int i = 0; i<matrix.GetUpperBound(1); i++) {
            int minIndex = i;
            for (int j = i; j< matrix.GetUpperBound(1); j++) {
                if (matrix[j,0] < matrix[minIndex,0]) {
                minIndex = j;
                }
            }
            h.swapRows(i, minIndex, matrix);
        }

          bool answer = true;
          for (int i = 0; i<matrix.GetLength(1); i++) {
            for (int j = 1; j< matrix.GetLength(0); j++) {
              if (matrix[j,i] <= matrix[j - 1,i]) {
                answer = false;
              }
            }
          }

          return answer;
        }


        static int zerosAndOnes(string s)
        {
            Stack<char> stack = new Stack<char>();
            int totalCount = 0;
            foreach (char c in s)
            {
                if(c == '*')
                {
                    totalCount += stack.Count + 1;
                    stack.Clear();
                }
                else if(stack.Count != 0 && ((c == '1' && stack.Peek() == '0') ||
                    c == '0' && stack.Peek() == '1'))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }
            return totalCount + stack.Count;
        }


    }
}
