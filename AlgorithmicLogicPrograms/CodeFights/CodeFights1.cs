using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace ConsoleApplication1
{
    class CodeFights1
    {

        public static void RecurTasks()
        {
            string[] str;
            DateTime dt = DateTime.Now;
            str = recurringTask("01/01/2015", 2, new string[] { "Monday", "Thursday" }, 3);
            Console.WriteLine(string.Join(", ", str));
            str = recurringTask("30/05/1995", 4, new string[] { "Tuesday" }, 1);
            Console.WriteLine(string.Join(", ", str));
            str = recurringTask("22/02/2020", 1, new string[] { "Saturday" }, 2);
            Console.WriteLine(string.Join(", ", str));
            str = recurringTask("31/12/2999", 1, new string[] { "Tuesday" }, 2);
            Console.WriteLine(string.Join(", ", str));
            str = recurringTask("01/01/2015", 1, new string[] { "Monday", "Thursday" }, 15);
            Console.WriteLine(string.Join(", ", str));
            str = recurringTask("01/12/2116", 1, new string[] { "Monday", "Tuesday", "Thursday" }, 15);
            Console.WriteLine(string.Join(", ", str));
            str = recurringTask("21/02/2016", 1, new string[] { "Sunday", "Tuesday", "Thursday" }, 15);
            Console.WriteLine(string.Join(", ", str));
            Console.WriteLine((DateTime.Now - dt).Milliseconds);
        }

        static string[] recurringTask(string firstDate, int k, string[] daysOfTheWeek, int n)
        {
            //int[] date = Array.ConvertAll(firstDate.Split('/'), int.Parse);
            IList<DateTime> output = new List<DateTime>();
            DateTime dt = DateTime.ParseExact(firstDate, "dd/MM/yyyy", null);// new DateTime(date[2], date[1], date[0]);
            //string currentDay = dt.DayOfWeek.ToString();
            //IList<string> daysOfWeek = getDaysOfWeek(currentDay, daysOfTheWeek);

            //for (int i = 0; i < n;)
            //{
            //    foreach (string day in daysOfTheWeek)
            //    {
            //        if (i < n)
            //        {
            //            output.Add(findNextDay(dt, day));
            //            i++;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //    dt = dt.AddDays(7 * k);
            //}
            IList<int> diffDays = new List<int>();
            int index = Array.IndexOf(daysOfTheWeek, dt.DayOfWeek.ToString());
            int count = 0;
            while(count < daysOfTheWeek.Length)
            {
                int diff = (7 - ((int)dt.DayOfWeek - (int)Enum.Parse(typeof(DayOfWeek), daysOfTheWeek[index++]))) % 7;
                diffDays.Add(diff);
                count++;
                if(index == daysOfTheWeek.Length)
                {
                    index = 0;
                }
            }
            int[] diffArray = diffDays.ToArray();
            for (int i = 0, j = 0; i < n; i++, j++)
            {
                if (j == diffArray.Length)
                {
                    j = 0;
                    dt = dt.AddDays(7 * k);
                }
                output.Add(dt.AddDays(diffArray[j]));
                
            }

            return output.Select(cDate => cDate.ToString("dd/MM/yyyy")).ToArray();
        }

        static DateTime findNextDay(DateTime dt, string day)
        {
            int daysUntilNextDay = 0;
            switch (day.ToLower())
            {
                case "sunday":
                    daysUntilNextDay = ((int)DayOfWeek.Sunday - (int)dt.DayOfWeek + 7) % 7;
                    break;
                case "monday":
                    daysUntilNextDay = ((int)DayOfWeek.Monday - (int)dt.DayOfWeek + 7) % 7;
                    break;
                case "tuesday":
                    daysUntilNextDay = ((int)DayOfWeek.Tuesday - (int)dt.DayOfWeek + 7) % 7;
                    break;
                case "wednesday":
                    daysUntilNextDay = ((int)DayOfWeek.Wednesday - (int)dt.DayOfWeek + 7) % 7;
                    break;
                case "thursday":
                    daysUntilNextDay = ((int)DayOfWeek.Thursday - (int)dt.DayOfWeek + 7) % 7;
                    break;
                case "friday":
                    daysUntilNextDay = ((int)DayOfWeek.Friday - (int)dt.DayOfWeek + 7) % 7;
                    break;
                case "saturday":
                    daysUntilNextDay = ((int)DayOfWeek.Saturday - (int)dt.DayOfWeek + 7)
        % 7;
                    break;
            }
            return dt.AddDays(daysUntilNextDay);
        }

        static IList<string> getDaysOfWeek(string currentDay, string[] daysOfTheWeek)
        {
            int[] weekdays = new int[7];

            int index = Array.IndexOf(daysOfTheWeek, currentDay);
            IList<string> daysOfWeek = new List<string>();
            
            for (int i = 0, current = index; i < daysOfTheWeek.Length; i++)
            {
                if (current == daysOfTheWeek.Length)
                {
                    current = 0;
                }
                //weekdays[(int)((DayOfWeek)(Enum.Parse(typeof(DayOfWeek), daysOfTheWeek[current++])))] = 1;
                daysOfWeek.Add(daysOfTheWeek[current++]);
            }
            return daysOfWeek;
        }
    }
}
