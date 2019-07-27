using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //WordBackground.FindArea();
            //LexographicalBiggerItems.FindNextBigItem();
            //ClimbingLeaderboard.FindRanking();
            //PrimeDigitSums.FindSpecialNumbers();
            //DoCircleExist.CheckPath();
            //PalindromesCountcs.CountPalindromes();
            //PalindromeCheck.CheckPalindromes();
            //PalindromeIndex.FindPalindromeIndex();
            //Anagram.FindAnagramChanges();
            //ArrayDS.ArrayReverse();
            //ArrayHourglass.CalculateHourglass();
            //StringCount.CountStrings();
            //LinkedLists.ProcessLinkedLists();
            //Trees.ProcessTrees();
            //AVLTrees.ProcessAVLTrees();
            //XORSequence.ProcessXORSequence();
            //CodeFights1.RecurTasks();
            //CodeFights2.ProcessFights();
            //ClosestNumbers.GetClosestNumbers();
            //Median.FindMedian();
            //GreatXOR.FindXORCount();
            //GraphTheory.JourneyToMoon.FindCombinations();
            //GraphTheory.ValueOfFreindship.FindCombinations();
            //BitManipulations.SequenceAND.AndProduct();
            //UltiTest.Method1();

            //HackerRank.SuperReducedString.ReduceString();
            //HackerRank.RadioTransmitters.RadioTransmittersCount();
            //HackerRank.NumberGroups.CalcualteGroupTotal();

            //LeetCode._01142017.FindMaxConsecutiveOnesFlipAZero();
            //LeetCode._01142017.FindMinStepOutput();
            //LeetCode._07012017.JudgeSquareSumCall();
            //LeetCode._08052017.TwoSumBST();

            //CodeFights._01202017.ChessHorseMoves();
            //CodeFights._01312017.Method1();
            //CodeFights.SortStringChars.SortString();
            //CodeFights._02052017.Method1();
            //CodeFights._06142017.Method1();
            //CodeFights.HugeNumber.FindHugeNumber();
            //CodeFights.MineSweeper.MineSweeperChallenge();
            //CodeFights.AlmostPalindrome.CheckAlmostPalindrome();
            //CodeFights._10142018.CalculateTotals();
            //CodeFights._10152018.Method1();
            HoneywellTest.getMovieTitlesAsync("spiderman"); 
            //HoneyWell.FibonacciZipFiles.ZipText();
            //var animalrs = new List<IAnimal> { new Cat(), new Dog(), new Cat(), new Dog(), new Animal() };
            //foreach (IAnimal an in animalrs)
            //{
            //    Console.Write("{0},{1};", an.SayType(), an.SayName());
            //}

            //const string c = "scissors-paper-rock";
            //IEnumerable<string> elements = c.ToUpper().Split('-').Reverse();

            //foreach (string element in elements)
            //    Console.Write("{0},", element);
            ////Console.WriteLine(String.Join(",", strArray) + ",");

            //int[] values = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //for (int x = 0; x < values.Length; x++)
            //{
            //    switch (values[x] % 2)
            //    {
            //        case 0:
            //            Console.Write("{0}", x);
            //            break;
            //        case 2:
            //            Console.Write("{0}", x);
            //            break;
            //    }
            //}

            //string toCount = "asdf Adsf Adsf adf a dfsf fs ";
            //char[] splitChars = new char[] { ' ', ',', '?', '.' };
            //string[] splitString = toCount.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);
            //SortedDictionary<string, int> wordsCount = new SortedDictionary<string, int>();
            ////splitString.ToList().ForEach(word => { })
            //foreach (string word in splitString)
            //{
            //    if (wordsCount.ContainsKey(word.ToString().ToLowerInvariant()))
            //    {
            //        wordsCount[word.ToLowerInvariant()] = wordsCount[word.ToLowerInvariant()] + 1;
            //    }
            //    else
            //    {
            //        wordsCount[word.ToLowerInvariant()] = 1;
            //    }
            //}
            //foreach (string word in wordsCount.Keys)
            //{
            //    Console.WriteLine(word + ": " + wordsCount[word]);
            //}
            //float f = (float) 2 / (float)3;
            //Console.Write(f);
            //Console.Write(CountAs(str));
            Console.WriteLine();
            Console.WriteLine("Process Completed");

            Console.ReadLine();
        }

        private static int CountAs(string str)
        {
            char compareCharacter = 'a';
            int count = 0;
            foreach(char c in str.ToCharArray())
            {
                if (compareCharacter == char.ToLower(c))
                {
                    count++;
                }
            }
            return count;
        }
    }

    public interface IAnimal
    {
        string SayType();
        string SayName();
    }

    public class Animal: IAnimal
    {
        public virtual string SayType()
        {
            return GetType().Name;
        }

        public virtual string SayName()
        {
            return "None";
        }
    }

    public class Dog : Animal
    {
        public override string SayType()
        {
            return GetType().Name;
        }

        public override string SayName()
        {
            return SayType();
        }
    }

    public class Cat : IAnimal
    {
        public virtual string SayType()
        {
            return SayName();
        }

        public string SayName()
        {
            return SayType();
        }
    }
}
