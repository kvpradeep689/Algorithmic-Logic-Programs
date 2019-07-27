using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Trees
    {
        public class Node
        {
            public int data;
            public Node left;
            public Node right;
        }

        public static void ProcessTrees()
        {
            /*
            Node root = new Node(){
                data = 3,
                left = new Node()
                {
                    data = 2,
                    left = new Node()
                    {
                        data = 1
                    }
                },
                right = new Node()
                {
                    data = 5,
                    left = new Node()
                    {
                        data = 4
                    },
                    right = new Node()
                    {
                        data = 6,
                        right = new Node()
                        {
                            data = 7
                        }
                    }
                }
            };
            Console.Write(getHeight(root));
            */
            Node root = new Node()
            {
                data = 100,
                left = new Node()
                {
                    data = 50,
                    left = new Node()
                    {
                        data = 40
                    },
                    right = new Node()
                    {
                        data = 70,
                        left = new Node()
                        {
                            data = 60
                        },
                        right = new Node()
                        {
                            data = 200
                        }
                    },
                }
            };
            /*
            root = new Node()
            {
                data = 10,
                left = new Node()
                {
                    data = 9,
                    left = new Node()
                    {
                        data = 8,
                        left = new Node()
                        {
                            data = 7,
                            left = new Node()
                            {
                                data = 6
                            },

                        }
                    },
                    
                }
            };*/
            Console.WriteLine(checkBST(root));
        }

        static int getHeight(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftHeight = getHeight(root.left);
            int rightHeight = getHeight(root.right);
            if (leftHeight > rightHeight)
            {
                return leftHeight + 1;
            }
            else
            {
                return rightHeight + 1;
            }
        }

        static Node FindNode(Node node, int value)
        {
            if (node.data == value)
            {
                return node;
            }
            else if (node.data < value)
            {
                return FindNode(node.right, value);
            }
            else
                return FindNode(node.left, value);
        }

        static bool checkBST(Node root)
        {
            if (root == null) return true;
            return checkBST(root, int.MinValue, int.MaxValue);
        }

        static bool checkBST(Node node, int min, int max)
        {
            bool returnVal = true;

            if (node.left != null)
            {
                returnVal = (node.data > node.left.data) && node.left.data < max && node.left.data > min && checkBST(node.left, min, node.left.data);
            }
            if (node.right != null)
            {
                returnVal = returnVal && (node.data < node.right.data) && node.right.data > min && node.right.data < max && checkBST(node.right, node.right.data, max);
            }
            return returnVal;
        }
    }
}

