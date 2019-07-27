using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BinarySubstrings
    {
        static void MainB(string[] args)
        {
            string str = "10101";
            Console.WriteLine(counting(str));

            #region comment
            /*
            int zeroCount = 0;
            int oneCount = 0;
            char prevChar = str[0];
            int outputCount = 0;

            foreach (char c in str.ToCharArray())
            {
                if (c != prevChar)
                {
                    outputCount++;
                    if (c == '0')
                    {
                        oneCount--;
                        if (zeroCount > 0)
                        {
                            zeroCount = 0;
                        }
                    }
                    else if (c == '1')
                    {
                        zeroCount--;
                        if (oneCount > 0)
                        {
                            oneCount = 0;
                        }
                    }
                }
                else
                {
                    if (c == '0')
                    {
                        if (oneCount > 0)
                        {
                            outputCount++;
                            oneCount--;
                        }
                    }
                    else if (c == '1')
                    {
                        if (zeroCount > 0)
                        {
                            outputCount++;
                            zeroCount--;
                        }
                    }
                }
                if (c == '0')
                {
                    zeroCount++;
                }
                else if (c == '1')
                {
                    oneCount++;
                }

                prevChar = c;
            }

            Console.Write(outputCount); */
            #endregion
            Console.ReadLine();
        }

        static int counting(string s)
        {
            int zeroCount = 0;
            int oneCount = 0;
            char prevChar = s[0];
            int outputCount = 0;

            foreach (char c in s.ToCharArray())
            {
                if (c != prevChar)
                {
                    outputCount++;
                    if (c == '0')
                    {
                        oneCount--;
                        if (zeroCount > 0)
                        {
                            zeroCount = 0;
                        }
                    }
                    else if (c == '1')
                    {
                        zeroCount--;
                        if (oneCount > 0)
                        {
                            oneCount = 0;
                        }
                    }
                }
                else
                {
                    if (c == '0')
                    {
                        if (oneCount > 0)
                        {
                            outputCount++;
                            oneCount--;
                        }
                    }
                    else if (c == '1')
                    {
                        if (zeroCount > 0)
                        {
                            outputCount++;
                            zeroCount--;
                        }
                    }
                }
                if (c == '0')
                {
                    zeroCount++;
                }
                else if (c == '1')
                {
                    oneCount++;
                }

                prevChar = c;
            }
            return outputCount;
        }
    }

}
