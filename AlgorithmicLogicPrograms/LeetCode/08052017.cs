using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetCode
{
    public class _08052017
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public static void TwoSumBST()
        {
            TreeNode node = new TreeNode(5)
            {
                left = new TreeNode(3)
                {
                    left = new TreeNode(2),
                    right = new TreeNode(4)
                },
                right = new TreeNode(6)
                {
                    right = new TreeNode(7)
                }
            };

            Console.WriteLine(FindTarget(node, 9));
            Console.WriteLine(FindTarget(node, 28));

            TreeNode node2 = new TreeNode(1);
            Console.WriteLine(FindTarget(node2, 2));
        }

        public static bool FindTarget(TreeNode root, int k)
        {
            HashSet<int> values = new HashSet<int>();

            return SearchTree(values, root, k);
        }

        private static bool SearchTree(HashSet<int> values, TreeNode node, int k)
        {
            bool found = false;
            if (node != null)
            {
                if (values.Contains(k - node.val))
                {
                    found = true;
                }
                values.Add(node.val);
                if (found || SearchTree(values, node.left, k) ||
                 SearchTree(values, node.right, k))
                {
                    return true;
                }

            }

            return false;
        }

        public static void MaximumBinaryTree()
        {
            int[] nums = new int[] { 3, 2, 1, 6, 0, 5 };
            Console.WriteLine(ConstructMaximumBinaryTree(new int[] { 3, 2, 1, 6, 0, 5 }));
            
        }

        public static TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            TreeNode root = new TreeNode(nums[0]);
            int index1 = 1;
            return BuildTree(nums, ref index1, root);
            TreeNode currentNode = root;
            for(int index = 1; index < nums.Length; index++)
            {
                if(currentNode.val > nums[index])
                {
                    currentNode.right = new TreeNode(nums[index]);
                    currentNode = currentNode.right;
                }
                else
                {
                    currentNode = root;
                    while(currentNode.val > nums[index])
                    {

                    }
                }
            }
            return new TreeNode(1);
        }

        public static TreeNode BuildTree(int[] nums, ref int index, TreeNode parentNode)
        {
            if (parentNode.val > nums[index])
            {
                TreeNode node = new TreeNode(nums[index]);
                parentNode.right = node;
                index++;
                BuildTree(nums, ref index, node);
            }
            return parentNode;
        }
    }
}
