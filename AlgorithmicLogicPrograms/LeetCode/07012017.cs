using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetCode
{
    public class _07012017
    {
        public static void JudgeSquareSumCall()
        {
            //Console.WriteLine(JudgeSquareSum(0));

            //Console.WriteLine(JudgeSquareSum(5));

            //Console.WriteLine(JudgeSquareSum(4));

            //Console.WriteLine(JudgeSquareSum(2));
            //Console.WriteLine(JudgeSquareSum(6));
            //Console.WriteLine(JudgeSquareSum(999999999));
            //Console.WriteLine(JudgeSquareSum(1745882472));

            LogSystem ls = new LogSystem();
            ls.Put(1, "2017:01:01:23:59:59");
            ls.Put(2, "2017:01:01:22:59:59");
            ls.Put(3, "2016:01:01:00:00:00");
            Console.WriteLine(ls.Retrieve("2016:01:01:01:01:01", "2017:01:01:23:00:00", "Year")); // return [1,2,3], because you need to return all logs within 2016 and 2017.
            Console.WriteLine(ls.Retrieve("2016:01:01:01:01:01", "2017:01:01:23:00:00", "Hour"));
        }


        public static bool JudgeSquareSum(int c)
        {
            bool isSquareSum = false;
            int upLimit = (int)Math.Floor(Math.Sqrt(c));
            int[] squares = new int[upLimit];
            for(int i = 0; i < upLimit; i++)
            {
                squares[i] = (int) Math.Pow(i + 1, 2);
            }
            if (c == 0 || squares[upLimit - 1] == c)
            {
                isSquareSum = true;
            }

            int lowLimit = 1;
            while(!isSquareSum && lowLimit <= upLimit)
            {
                int sum = squares[lowLimit - 1] + squares[upLimit - 1];
                if (sum == c)
                {
                    isSquareSum = true;
                }
                else if (sum < c)
                {
                    lowLimit++;
                }
                else if (sum > c)
                {
                    upLimit--;
                    //lowLimit = 1;
                } 
            }

            return isSquareSum;
        }

        public class LogSystem
        {
            IDictionary<DateTime, int> logEntries;
            public LogSystem()
            {
                logEntries = new Dictionary<DateTime, int>();
            }

            public void Put(int id, string timestamp)
            {
                int[] values = Array.ConvertAll(timestamp.Split(':'), int.Parse);
                DateTime newEntry = new DateTime(values[0], values[1], values[2], values[3], values[4], values[5]);
                logEntries.Add(newEntry, id);
            }

            public IList<int> Retrieve(string s, string e, string gra)
            {
                int[] startValues = Array.ConvertAll(s.Split(':'), int.Parse);
                int[] endValues = Array.ConvertAll(e.Split(':'), int.Parse);
                DateTime startDate = DateTime.MinValue;
                DateTime endDate = DateTime.MinValue;

                switch (gra)
                {
                    case "Year":
                        startDate = new DateTime(startValues[0], 1, 1, 0, 0, 0);
                        endDate = new DateTime(endValues[0], 12, 31, 23, 59, 59);
                        break;
                    case "Month":
                        startDate = new DateTime(startValues[0], startValues[1], 1, 0, 0, 0);
                        endDate = new DateTime(endValues[0], endValues[1], DateTime.DaysInMonth(endValues[0], endValues[1]), 23, 59, 59);
                        break;
                    case "Day":
                        startDate = new DateTime(startValues[0], startValues[1], startValues[2], 0, 0, 0);
                        endDate = new DateTime(endValues[0], endValues[1], endValues[2], 23, 59, 59);
                        break;
                    case "Hour":
                        startDate = new DateTime(startValues[0], startValues[1], startValues[2], startValues[3], 0, 0);
                        endDate = new DateTime(endValues[0], endValues[1], endValues[2], endValues[3], 59, 59);
                        break;
                    case "Minute":
                        startDate = new DateTime(startValues[0], startValues[1], startValues[2], startValues[3], startValues[4], 0);
                        endDate = new DateTime(endValues[0], endValues[1], endValues[2], endValues[3], endValues[4], 59);
                        break;
                    case "Second":
                        startDate = new DateTime(startValues[0], startValues[1], startValues[2], startValues[3], startValues[4], startValues[5]);
                        endDate = new DateTime(endValues[0], endValues[1], endValues[2], endValues[3], endValues[4], endValues[5]);
                        break;
                }
                IList<int> indexes = new List<int>();
                foreach(var entry in logEntries)
                {
                    if (entry.Key >= startDate && entry.Key <= endDate)
                    {
                        indexes.Add(entry.Value);
                    }
                }

                return indexes;
            }
        }
    }
}
