using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MatrixRotation
    {
        static void MainN(string[] args)
        {
            //string notation = Console.ReadLine();
            //int[] size = Array.ConvertAll(notation.Split(' '), Int32.Parse);
            //int rowCount = size[0];
            //int colCount = size[1];
            //int numRotations = size[2];

            //int[][] matrix = new int[rowCount][];

            //for (int row = 0; row < rowCount; row++)
            //{
            //    matrix[row] = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            //}

            //int rowCount = 4;
            //int colCount = 4;
            //int numRotations = 2;
            //int[][] matrix = new int[4][] { new int[] { 11, 12, 13, 14 },
            //                                new int[] { 15, 16, 17, 18 },
            //                                new int[] { 19, 20, 21, 22 },
            //                                new int[] { 23, 24, 25, 26 }
            //                              };

            //int rowCount = 5;
            //int colCount = 4;
            //int numRotations = 7;
            //int[][] matrix = new int[5][] { new int[] { 11, 12, 13, 14 },
            //                                new int[] { 15, 16, 17, 18 },
            //                                new int[] { 19, 20, 21, 22 },
            //                                new int[] { 23, 24, 25, 26 },
            //                                new int[] { 27, 28, 29, 30 }
            //                              };

            int rowCount = 5;
            int colCount = 5;
            int numRotations = 1;
            int[][] matrix = new int[5][] { new int[] { 11, 12, 13, 14, 1},
                                            new int[] { 15, 16, 17, 18, 2},
                                            new int[] { 19, 20, 21, 22, 3},
                                            new int[] { 23, 24, 25, 26, 4},
                                            new int[] { 27, 28, 29, 30, 5}
                                          };

            int originalRowCount = rowCount;

            PrintMatrix(matrix);

            int backUpValue;
            int i, j, newI, newJ;
            int rotationLevel = 0;
            while (rotationLevel < originalRowCount / 2)
            {
                for (int count = 0; count < numRotations; count++)
                {
                    bool procesNode = true;
                    i = rotationLevel;
                    j = rotationLevel;
                    newI = rotationLevel;
                    newJ = rotationLevel + 1;
                    backUpValue = matrix[rotationLevel][rotationLevel];

                    while ((i != rotationLevel || j != rotationLevel) || procesNode)
                    {
                        matrix[i][j] = matrix[newI][newJ];

                        i = newI;
                        j = newJ;
                        if (newI == rotationLevel && newJ < colCount - 1)
                        {
                            newJ++;
                        }
                        else if (newI < rowCount - 1 && newJ == colCount - 1)
                        {
                            newI++;
                        }
                        else if (newI == rowCount - 1 && newJ > rotationLevel)
                        {
                            newJ--;
                        }
                        else if (newI > rotationLevel && newJ == rotationLevel)
                        {
                            newI--;
                        }

                        procesNode = false;

                        //PrintMatrix(matrix);
                    }
                    matrix[rotationLevel + 1][rotationLevel] = backUpValue;
                }
                rotationLevel++;
                rowCount--;
                colCount--;
            }

            PrintMatrix(matrix);
            Console.ReadLine();
        }

        private static void PrintMatrix(int[][] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Main3(string[] args)
        {
            //string notation = Console.ReadLine();
            //int[] size = Array.ConvertAll(notation.Split(' '), Int32.Parse);
            //int rowCount = size[0];
            //int colCount = size[1];
            //int numRotations = size[2];

            //int[][] matrix = new int[rowCount][];

            //for (int row = 0; row < rowCount; row++)
            //{
            //    matrix[row] = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            //}

            //int rowCount = 4;
            //int colCount = 4;
            //int numRotations = 2;
            //int[][] matrix = new int[4][] { new int[] { 11, 12, 13, 14 },
            //                                new int[] { 15, 16, 17, 18 },
            //                                new int[] { 19, 20, 21, 22 },
            //                                new int[] { 23, 24, 25, 26 }
            //                              };

            //int rowCount = 5;
            //int colCount = 4;
            //int numRotations = 7;
            //int[][] matrix = new int[5][] { new int[] { 11, 12, 13, 14 },
            //                                new int[] { 15, 16, 17, 18 },
            //                                new int[] { 19, 20, 21, 22 },
            //                                new int[] { 23, 24, 25, 26 },
            //                                new int[] { 27, 28, 29, 30 }
            //                              };

            int rowCount = 5;
            int colCount = 5;
            int numRotations = 1;
            int[][] matrix = new int[5][] { new int[] { 11, 12, 13, 14, 1},
                                            new int[] { 15, 16, 17, 18, 2},
                                            new int[] { 19, 20, 21, 22, 3},
                                            new int[] { 23, 24, 25, 26, 4},
                                            new int[] { 27, 28, 29, 30, 5}
                                          };

            int originalRowCount = rowCount;

            PrintMatrix(matrix);

            int backUpValue;
            int i, j, newI, newJ;
            int rotationLevel = 0;
            while (rotationLevel < originalRowCount / 2)
            {
                for (int count = 0; count < numRotations; count++)
                {
                    bool procesNode = true;
                    i = rotationLevel;
                    j = rotationLevel;
                    newI = rotationLevel;
                    newJ = rotationLevel + 1;
                    backUpValue = matrix[rotationLevel][rotationLevel];

                    while ((i != rotationLevel || j != rotationLevel) || procesNode)
                    {
                        matrix[i][j] = matrix[newI][newJ];

                        i = newI;
                        j = newJ;
                        if (newI == rotationLevel && newJ < colCount - 1)
                        {
                            newJ++;
                        }
                        else if (newI < rowCount - 1 && newJ == colCount - 1)
                        {
                            newI++;
                        }
                        else if (newI == rowCount - 1 && newJ > rotationLevel)
                        {
                            newJ--;
                        }
                        else if (newI > rotationLevel && newJ == rotationLevel)
                        {
                            newI--;
                        }

                        procesNode = false;

                        //PrintMatrix(matrix);
                    }
                    matrix[rotationLevel + 1][rotationLevel] = backUpValue;
                }
                rotationLevel++;
                rowCount--;
                colCount--;
            }

            PrintMatrix(matrix);
            Console.ReadLine();
        }

        static void Main1(string[] args)
        {
            //string notation = Console.ReadLine();
            //int[] size = Array.ConvertAll(notation.Split(' '), Int32.Parse);
            //int rowCount = size[0];
            //int colCount = size[1];
            //int numRotations = size[2];

            //int[][] matrix = new int[rowCount][];

            //for(int row = 0; row < rowCount; row++)
            //{
            //    matrix[row] = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            //}

            int rowCount = 4;
            int colCount = 4;
            int[][] matrix = new int[4][] { new int[] { 11, 12, 13, 14 },
                                            new int[] { 15, 16, 17, 18 },
                                            new int[] { 19, 20, 21, 22 },
                                            new int[] { 23, 24, 25, 26 }
                                          };

            PrintMatrix(matrix);

            int temp = matrix[0][0];
            int newI, newJ;
            newI = 0; newJ = 1;
            int i = 0;
            int j = 0;
            bool procesNode = true;

            while ((i != 0 || j != 0) || procesNode)
            {
                matrix[i][j] = matrix[newI][newJ];

                i = newI;
                j = newJ;
                if (newI == 0 && newJ < colCount - 1)
                {
                    newJ++;
                }
                else if (newI < rowCount - 1 && newJ == colCount - 1)
                {
                    newI++;
                }
                else if (newI == colCount - 1 && newJ > 0)
                {
                    newJ--;
                }
                else if (newI > 0 && newJ == 0)
                {
                    newI--;
                }

                procesNode = false;
            }
            matrix[1][0] = temp;
            PrintMatrix(matrix);
        }

        static void Main2(string[] args)
        {
            string notation = Console.ReadLine();
            int[] size = Array.ConvertAll(notation.Split(' '), Int32.Parse);
            int rowCount = size[0];
            int colCount = size[1];
            int numRotations = size[2];

            int[][] matrix = new int[rowCount][];

            for (int row = 0; row < rowCount; row++)
            {
                matrix[row] = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            }

            //int rowCount = 4;
            //int colCount = 4;
            //int[][] matrix = new int[4][] { new int[] { 11, 12, 13, 14 },
            //                                new int[] { 15, 16, 17, 18 },
            //                                new int[] { 19, 20, 21, 22 },
            //                                new int[] { 23, 24, 25, 26 }
            //                              };

            int originalRowCount = rowCount;

            PrintMatrix(matrix);

            int backUpValue;
            int i, j, newI, newJ;
            int rotationLevel = 0;
            while (rotationLevel < originalRowCount / 2)
            {
                bool procesNode = true;
                i = rotationLevel;
                j = rotationLevel;
                newI = rotationLevel;
                newJ = rotationLevel + 1;
                backUpValue = matrix[rotationLevel][rotationLevel];

                while ((i != rotationLevel || j != rotationLevel) || procesNode)
                {
                    matrix[i][j] = matrix[newI][newJ];

                    i = newI;
                    j = newJ;
                    if (newI == rotationLevel && newJ < colCount - 1)
                    {
                        newJ++;
                    }
                    else if (newI < rowCount - 1 && newJ == colCount - 1)
                    {
                        newI++;
                    }
                    else if (newI == colCount - 1 && newJ > rotationLevel)
                    {
                        newJ--;
                    }
                    else if (newI > rotationLevel && newJ == rotationLevel)
                    {
                        newI--;
                    }

                    procesNode = false;
                }
                matrix[rotationLevel + 1][rotationLevel] = backUpValue;
                PrintMatrix(matrix);

                rotationLevel++;
                rowCount--;
                colCount--;
            }

            Console.ReadLine();
        }

    }
}
