using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// https://www.hackerrank.com/contests/world-codesprint-8/challenges/prime-digit-sums
    /// </summary>
    public class PrimeDigitSums
    {
        static HashSet<uint> primeNumbers;
        static HashSet<uint> nDigitPrimes;
        
        public static void FindSpecialNumbers()
        {
            uint q = Convert.ToUInt32(Console.ReadLine());
            primeNumbers = new HashSet<uint>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47 };
            nDigitPrimes = FindNDigitPrime(5);

            for (uint count = 0; count < q; count++)
            {
                uint numberOfDigits = Convert.ToUInt32(Console.ReadLine());
                DateTime start = DateTime.Now;
                uint startNum = (uint)Math.Pow(10, numberOfDigits - 1);
                uint endNum = (uint)Math.Pow(10, numberOfDigits) - 1;
                Console.WriteLine(CountNumberOfSpecialNumbers(startNum, endNum, numberOfDigits));
                DateTime end = DateTime.Now;
                Console.WriteLine((end - start).ToString());
            }
        }

        private static uint CountNumberOfSpecialNumbers(uint startNum, uint endNum, uint numberOfDigits)
        {
            uint count = 0;

            uint nextNumber;
            for (uint i = startNum; i <= endNum; i++)
            {
                if (CheckNDigitNumbers(i, numberOfDigits, 3, out nextNumber) &&
                    CheckNDigitNumbers(i, numberOfDigits, 4, out nextNumber) &&
                    CheckNDigitNumbers(i, numberOfDigits, 5, out nextNumber))
                {
                    //Console.WriteLine(i);
                    count++;
                }

                if (nextNumber > 0)
                {
                    i = nextNumber - 1;
                }
            }

            return count;
        }

        private static bool CheckNDigitNumbers(uint number, uint totalNumOfDigits, uint digitsToCheck, out uint nextNumber)
        {
            nextNumber = 0;
            bool isValid = true;
            uint originalNumber = number;
            for(uint i = 0; i <= totalNumOfDigits - digitsToCheck; i++)
            {
                uint divideBy = (uint)Math.Pow(10, totalNumOfDigits - digitsToCheck - i);
                uint modBy = (uint)Math.Pow(10, totalNumOfDigits - i);

                number = originalNumber;
                number %= modBy;
                number /= divideBy;

                if (!nDigitPrimes.Contains(number))
                {
                    nextNumber = (originalNumber / divideBy + 1) * (uint)Math.Pow(10, totalNumOfDigits - digitsToCheck - i);
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }

        private static HashSet<uint> FindNDigitPrime(uint maxDigits)
        {
            HashSet<uint> hash = new HashSet<uint>();
            for (uint numberOfDigits = 1; numberOfDigits <= maxDigits; numberOfDigits++)
            {
                uint startNum = (uint)Math.Pow(10, numberOfDigits - 1);
                uint endNum = (uint)Math.Pow(10, numberOfDigits) - 1;
                
                for (uint i = startNum; i <= endNum; i++)
                {
                    if (IsSumOfDigitsPrime(i))
                    {
                        hash.Add(i);
                    }
                }
            }
            return hash;
        }

        static bool IsSumOfDigitsPrime(uint num)
        {
            uint total = 0;
            while (num != 0)
            {
                total += num % 10;
                num /= 10;
            }
            return primeNumbers.Contains(total);
        }

    }
}
