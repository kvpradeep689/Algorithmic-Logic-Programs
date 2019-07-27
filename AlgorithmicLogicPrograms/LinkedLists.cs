using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class LinkedLists
    {
        class Node
        {
            public int data;
            public Node next;
            /// <summary>
            /// Do not use this for singly linked lists
            /// </summary>
            public Node prev;
        }

        public static void ProcessLinkedLists()
        {
            /*Node head = null;
            head = InsertNth(head, 3, 0);
            head = InsertNth(head, 5, 1);
            head = InsertNth(head, 4, 2);
            head = InsertNth(head, 2, 3);
            head = InsertNth(head, 10, 1);*/

            /*Node head1 = new Node()
            {
                data = 1,
                next = new Node()
                {
                    data = 3,
                    next = new Node()
                    {
                        data = 5,
                        next = new Node()
                        {
                            data = 6
                        }
                    }
                }
            };
            Node head2 = new Node()
            {
                data = 2,
                next = new Node()
                {
                    data = 4,
                    next = new Node()
                    {
                        data = 7
                    }
                }
            };
            Node head = MergeLists(head1, head2);
            PrintLinkedList(head);
            */

            /*
            Node head = new Node()
            {
                data = 1,
                next = new Node()
                {
                    data = 2,
                    next = new Node()
                    {
                        data = 2,
                        next = new Node()
                        {
                            data = 3,
                            next = new Node()
                            {
                                data = 3,
                                next = new Node()
                                {
                                    data = 4
                                }
                            }
                        }
                    }
                }
            };
            head = RemoveDuplicates(head);
            PrintLinkedList(head);

            */

            /*
            Node mergeNode = new Node()
            {
                data = 2,
                next = new Node()
                {
                    data = 3,
                    next = null
                }
            };
            Node head1 = new Node()
            {
                data = 1,
                next = new Node()
                {
                    data = 2,
                    next = mergeNode
                }
            };
            Node head2 = new Node()
            {
                data = 1,
                next = new Node()
                {
                    data = 2,
                    next = mergeNode
                }
            };
            Console.WriteLine(FindMergeNode(head1, head2));
            */

            Node one = new Node()
            {
                data = 1
            };
            Node two = new Node()
            {
                data = 2
            };
            Node three = new Node()
            {
                data = 3
            };
            one.next = two;
            two.next = three;
            three.prev = two;
            two.prev = one;
            Node head = ReverseDoublyLinkedList(one);
            PrintLinkedList(head);
        }

        private static void PrintLinkedList(Node head)
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        private static Node InsertNth(Node head, int data, int position)
        {
            Node newNode = new Node();
            newNode.data = data;

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                int count = 0;
                while (current.next != null && count < position - 1)
                {
                    current = current.next;
                    count++;
                }
                newNode.next = current.next;
                current.next = newNode;
            }
            return head;
        }

        private static Node Delete(Node head, int position)
        {
            Node current = head;
            int count = 0;
            if (position == 0)
            {
                head = head.next;
            }
            else
            {
                while (count < position - 1)
                {
                    current = current.next;
                    count++;
                }
                current.next = current.next.next;
            }
            return head;
        }

        static void ReversePrint(Node head)
        {
            if (head != null)
            {
                Node prev = head;
                Node current = head.next;
                prev.next = null;
                while (current != null)
                {
                    Node tempLink = current.next;
                    current.next = prev;
                    prev = current;
                    current = tempLink;
                }
                head = prev;
                while (head != null)
                {
                    Console.WriteLine(head.data);
                    head = head.next;
                }
            }
        }

        static int CompareLists(Node headA, Node headB)
        {
            int returnVal = 1;
            while (headA != null && headB != null)
            {
                if (headA.data != headB.data)
                {
                    returnVal = 0;
                    break;
                }
                headA = headA.next;
                headB = headB.next;
            }
            if (headA != null || headB != null)
                returnVal = 0;

            return returnVal;
        }

        static Node MergeLists(Node headA, Node headB)
        {
            Node newHead = null;
            if (headA == null)
            {
                newHead = headB;
            }
            else if (headB == null)
            {
                newHead = headA;
            }
            else
            {
                if (headA.data < headB.data)
                {
                    newHead = headA;
                    headA = headA.next;
                }
                else
                {
                    newHead = headB;
                    headB = headB.next;
                }
                Node current = newHead;
                while (headA != null && headB != null)
                {
                    if (headA.data < headB.data)
                    {
                        current.next = headA;
                        headA = headA.next;
                        current = current.next;
                    }
                    else
                    {
                        current.next = headB;
                        headB = headB.next;
                        current = current.next;
                    }
                }
                if (headA == null)
                {
                    current.next = headB;
                }
                else
                {
                    current.next = headA;
                }
            }
            return newHead;
        }

        static Node MergeListsRecursive(Node headA, Node headB)
        {
            if (headA == null)
            {
                return headB;
            }
            else if (headB == null)
            {
                return headA;
            }

            if (headA.data < headB.data)
            {
                headA.next = MergeListsRecursive(headA.next, headB);
                return headA;
            }
            else
            {
                headB.next = MergeListsRecursive(headA, headB.next);
                return headB;
            }
        }

        static int GeNthtNodeFromReverse(Node head, int n)
        {
            if (head != null)
            {
                Node prev = head;
                Node current = head.next;
                prev.next = null;
                while (current != null)
                {
                    Node tempLink = current.next;
                    current.next = prev;
                    prev = current;
                    current = tempLink;
                }
                head = prev;
                for (int i = 0; i < n; i++)
                {
                    head = head.next;
                }
                return head.data;
            }
            return 0;
        }

        static Node RemoveDuplicates(Node head)
        {
            Node current = head;
            while (current != null)
            {
                Node nextNode = current.next;
                while (nextNode != null && nextNode.data == current.data)
                {
                    nextNode = nextNode.next;
                }
                current.next = nextNode;
                current = nextNode;
            }
            return head;
        }

        /// <summary>
        /// Excellent logic. Awesome
        /// </summary>
        static int FindMergeNode(Node headA, Node headB)
        {
            Node currA = headA;
            Node currB = headB;

            while (currA != currB)
            {
                if (currA.next == null)
                {
                    currA = headB;
                }
                else
                {
                    currA = currA.next;
                }
                if (currB.next == null)
                {
                    currB = headA;
                }
                else
                {
                    currB = currB.next;
                }
            }
            return currA.data;
        }

        static Node SortedInsert(Node head, int data)
        {
            Node newNode = new Node();
            newNode.data = data;

            if (head == null)
            {
                return newNode;
            }
            Node current = head;
            while (current.next != null && current.next.data < data)
            {
                current = current.next;
            }
            if (current.data < data)
            {
                InsertAfter(newNode, current);
            }
            else
            {
                InsertBefore(newNode, current);
            }
            return head;
        }

        static void InsertAfter(Node newNode, Node current)
        {
            newNode.next = current.next;
            newNode.prev = current;
            current.next = newNode;
            if (newNode.next != null)
            {
                newNode.next.prev = newNode;
            }
        }

        static void InsertBefore(Node newNode, Node current)
        {
            newNode.prev = current.prev;
            newNode.next = current;
            current.prev = newNode;
            if (newNode.prev != null)
            {
                newNode.prev.next = newNode;
            }
        }

        static Node ReverseDoublyLinkedList(Node head)
        {
            while (head != null && head.next != null)
            {
                Node nextNode = head.next;
                if (nextNode != null)
                {
                    head.next = head.prev;
                    head.prev = nextNode;
                    head = nextNode;
                    nextNode = nextNode.next;
                }
            }
            head.next = head.prev;
            head.prev = null;
            return head;
        }
    }
}
