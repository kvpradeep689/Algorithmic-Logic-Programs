using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class WordBackground
    {
        public static void FindArea()
        {
            string[] h_temp = "1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5".Split(' ');
            int[] h = Array.ConvertAll(h_temp, Int32.Parse);
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Dictionary<char, int> charHeight = new Dictionary<char, int>();
            for (int i = 0; i < 26; i++)
            {
                charHeight.Add(alphabet[i], h[i]);
            }
            string word = "abc";
            int maxHeight = 0;
            word.ToCharArray().ToList().ForEach(c => {
                if (maxHeight < charHeight[c])
                    maxHeight = charHeight[c];
            });
            Console.Write(word.Length * maxHeight);
        }
    }
}
