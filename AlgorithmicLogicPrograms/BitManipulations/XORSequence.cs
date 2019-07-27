using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class XORSequence
    {
        public static void ProcessXORSequence()
        {
            int Q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < Q; a0++)
            {
                string[] tokens_L = Console.ReadLine().Split(' ');
                long L = Convert.ToInt64(tokens_L[0]);
                long R = Convert.ToInt64(tokens_L[1]);
                Console.WriteLine(getArrayVal(L - 1) ^ getArrayVal(R));
            }
        }

        static long getArrayVal(long index)
        {
            long mod = index % 8;
            long returnVal = 0;
            switch (mod)
            {
                case 0:
                case 1:
                    returnVal = index;
                    break;
                case 2:
                case 3:
                    returnVal = 2;
                    break;
                case 4:
                case 5:
                    returnVal = index + 2;
                    break;
                case 6:
                case 7:
                    returnVal = 0;
                    break;
            }
            return returnVal;
        }

        /*
        public static void ProcessXORSequence()
        {
            int Q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < Q; a0++)
            {
                long output = 0;
                string[] tokens_L = Console.ReadLine().Split(' ');
                long L = Convert.ToInt64(tokens_L[0]);
                long R = Convert.ToInt64(tokens_L[1]);
                if (R - L <= 4)
                {
                    for (long count = L; count <= R; count++)
                    {
                        output ^= getArrayVal(count);
                    }
                }
                else
                {
                    long lowEnd = L + ((L + 4) % 4) - 1;
                    long highEnd = R - (R % 4);
                    if ((highEnd - lowEnd) % 8 != 0)
                    {
                        highEnd = highEnd - 4;
                    }
                    for (long count = L; count <= lowEnd; count++)
                    {
                        output ^= getArrayVal(count);
                    }
                    for (long count = highEnd; count <= R; count++)
                    {
                        output ^= getArrayVal(count);
                    }
                }
                Console.WriteLine(output);
            }
        }

        static long getArrayVal(long index)
        {
            long mod = index % 4;
            long returnVal = 0;
            switch (mod)
            {
                case 0:
                    returnVal = index;
                    break;
                case 1:
                    returnVal = 1;
                    break;
                case 2:
                    returnVal = index + 1;
                    break;
                case 3:
                    returnVal = 0;
                    break;
            }
            return returnVal;
        }
         */
    }
}
