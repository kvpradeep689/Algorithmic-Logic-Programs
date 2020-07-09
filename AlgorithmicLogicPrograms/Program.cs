using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ConsoleApplication1.LeetCode;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Old
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
            //HoneywellTest.getMovieTitlesAsync("spiderman"); 
            //HoneyWell.FibonacciZipFiles.ZipText();

            #endregion

            //MS.TwoSumProb.Run();
            //MS.Palindrome.Run();
            //InsertDeleteGetRandomO1.Run();
            //LeetCode.July.BinaryTreeLevelOrderTraversal2.Run();
            //LeetCode.July.PrisonCellsAfterNDays.Run();
            //LeetCode.July.UglyNumberII.Run();
            //LeetCode.July.IslandPerimeterClass.Run();
            LeetCode.July.ThreeSumClass.Run();

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
}
