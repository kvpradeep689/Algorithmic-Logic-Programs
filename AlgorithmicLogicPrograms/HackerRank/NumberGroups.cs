using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.HackerRank
{
    class NumberGroups
    {
        static long sumOfGroup(int k)
        {
            long startNum = (long) k * (k - 1) + 1;
            return k * startNum + k * (k - 1);
        }

        public static void CalcualteGroupTotal()
        {
            //int k = Convert.ToInt32(Console.ReadLine());
            long answer = sumOfGroup(1000000);
            Console.WriteLine(answer);
        }
    }
}
