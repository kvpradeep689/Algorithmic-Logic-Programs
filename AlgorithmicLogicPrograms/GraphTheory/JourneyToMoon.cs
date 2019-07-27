using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.GraphTheory
{
    class Node
    {
        public int count = 1;
        public long data = 0;
        public Node parent = null;
    }

    public class JourneyToMoon
    {
        public static void FindCombinations()
        {
            int[] input = Array.ConvertAll("100 70".Split(' '), int.Parse);
            string[] links = new string[] { "0 11", "2 4", "2 95", "3 48", "4 85", "4 95", "5 67", "5 83", "5 42", "6 76", "9 31", "9 22", "9 55", "10 61", "10 38", "11 96", "11 41", "12 60", "12 69", "14 80", "14 99", "14 46", "15 42", "15 75", "16 87", "16 71", "18 99", "18 44", "19 26", "19 59", "19 60", "20 89", "21 69", "22 96", "22 60", "23 88", "24 73", "27 29", "30 32", "31 62", "32 71", "33 43", "33 47", "35 51", "35 75", "37 89", "37 95", "38 83", "39 53", "41 84", "42 76", "44 85", "45 47", "46 65", "47 49", "47 94", "50 55", "51 99", "53 99", "56 78", "66 99", "71 78", "73 98", "76 88", "78 97", "80 90", "83 95", "85 92", "88 99", "88 94" };
            int n = input[0];
            int i = input[1];
            Node[] nodes = new Node[n];
            for (int j = 0; j < n; j++)
            {
                nodes[j] = new Node();
                nodes[j].data = j;
                nodes[j].parent = nodes[j];
            }
            for (int j = 0; j < i; j++)
            {
                input = Array.ConvertAll(links[j].Split(' '), int.Parse);
                AddLink(nodes, input[0], input[1]);
            }
            int sum = 0;
            long totalCombinations = 0;
            foreach (Node node in nodes)
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
                if(node.count != 0)
                {
                    //Console.WriteLine(node.data + " - " + node.count);
                    totalCombinations += sum * node.count;
                    sum += node.count;
                }
            }
            //Console.WriteLine(sum);
            Console.WriteLine(totalCombinations);
        }

        private static void AddLink(Node[] nodes, int val1, int val2)
        {
            Node parent1 = nodes[val1];
            while (parent1 != parent1.parent)
            {
                parent1 = parent1.parent;
            }
            Node parent2 = nodes[val2];
            while(parent2 != parent2.parent)
            {
                parent2 = parent2.parent;
            }
            if (parent1 != parent2)
            {
                parent2.parent = parent1;
                parent1.count += parent2.count;
                parent2.count = 0;
            }
        }
    }
}
