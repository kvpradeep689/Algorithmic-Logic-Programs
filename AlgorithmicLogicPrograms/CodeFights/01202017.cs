using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.CodeFights
{
    public class _01202017
    {
        public static void ChessHorseMoves()
        {
            FindNumberofPossibleHorseMoves("a1");
            FindNumberofPossibleHorseMoves("c2");
            FindNumberofPossibleHorseMoves("c3");
            FindNumberofPossibleHorseMoves("h8");
            FindNumberofPossibleHorseMoves("g7");
            FindNumberofPossibleHorseMoves("e4");
            FindNumberofPossibleHorseMoves("h1");
        }

        private static void FindNumberofPossibleHorseMoves(string v)
        {
            int col = v[0] - 'a' + 1;
            int row = int.Parse(v[1].ToString());
            int possibilities = 8;
            int topLeftCol = col - 2;
            //int topLeft
        }
    }
}
