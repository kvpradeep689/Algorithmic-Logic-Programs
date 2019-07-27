using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.GraphTheory
{
    /*
    public class Node
    {
        public int count = 1;
        public long data = 0;
        public Node parent = null;
    }
    */
    public class ValueOfFreindship
    {
        private static int[] inputsMN;
        private static string[] links;

        public static void FindCombinations2()
        {
            //int[] input = Array.ConvertAll("100 70".Split(' '), int.Parse);
            //string[] links = new string[] { "0 11", "2 4", "2 95", "3 48", "4 85", "4 95", "5 67", "5 83", "5 42", "6 76", "9 31", "9 22", "9 55", "10 61", "10 38", "11 96", "11 41", "12 60", "12 69", "14 80", "14 99", "14 46", "15 42", "15 75", "16 87", "16 71", "18 99", "18 44", "19 26", "19 59", "19 60", "20 89", "21 69", "22 96", "22 60", "23 88", "24 73", "27 29", "30 32", "31 62", "32 71", "33 43", "33 47", "35 51", "35 75", "37 89", "37 95", "38 83", "39 53", "41 84", "42 76", "44 85", "45 47", "46 65", "47 49", "47 94", "50 55", "51 99", "53 99", "56 78", "66 99", "71 78", "73 98", "76 88", "78 97", "80 90", "83 95", "85 92", "88 99", "88 94" };
            int q = int.Parse(Console.ReadLine());
            int[] input = Array.ConvertAll("5 4".Split(' '), int.Parse);
            string[] links = new string[] { "1 2", "3 2", "4 2", "4 3" };
            int n = input[0];
            int m = input[1];
            Node[] nodes = new Node[n];
            IList<Node> heads = new List<Node>();
            long totalCombinations = 0;
            for (int j = 0; j < n; j++)
            {
                nodes[j] = new Node();
                nodes[j].data = j;
                nodes[j].parent = nodes[j];
            }
            for (int j = 0; j < m; j++)
            {
                input = Array.ConvertAll(links[j].Split(' '), int.Parse);
                AddLink(nodes, totalCombinations, input[0], input[1]);
                foreach(Node node in heads)
                {
                    totalCombinations += (node.count * (node.count - 1));
                }
            }
            Console.WriteLine(totalCombinations);
            /*int sum = 0;
            long totalCombinations = 0;
            /*foreach (Node node in nodes)
            {
                Node temp = node;
                //Console.Write(temp.data + ": ");
                do
                {
                    Console.Write(temp.data + ", ");
                    temp = temp.parent;
                } while (temp.parent != temp);
                //Console.Write(temp.data);
                //Console.WriteLine(" - " + node.count);
            }
            foreach (Node node in nodes)
            {
                if (node.count != 0)
                {
                    //Console.WriteLine(node.data + " - " + node.count);
                    totalCombinations += sum * node.count;
                    sum += node.count;
                }
            }*/
            //Console.WriteLine(sum);
        }

        private static void ReadInputFile()
        {
            using (StreamReader file = new StreamReader(@"GraphTheory\ValueOfFriendshipInput.txt"))
            {
                string line;
                int q = int.Parse(file.ReadLine());
                inputsMN = Array.ConvertAll(file.ReadLine().Split(' '), int.Parse);
                links = new string[inputsMN[1]];
                int index = 0;
                while ((line = file.ReadLine()) != null)
                {
                    links[index] = line;
                    index++;
                }
            }
        }

        public static void FindCombinations()
        {
            inputsMN = new int[] { 5, 3 };
            links = new string[] { "1 2", "3 4", "4 5" };
            Console.Write("16: ");
            FindCombinationsOutput();

            inputsMN = new int[] { 8, 8 };
            links = new string[] { "1 2", "2 3", "3 4", "5 6", "7 8", "7 6", "5 4", "8 1" };
            Console.Write("224: ");
            FindCombinationsOutput();

            inputsMN = new int[] { 10, 13 };
            links = new string[] { "5 7", "7 3", "9 5", "2 9", "9 7", "7 8", "9 8", "7 1", "10 2", "10 8", "9 5", "7 5", "2 9" };
            Console.Write("504: ");
            FindCombinationsOutput();

            inputsMN = new int[] { 5, 4 };
            links = new string[] { "1 2", "3 2", "4 2", "4 3" };
            Console.Write("24: ");
            FindCombinationsOutput();

            inputsMN = new int[] { 1, 0 };
            links = new string[] { };
            Console.Write("0: ");
            FindCombinationsOutput();

            inputsMN = new int[] { 2, 1 };
            links = new string[] { "1 2" };
            Console.Write("2: ");
            FindCombinationsOutput();

            ReadInputFile();
            Console.Write("194991399930000: ");
            FindCombinationsOutput();
        }

        private static void FindCombinationsOutput()
        {
            //int t = Convert.ToInt32(Console.ReadLine());
            int t = 1;
            SortedList<int, int> counts = new SortedList<int, int>();
            for (int a0 = 0; a0 < t; a0++)
            {
                //int[] inputsMN = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int n = inputsMN[0];
                int m = inputsMN[1];
                Node[] nodes = new Node[n];
                long totalCombinations = 0;
                long currentVal = 0;
                for (int j = 0; j < n; j++)
                {
                    nodes[j] = new Node();
                    nodes[j].data = j;
                    nodes[j].parent = nodes[j];
                }
                for (int a1 = 0; a1 < m; a1++)
                {
                    //int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    int[] input = Array.ConvertAll(links[a1].Split(' '), int.Parse);
                    currentVal = AddLink(nodes, currentVal, input[0] - 1, input[1] - 1);
                    totalCombinations += currentVal;
                }
                Console.WriteLine(totalCombinations);
                totalCombinations = 0;
                foreach (Node node in nodes)
                {
                    if (node.count > 1)
                        counts.Add(node.count, node.count);
                }
                int prevVal = 0;
                foreach(var kvp in counts.Reverse())
                {
                    int sum = (prevVal * (kvp.Key - 1)) + (((kvp.Key - 1) * (kvp.Key) * (kvp.Key + 1)) / 3);
                    totalCombinations += sum;
                    prevVal = (kvp.Key - 1) * (kvp.Key);
                }
                Console.WriteLine(totalCombinations);
            }
        }

        private static long AddLink(Node[] nodes, long currentVal, int val1, int val2)
        {
            Node parent1 = nodes[val1];
            while (parent1 != parent1.parent)
            {
                parent1 = parent1.parent;
            }
            Node parent2 = nodes[val2];
            while (parent2 != parent2.parent)
            {
                parent2 = parent2.parent;
            }
            if (parent1 != parent2)
            {
                currentVal -= (long)parent2.count * ((long)parent2.count - 1);
                currentVal -= (long)parent1.count * ((long)parent1.count - 1);
                parent2.parent = parent1;
                parent1.count += parent2.count;
                parent2.count = 0;
                currentVal += (long)parent1.count * ((long)parent1.count - 1);
            }
            return currentVal;
        }
    }
}
