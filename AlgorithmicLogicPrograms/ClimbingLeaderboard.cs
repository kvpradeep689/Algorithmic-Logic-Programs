using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ClimbingLeaderboard
    {
        public static void FindRanking()
        {
            int n = 7;
            int[] scores = new int[] { 100, 100, 50, 40, 40, 20, 10 };
            int m = 4;
            int[] alice = new int[] { 5, 25, 50, 120 };

            int[] denseRank = new int[n];
            int currentRank = 1;
            denseRank[0] = scores[0];

            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i -1] != scores[i])
                {
                    denseRank[currentRank++] = scores[i];
                }
            }
            currentRank--;
            foreach (int score in alice)
            {
                while (currentRank >= 0 && denseRank[currentRank] <= score)
                {
                    currentRank--;
                }
                Console.WriteLine(currentRank + 2);
            }
        }
    }
}
