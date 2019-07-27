using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class RotatingArrays
    {
        static void MainR(string[] args)
        {
            string[] tokens_n = "51 51 100".Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            int q = Convert.ToInt32(tokens_n[2]);
            string[] a_temp = "39356 87674 16667 54260 43958 70429 53682 6169 87496 66190 90286 4912 44792 65142 36183 43856 77633 38902 1407 88185 80399 72940 97555 23941 96271 49288 27021 32032 75662 69161 33581 15017 56835 66599 69277 17144 37027 39310 23312 24523 5499 13597 45786 66642 95090 98320 26849 72722 37221 28255 60906".Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            k = k % n;
            IList<int> newList;
            //int[] newArray;
            if (k > 0 && k < n)
            {
                //newArray = new int[n];
                newList = new List<int>();
                int index = n - k;
                int count = 0;
 
                while (count < n)
                {
                    newList.Add(a[index++]);
                    if (index >= n)
                    {
                        index = 0;
                    }
                    count++;
                }
            }
            else
            {
                newList = a.ToList<int>();
            }

            for (int a0 = 0; a0 < q; a0++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(newList[m]);
            }
        }
    }
}
