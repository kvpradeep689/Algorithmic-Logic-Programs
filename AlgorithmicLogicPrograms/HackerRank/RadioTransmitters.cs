using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.HackerRank
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/hackerland-radio-transmitters
    /// </summary>
    public class RadioTransmitters
    {
        public static void RadioTransmittersCount()
        {
            Console.WriteLine(FindTransistorCount(5, 1, new string[] { "1", "2", "3", "4", "5" }));
            Console.WriteLine(FindTransistorCount(8, 2, new string[] { "7", "2", "4", "6", "5", "9", "12", "11" }));
        }

        private static int FindTransistorCount(int n, int k, string[] x_temp)
        {
            //string[] tokens_n = Console.ReadLine().Split(' ');
            //int n = Convert.ToInt32(tokens_n[0]);
            //int k = Convert.ToInt32(tokens_n[1]);
            //string[] x_temp = Console.ReadLine().Split(' ');
            int[] x = Array.ConvertAll(x_temp, Int32.Parse);
            int max = 0;
            foreach (int i in x)
            {
                if (max < i)
                {
                    max = i;
                }
            }
            bool[] houses = new bool[max + 1];
            foreach (int i in x)
            {
                houses[i] = true;
            }
            int transmittors = 0;
            int lastCovered = 0;
            int currentCovered = 0;
            for (int i = 1; i <= max; i++)
            {
                if (houses[i])
                {
                    currentCovered = i;
                    if (lastCovered + k < i)
                    {
                        lastCovered = currentCovered;
                        i += k - 1;
                        transmittors++;
                    }
                }
                else
                {
                    if (lastCovered + k < i)
                    {
                        lastCovered = currentCovered;
                    }
                }
            }

            if(currentCovered > lastCovered + (2 * k) + 1)
            {
                transmittors++;
            }

            return transmittors;
        }
    }
}
