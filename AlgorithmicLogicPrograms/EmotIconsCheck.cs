using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class EmotIconsCheck
    {
        static void CheckEmotIcons()
        {
            using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    
                    if (AreParanthesesBalanced(line))
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
        }

        private static bool AreParanthesesBalanced(string line)
        {
            bool isValid = true;
            int openParanthesesCount = 0;
            int balancedCount = 0;
            char previousChar = ' ';

            foreach (char c in line)
            {
                //if (previousChar == ':')
                //{
                //    previousChar = c;
                //    continue;
                //}
                if (c == '(')
                {
                    if (previousChar != ':')
                        openParanthesesCount++;
                    balancedCount++;
                }
                else if (c == ')')
                {
                    openParanthesesCount = openParanthesesCount - 1 > 0 ? openParanthesesCount - 1 : 0;
                    balancedCount--;

                    if (previousChar != ':' && balancedCount < 0)
                    {
                        isValid = false;
                        break;
                    }
                }
                previousChar = c;
            }

            if (!isValid)
            {
                isValid = openParanthesesCount == 0 && balancedCount >= 0;
            }
            return isValid;
        }
    }
}
