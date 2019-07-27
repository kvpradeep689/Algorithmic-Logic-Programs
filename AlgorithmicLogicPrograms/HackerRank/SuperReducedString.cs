using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.HackerRank
{
	class SuperReducedString
	{
		public static void ReduceString()
		{
			string str = "aaabccddd";//Console.ReadLine();
			Stack<char> charStack;
			int prevLength = 0;

			while (prevLength != str.Length)
			{
				prevLength = str.Length;
				charStack = new Stack<char>();
				for (int index = 0; index < str.Length;)
				{
					bool found = false;
					if (charStack.Count > 0 && index < str.Length && charStack.Peek() == str[index])
					{
						index++;
						found = true;
					}
					if (found)
					{
						charStack.Pop();
					}
					else
					{
						charStack.Push(str[index]);
						index++;
					}
				}
				str = new string(charStack.ToArray());
			}

			if (string.IsNullOrEmpty(str))
			{
				Console.WriteLine("Empty String");
			}
			else
			{
				Console.WriteLine(str);
			}
		}
	}
}
