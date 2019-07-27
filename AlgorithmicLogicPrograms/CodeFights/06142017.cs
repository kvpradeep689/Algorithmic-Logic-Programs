using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.CodeFights
{
    public class _06142017
    {
        public static void Method1()
        {
            //int[][] mat = new int[][] { new int[] { 1, 12, 11, 10 },
            //                              new int[] { 4, 3, 2, 9 },
            //                              new int[] { 5, 6, 7, 8 } };
            //int[][] mat2 = new int[][] { new int[] { 1, 2, -1 },
            //                              new int[] { -4, -8, 3 }};
            //Console.WriteLine(maxSubmatrixSum(mat2, 2, 2));

            robotWalk(new int[] { 10, 3, 10, 2, 5, 1, 2 });
        }

        static bool robotWalk(int[] a)
        {
            IList<string> list = new List<string>();
            int x = 0;
            int y = 0;
            int modX = 0;
            int modY = 1;
            list.Add(x + "::" + y);
            foreach (int i in a)
            {
                for (int j = 0; j < i; j++)
                {
                    if (list.Contains((x + modX) + "::" + (y + modY)))
                    {
                        return true;
                    }
                    x += modX;
                    y += modY;
                    list.Add(x + "::" + y);
                }
                if (modX == 0 && modY == 1)
                {
                    modX = 1;
                    modY = 0;
                }
                else if (modX == 1 && modY == 0)
                {
                    modX = 0;
                    modY = -1;
                }
                else if (modX == 0 && modY == -1)
                {
                    modX = -1;
                    modY = 0;
                }
                else if (modX == -1 && modY == 0)
                {
                    modX = 0;
                    modY = 1;
                }
            }
            return false;
        }


        private static int maxSubmatrixSum(int[][] matrix, int n, int m)
        {
            int total = 0;
            int maxTotal = int.MinValue;

            for (int k = 0; k <= matrix.GetLength(0) - n; k++)
            {
                for (int l = 0; l <= matrix[k].Length - m; l++)
                {
                    total = 0;
                    for (int i = k; i < k + n; i++)
                    {
                        for (int j = l; j < l + m; j++)
                        {
                            total += matrix[i][j];
                        }
                    }
                    if (total > maxTotal)
                    {
                        maxTotal = total;
                    }
                }
            }
            return maxTotal;
        }

        //IList<int> setIntersection(IList<int> a, IList<int> b)
        //{

        //    Collections.sort(a);
        //    Collections.sort(b);
        //    ArrayList<int> c = new ArrayList<>(a);

        //    int pos_b = 0;
        //    for (int pos_a = 0; pos_a < a.size(); pos_a++)
        //    {
        //        while (pos_b < b.size() && b.get(pos_b) < a.get(pos_a))
        //        {
        //            pos_b++;
        //        }
        //        if (pos_b == b.size())
        //        {
        //            break;
        //        }
        //        if (a.get(pos_a).equals(b.get(pos_b)))
        //        {
        //            c.add(a.get(pos_a));
        //            pos_b++;
        //        }
        //    }

        //    return c;
        //}

    }
}
