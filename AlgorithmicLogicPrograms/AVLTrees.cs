using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class AVLTrees
    {
        class Node
        {
            public int val;   //Value
            public int ht;      //Height
            public Node left;   //Left child
            public Node right;   //Right child
        }

        public static void ProcessAVLTrees()
        {
            /*Node root = insert(null, 3);
            root = insert(root, 2);
            root = insert(root, 4);
            root = insert(root, 5);*/
            Node root = insert(null, 14);
            root = insert(root, 25);
            root = insert(root, 21);
            root = insert(root, 10);
            root = insert(root, 23);
            root = insert(root, 7);
            root = insert(root, 26);
            root = insert(root, 12);
            root = insert(root, 30);
            root = insert(root, 16);
            root = insert(root, 19);
        }

        static Node insert(Node root, int val)
        {
            if (root == null)
            {
                root = new Node();
                root.val = val;
            }
            else
            {
                insertRecursive(root, val);
                balanceTree(root);
            }
            return root;
        }

        static int balanceTree(Node current)
        {
            if (current == null) return 0;
            if (current.left == null && current.right == null)
            {
                current.ht = 1;
            }
            else
            {
                int leftHeight = 0;
                int rightHeight = 0;
                if (current.left != null)
                {
                    leftHeight = balanceTree(current.left);
                }
                if (current.right != null)
                {
                    rightHeight = balanceTree(current.right);
                }
                if (leftHeight - rightHeight >= 2)
                {
                    current = rotateRight(current);
                }
                else if (rightHeight - leftHeight >= 2)
                {
                    current = rotateLeft(current);
                }
                else
                {
                    current.ht = leftHeight > rightHeight ? leftHeight + 1 : rightHeight + 1;
                }
            }
            return current.ht;
        }

        static void insertRecursive(Node root, int val)
        {
            Node current = root;
            Node newNode = new Node();
            newNode.val = val;
            bool isAdded = false;
            Node parent = null;
            string previous = string.Empty;
            while (!isAdded)
            {
                if (current.val > val)
                {
                    if (current.left == null)
                    {
                        current.left = newNode;
                        if (previous == "Right" && parent != null)
                        {
                            //rotateRightLeft(parent);
                        }
                        else
                        {

                        }
                        isAdded = true;
                    }
                    else
                    {
                        parent = current;
                        current = current.left;
                        previous = "Left";
                    }
                }
                else
                {
                    if (current.right == null)
                    {
                        current.right = newNode;
                        isAdded = true;
                    }
                    else
                    {
                        parent = current;
                        current = current.right;
                        previous = "Right";
                    }
                }
            }
            /*if (val < current.val)
            {
                if (current.left == null)
                {
                    Node newNode = new Node();
                    newNode.val = val;
                    current.left = newNode;
                }
                else
                {
                    insert(current.left, val);
                }
            }
            else if (val > current.val)
            {
                if (current.right == null)
                {
                    Node newNode = new Node();
                    newNode.val = val;
                    current.right = newNode;
                }
                else
                {
                    insert(current.right, val);
                }
            }*/
        }

        static Node rotateLeft(Node node)
        {
            Node temp = node.right;
            node.right = temp.left;
            temp.left = node;
            return temp;
        }

        static Node rotateRight(Node node)
        {
            Node temp = node.left;
            node.left = temp.right;
            temp.right = node;
            return temp;
        }
    }
}
