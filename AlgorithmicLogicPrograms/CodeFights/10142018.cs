using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.CodeFights
{
    class _10142018
    {

        public static void CalculateTotals()
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 0, 0, 0 };
            matrix[1] = new int[] { 0, 0, 0 };
            matrix[2] = new int[] { 0, 0, 0 };
            neighboringCells(matrix);
        }

        static int[][] neighboringCells(int[][] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix[i].GetLength(0); j++)
                {
                    int count = 0;
                    if (i != 0 && i != matrix.GetLength(0) - 1)
                    {
                        count++;
                    }
                    if (matrix.GetLength(0) > 1)
                    {
                        count++;
                    }
                    if (j != 0 && j != matrix[i].GetLength(0) - 1)
                    {
                        count++;
                    }

                    if (matrix[i].GetLength(0) > 1)
                    {
                        count++;
                    }
                    matrix[i][j] = count;
                }
            }
            return matrix;
        }
    }
}
