using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetCode
{
    public static class InsertDeleteGetRandomO1
    {
        public static void Run()
        {
            RandomizedSet randomizedSet = new RandomizedSet();
            //randomizedSet.Insert(1);
            //randomizedSet.Remove(2);
            //randomizedSet.Insert(2);
            //randomizedSet.GetRandom();
            //randomizedSet.Remove(1);
            //randomizedSet.Insert(2);
            //randomizedSet.GetRandom();

            string[] operations = new string[] { "RandomizedSet", "insert", "getRandom", "getRandom", "getRandom", "insert", "insert", "insert", "insert", "insert", "getRandom", "getRandom", "insert", "getRandom", "insert", "insert", "getRandom", "getRandom", "getRandom", "getRandom", "remove", "insert", "getRandom", "getRandom", "insert", "remove", "remove", "insert", "getRandom", "getRandom", "insert", "insert", "getRandom", "remove", "remove", "insert", "remove", "getRandom", "getRandom", "remove", "getRandom", "insert", "insert", "getRandom", "remove", "remove", "remove", "getRandom", "insert", "insert", "insert", "insert", "getRandom", "insert", "getRandom", "remove", "insert", "insert", "insert", "getRandom", "getRandom", "insert", "getRandom", "insert", "insert", "getRandom", "getRandom", "remove", "getRandom", "remove", "insert", "getRandom", "insert", "insert", "insert", "getRandom", "insert", "insert", "getRandom", "insert", "getRandom", "insert", "getRandom", "getRandom", "getRandom", "insert", "getRandom", "getRandom", "insert", "insert", "insert", "getRandom", "remove", "insert", "insert", "getRandom", "insert", "insert", "insert", "insert" };
            string valuesString = "[],[-7],[],[],[],[6],[7],[10],[3],[8],[],[],[-8],[],[6],[-8],[],[],[],[],[2],[2],[],[],[5],[-5],[-8],[-8],[],[],[-4],[10],[],[7],[-1],[8],[-6],[],[],[9],[],[7],[0],[],[-10],[-4],[-3],[],[-4],[-5],[8],[-2],[],[-9],[],[7],[-2],[7],[4],[],[],[-6],[],[-8],[2],[],[],[9],[],[-1],[3],[],[0],[-3],[-1],[],[-8],[-10],[],[3],[],[4],[],[],[],[-10],[],[],[0],[-2],[5],[],[-2],[5],[10],[],[9],[0],[7],[-2]";
            string[] values = valuesString.Replace("[", "").Replace("]", "").Split(',');

            for(int i = 0; i < operations.Length; i++)
            {
                switch (operations[i])
                {
                    case "RandomizedSet":
                        randomizedSet = new RandomizedSet();
                        Console.Write("null");
                        break;
                    case "insert":
                        Console.Write(randomizedSet.Insert(int.Parse(values[i])));
                        break;
                    case "remove":
                        Console.Write(randomizedSet.Remove(int.Parse(values[i])));
                        break;
                    case "getRandom":
                        Console.Write(randomizedSet.GetRandom());
                        break;
                    default:
                        break;
                }
                Console.Write(",");
            }
        }
        private class RandomizedSet
        {
            List<int> list;
            Dictionary<int, int> dict;
            Random random;
            /** Initialize your data structure here. */
            public RandomizedSet()
            {
                list = new List<int>();
                dict = new Dictionary<int, int>();
                random = new Random();
            }

            /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
            public bool Insert(int val)
            {
                if (dict.ContainsKey(val))
                {
                    dict.Add(val, list.Count);
                    list.Add(val);
                    return true;
                }
                return false;
            }

            /** Removes a value from the set. Returns true if the set contained the specified element. */
            public bool Remove(int val)
            {
                int valIndex;
                if (dict.TryGetValue(val, out valIndex))
                {
                    //Cache current last element in set.
                    int lastIndexInSet = list.Count - 1;
                    int lastElement = list[lastIndexInSet];
                    //Move val to be removed to last in set.
                    dict[val] = lastIndexInSet;
                    list[lastIndexInSet] = val;
                    //Move cached last element to where the val to be removed was before it was move to last.
                    list[valIndex] = lastElement;
                    dict[lastElement] = valIndex;
                    //Remove the last element from the set.
                    list.RemoveAt(list.Count - 1);
                    dict.Remove(val);
                    return true;
                }
                return false;
            }

            /** Get a random element from the set. */
            public int GetRandom()
            {
                return list[random.Next(list.Count)];
            }
        }

        /**
         * Your RandomizedSet object will be instantiated and called as such:
         * RandomizedSet obj = new RandomizedSet();
         * bool param_1 = obj.Insert(val);
         * bool param_2 = obj.Remove(val);
         * int param_3 = obj.GetRandom();
         */
    }
}
