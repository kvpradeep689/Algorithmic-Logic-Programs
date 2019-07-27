using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.CodeFights
{
    public static class _02052017
    {
        public static void Method1()
        {
            thueMorseSequence(1);
            thueMorseSequence(5);
            thueMorseSequence(7);
        }

        static int thueMorseSequence(int n)
        {

            int currentLength = 1;
            bool needComplement = false;

            while (currentLength < n)
            {
                currentLength *= 2;
            }
            while (currentLength > 1)
            {
                if (n > currentLength / 2)
                {
                    n -= currentLength / 2;
                    needComplement = !needComplement;
                }
                currentLength /= 2;
            }

            if (needComplement)
            {
                return 1;
            }
            return 0;
        }
    }
}
