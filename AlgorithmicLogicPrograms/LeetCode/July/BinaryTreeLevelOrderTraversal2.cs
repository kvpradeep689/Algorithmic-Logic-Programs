using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetCode.July
{
    /// <summary>
    /// https://leetcode.com/explore/challenge/card/july-leetcoding-challenge/544/week-1-july-1st-july-7th/3378/
    /// </summary>
    // Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class BinaryTreeLevelOrderTraversal2
    {

        public static void Run()
        {
            TreeNode root = new TreeNode
            {
                val = 3,
                left = new TreeNode
                {
                    val = 9
                },
                right = new TreeNode
                {
                    val = 20,
                    left = new TreeNode
                    {
                        val = 15
                    },
                    right = new TreeNode
                    {
                        val = 7
                    }
                }
            };
            var test = LevelOrderBottom(root);
        }

        private static IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            var levelDict = new Dictionary<int, IList<int>>();
            TraverseTree(root, levelDict, 1);
            var totalLists = new List<IList<int>>();
            for (int i = levelDict.Count; i > 0; i--)
            {
                totalLists.Add(levelDict[i]);
            }
            return totalLists;
        }

        private static void TraverseTree(TreeNode node, Dictionary<int, IList<int>> dict, int level)
        {
            if (node == null)
            {
                return;
            }
            if (dict.ContainsKey(level))
            {
                var list = dict[level];
                list.Add(node.val);
            }
            else
            {
                var list = new List<int>();
                list.Add(node.val);
                dict.Add(level, list);
            }
            TraverseTree(node.left, dict, level + 1);
            TraverseTree(node.right, dict, level + 1);
        }
    }
}
