using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.HoneyWell
{
    public class FibonacciZipFiles
    {
        static int[] fibonacciNumbers = new int[] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987 };
        //private IList<int> fibonacciNumbers = new List<int>();

        //public IList<int> FibonacciNumbers
        //{
        //    get
        //    {
        //        return fibonacciNumbers;
        //    }
        //}

        public static void ZipText()
        {
            Console.WriteLine((int)'a' + ": " + ConvertCharToFibonacciSequence('a'));
            Console.WriteLine((int)'b' + ": " + ConvertCharToFibonacciSequence('b'));
            Console.WriteLine((int)'c' + ": " + ConvertCharToFibonacciSequence('c'));
            Console.WriteLine((int)'d' + ": " + ConvertCharToFibonacciSequence('d'));
            Console.WriteLine((int)'e' + ": " + ConvertCharToFibonacciSequence('e'));
        }

        private static string ConvertCharToFibonacciSequence(char ch)
        {
            string output = string.Empty;
            int index = 0;
            while(ch >= fibonacciNumbers[index])
            {
                index++;
            }
            int length = index;
            index--;
            int value = (int)ch;
            while(value > 0)
            {
                if(value - fibonacciNumbers[index] >= 0)
                {
                    value -= fibonacciNumbers[index];
                    output = "1" + output;
                }
                else
                {
                    output = "0" + output;
                }
                index--;
            }
            return output.PadLeft(length, '0');
        }

        private static char ConvertFibonacciSequenceToChar(string sequence)
        {
            char ch = ' ';
            int index = 0;
            int total = 0;
            foreach(char c in sequence.ToCharArray())
            {
                if(c == '1')
                {
                    total += fibonacciNumbers[index];
                }
                index++;
            }
            return (char)total;
        }
    }
}
