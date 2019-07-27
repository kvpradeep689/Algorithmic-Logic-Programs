using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CodeFights2
    {
        public static void ProcessFights()
        {
            //Console.WriteLine(factorialsProductTrailingZeros(5, 7));
            primeSum(9, 3);
        }

        static bool primeSum(int n, int k)
        {

            ArrayList primes = new ArrayList();
            for (int i = 2; i <= n; i++)
            {
                bool ok = true;
                foreach (int p in primes)
                {
                    if (i % p == 0)
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok)
                {
                    primes.Add(i);
                }
            }

            // dp[A][B] is true if number A can be represented
            // as a sum of B prime numbers
            // and false otherwise
            bool[,] dp = new bool[n + 1, k+1];
            
            dp[0,0] = true;
            for (int b = 1; b <= k; b++)
            {
                for (int a = 2; a <= n; a++)
                {
                    foreach (int p in primes)
                    {
                        if (a - b >= 0 && dp[a - p,b])
                        {
                            dp[a,b] = true;
                        }
                    }
                }
            }

            return dp[n,k];
        }

        static int factorialsProductTrailingZeros(int l, int r)
        {
            int result = 0,
                last = 0;
            for (int i = 1; i <= r; i++)
            {
                int number = i;
                while (number % 5 == 0)
                {
                    number /= 5;
                    last++;
                }
                if (i >= l)
                {
                    result += last;
                }
            }
            return result;
        }
    }
}
