using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetCode.July
{
    /// <summary>
    /// https://leetcode.com/explore/challenge/card/july-leetcoding-challenge/544/week-1-july-1st-july-7th/3380/
    /// </summary>
    public class UglyNumberII
    {
        public static void Run()
        {
            UglyNumberII un = new UglyNumberII();
            Console.WriteLine(un.NthUglyNumber(1));
            Console.WriteLine(un.NthUglyNumber(10));
            Console.WriteLine(un.NthUglyNumber(12));
            Console.WriteLine(un.NthUglyNumber(1689));
        }

        class UglyIndeces
        {
            private Queue<int> l2Queue;
            private Queue<int> l3Queue;
            private Queue<int> l5Queue;
            private int l2 = 2;
            private int l3 = 3;
            private int l5 = 5;

            public UglyIndeces()
            {
                l2Queue = new Queue<int>();
                l3Queue = new Queue<int>();
                l5Queue = new Queue<int>();

                l2Queue.Enqueue(1);
                l3Queue.Enqueue(1);
                l5Queue.Enqueue(1);
            }
            public int PeekNextL2()
            {
                return 2 * (l2Queue.Peek());
            }
            public int PeekNextL3()
            {
                return 3 * (l3Queue.Peek());
            }
            public int PeekNextL5()
            {
                return 5 * (l5Queue.Peek());
            }
            public int GetNextL2()
            {
                if (PeekNextL2() == PeekNextL3())
                {
                    l3Queue.Dequeue();
                }
                if (PeekNextL2() == PeekNextL5())
                {
                    l5Queue.Dequeue();
                }
                l2 = 2 * l2Queue.Dequeue();
                EnqueueNextValue(l2);

                return l2;
            }
            public int GetNextL3()
            {
                if (PeekNextL3() == PeekNextL5())
                {
                    l5Queue.Dequeue();
                }
                l3 = 3 * l3Queue.Dequeue();
                EnqueueNextValue(l3);
                return l3;
            }
            public int GetNextL5()
            {
                if (PeekNextL2() == PeekNextL3())
                {
                    l3Queue.Dequeue();
                }
                if (PeekNextL2() == PeekNextL5())
                {
                    l5Queue.Dequeue();
                }
                l5 = 5 * l5Queue.Dequeue();
                EnqueueNextValue(l5);
                return l5;
            }

            private void EnqueueNextValue(int num)
            {
                l2Queue.Enqueue(num);
                l3Queue.Enqueue(num);
                l5Queue.Enqueue(num);
            }
            public int NextUglyNumber()
            {
                if (PeekNextL2() <= PeekNextL3() && PeekNextL2() <= PeekNextL5())
                {
                    return GetNextL2();
                }
                if (PeekNextL3() <= PeekNextL2() && PeekNextL3() <= PeekNextL5())
                {
                    return GetNextL3();
                }
                return GetNextL5();
            }
        }

        private int NthUglyNumber(int n)
        {
            UglyIndeces uglyIndeces = new UglyIndeces();

            if ( n == 1)
            {
                return 1;
            }

            for (int i = 2; i < n; i++)
            {
                uglyIndeces.NextUglyNumber();
                //Console.WriteLine(uglyIndeces.NextUglyNumber());
            }
            return uglyIndeces.NextUglyNumber();
        }

        //private static int NthUglyNumber(int n)
        //{
        //    int currentUglyNumber = 1;
        //    for(int i = 1; i < n; i++)
        //    {
        //        currentUglyNumber = NextUglyNumber(currentUglyNumber + 1);
        //        //Console.WriteLine(currentUglyNumber);
        //    }
        //    return currentUglyNumber;
        //}

        //private static int NextUglyNumber(int num)
        //{
        //    int backup = num;
        //    while (true)
        //    {
        //        while (num % 5 == 0)
        //        {
        //            num /= 5;
        //        }
        //        while (num % 3 == 0)
        //        {
        //            num /= 3;
        //        }
        //        while (num % 2 == 0)
        //        {
        //            num /= 2;
        //        }

        //        if (num == 1)
        //        {
        //            return backup;
        //        }
        //        num = ++backup;
        //    }
        //}

    }
}
