using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class LexographicalBiggerItems
    {
        public static void FindNextBigItem()
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Dictionary<char, int> chars = new Dictionary<char, int>();
            for (int i = 0; i < alphabet.Length; i++)
            {
                chars.Add(alphabet[i], i);
            }
            string[] lines = File.ReadAllLines(@"C:\Users\kvpra\Documents\Visual Studio 2015\Projects\ConsoleApplication1\ConsoleApplication1\InputFiles\LexographicalBiggerItems.txt");
            using (StreamWriter outputFile = new StreamWriter(@"C:\Users\kvpra\Documents\Visual Studio 2015\Projects\ConsoleApplication1\ConsoleApplication1\InputFiles\LexographicalBiggerItemsOutput.txt"))
            {
                foreach (string line in lines)
                {
                    outputFile.WriteLine(GenerateNexItem(chars, line));
                }
            }

            //GenerateNexItem(chars, "zyyxwwtrrnmlggfeb");
        }

        private static string GenerateNexItem(Dictionary<char, int> chars, string line)
        {
            string output = "no answer";
            string word = line;
            List<char> charsList = new List<char>();
            int index = word.Length - 1;
            while (index > 0 && chars[word[index]] <= chars[word[index - 1]])
            {
                charsList.Add(word[index]);
                index--;
            }
            charsList.Add(word[index--]);
            string firstPart = string.Empty;
            string lastPart = string.Empty;
            if (index >= 0)
            {
                charsList.Add(word[index]);
                charsList.Sort();
                char nextLead = word[index];

                firstPart = word.Substring(0, index);
                bool alreadyProcessed = false;
                charsList.ForEach(c =>
                {
                    if (!alreadyProcessed && chars[c] > chars[word[index]] && nextLead != c)
                    {
                        nextLead = c;
                        lastPart = nextLead.ToString() + lastPart;
                        alreadyProcessed = true;
                    }
                    else
                    {
                        lastPart += c.ToString();
                    }
                });
            }
            if (word != firstPart + lastPart && firstPart + lastPart != string.Empty)
            {
                return firstPart + lastPart;
            }
            else
            {
                return output;
            }
        }
    }
}
