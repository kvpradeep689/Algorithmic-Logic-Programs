using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class DoCircleExist
    {
        public static void CheckPath()
        {
            string[] resutls = doesCircleExist(new string[] { "G", "L", "GRGL" });
            resutls.ToList().ForEach(res => Console.WriteLine(res));
        }

        enum Direction { None, North, East, West, South };

        static string[] doesCircleExist(string[] commands)
        {
            string[] results = new string[commands.Length];
            int centerVisitCount = 0;
            for (int i = 0; i < commands.Length; i++)
            {
                results[i] = "YES";
                int x = 0;
                int y = 0;
                Direction currentDirection = Direction.East;
                int index = 0;
                string newPath = commands[i];
                foreach (char command in commands[i])
                {
                    MakeMove(ref x, ref y, ref currentDirection, command);
                    if (x == 0 && y == 0 && index > 0)
                    {
                        centerVisitCount++;
                        newPath = commands[i].Substring(index);
                    }
                    index++;
                }
                if (x!=0 && y!=0)
                {
                    results[i] = "NO";
                }
                if (newPath != commands[i])
                {
                    x = 0; y = 0;
                    int prevX = 0; int prevY = 0;
                    index = 0;
                    while (x != 0 && y != 0)
                    {
                        if (index > 0 && prevX > x && prevY > y)
                        {
                            results[i] = "NO";
                            break;
                        }
                        foreach (char command in newPath)
                        {
                            MakeMove(ref x, ref y, ref currentDirection, command);
                        }

                        prevX = x; prevY = y;
                        index++;
                    }
                }
            }
            return results;
        }

        private static void MakeMove(ref int x, ref int y, ref Direction currentDirection, char command)
        {
            switch (command)
            {
                case 'G':
                    if (currentDirection == Direction.East)
                        x++;
                    if (currentDirection == Direction.West)
                        x--;
                    if (currentDirection == Direction.North)
                        y++;
                    if (currentDirection == Direction.South)
                        y--;
                    break;
                case 'L':
                    if (currentDirection == Direction.East)
                        currentDirection = Direction.North;
                    if (currentDirection == Direction.North)
                        currentDirection = Direction.West;
                    if (currentDirection == Direction.West)
                        currentDirection = Direction.South;
                    if (currentDirection == Direction.South)
                        currentDirection = Direction.East;
                    break;
                case 'R':
                    if (currentDirection == Direction.East)
                        currentDirection = Direction.South;
                    if (currentDirection == Direction.South)
                        currentDirection = Direction.West;
                    if (currentDirection == Direction.West)
                        currentDirection = Direction.North;
                    if (currentDirection == Direction.North)
                        currentDirection = Direction.East;
                    break;
            }
        }
    }
}
