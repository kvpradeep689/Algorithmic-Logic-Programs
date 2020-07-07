using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetCode.July
{
    class IslandPerimeterClass
    {
        public static void Run()
        {
            IslandPerimeterClass ip = new IslandPerimeterClass();
            int[][] grid = new int[][] { new int[] { 0, 1, 0, 0 }, new int[] { 1, 1, 1, 0 }, new int[] { 0, 1, 0, 0 }, new int[] { 1, 1, 0, 0 } };

            Console.WriteLine(ip.IslandPerimeter(grid));
            Console.WriteLine(ip.IslandPerimeter(new int[][] { new int[] { 1 } }));
        }
        public int IslandPerimeter(int[][] grid)
        {
            int perimeter = 0;
            for (int row = 0; row < grid.GetLength(0); row++)
            {
                for (int col = 0; col < grid[0].Length; col++)
                {
                    if (grid[row][col] == 1)
                    {
                        if (row == 0)
                        {
                            perimeter++;
                        }
                        if (row == grid.GetLength(0) - 1)
                        {
                            perimeter++;
                        }
                        if (col == 0)
                        {
                            perimeter++;
                        }
                        if (col == grid[0].Length - 1)
                        {
                            perimeter++;
                        }
                        if (row - 1 >= 0 && grid[row - 1][col] == 0)
                        {
                            perimeter++;
                        }
                        if (row + 1 <= grid.GetLength(0) - 1 && grid[row + 1][col] == 0)
                        {
                            perimeter++;
                        }
                        if (col - 1 >= 0 && grid[row][col - 1] == 0)
                        {
                            perimeter++;
                        }
                        if (col + 1 <= grid[0].Length - 1 && grid[row][col + 1] == 0)
                        {
                            perimeter++;
                        }
                    }
                }
            }
            return perimeter;
        }
    }
}
