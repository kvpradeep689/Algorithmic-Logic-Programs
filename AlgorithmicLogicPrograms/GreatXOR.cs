using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class GreatXOR
    {
        public static void FindXORCount()
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                long x = Convert.ToInt64(Console.ReadLine());
                string binaryNumberString = Convert.ToString(x, 2);
                int length = binaryNumberString.Length;
                long count = 0;
                for(int i = 0; i < length; i++)
                {
                    if(binaryNumberString[i] == '0')
                    {
                        count += (long)Math.Pow(2, length - i - 1);
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}
