using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.CodeFights
{
    class MineSweeper
    {
        public static void MineSweeperChallenge()
        {
            bool[][] input1 = new bool[][] {new bool[] {true, false, false },
                                     new bool[] { false, true, false},
                                     new bool[] {false, false, false} };
            WriteOuput(FillArrayWithNumbers(input1));
        }

        private static void WriteOuput(int[][] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[][] FillArrayWithNumbers(bool[][] matrix)
        {
            int[][] output = new int[matrix.GetLength(0)][];

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                output[i] = new int[matrix[i].Length];
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    output[i][j] += CalculateCountValue(matrix, i - 1, j - 1);
                    output[i][j] += CalculateCountValue(matrix, i - 1, j);
                    output[i][j] += CalculateCountValue(matrix, i - 1, j + 1);
                    output[i][j] += CalculateCountValue(matrix, i, j - 1);
                    output[i][j] += CalculateCountValue(matrix, i, j + 1);
                    output[i][j] += CalculateCountValue(matrix, i + 1, j - 1);
                    output[i][j] += CalculateCountValue(matrix, i + 1, j);
                    output[i][j] += CalculateCountValue(matrix, i + 1, j + 1);
                }
            }
            return output;
        }

        private static int CalculateCountValue(bool[][] matrix, int row, int col)
        {
            if (row < 0 || col < 0 || row > matrix.GetLength(0) - 1 || col > matrix[0].Length - 1)
            {
                return 0;
            }
            return matrix[row][col] ? 1: 0;
        }
    }
}
