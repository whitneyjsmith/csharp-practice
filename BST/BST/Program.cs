using System;

namespace BST
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] values = new int[] {2, 5, 1, -2, 4, 10};
            var localBST = new BST();
            for (int i = 0; i < values.Length; i++) 
            {
                localBST.Insert(values[i]);
            }
            return;
        }
    } // MainClass end

    class Node
    {
        public const int LEFT = 0;
        public const int RIGHT = 1;
        public int data;
        public Node left;
        public Node right;

        public Node(int data) 
        {
            this.data = data;
        }

        public int Compare(int other) 
        {
            if (other >= this.data)
            {
                return RIGHT; // go right
            }
            else 
            {
                return LEFT; // go left
            }
        } // Compare() end

        public void InsertR(int other) 
        {
            if (this.Compare(other) == LEFT)
            {
                // insert left
                if (this.left != null) 
                {
                    this.left.InsertR(other);
                }
                else
                {
                    this.left = new Node(other);
                }
            }
            else
            {
                // insert right
                if (this.right != null)
                {
                    this.right.InsertR(other);
                }
                else
                {
                    this.right = new Node(other);
                }
            }
        }
    } // Node end

    class BST
    {
        public Node first; // entry point of BST

        public void Insert(int newData)
        {
            if (this.first == null) 
            {
                this.first = new Node(newData);
            }
            else
            {
                this.first.InsertR(newData);
            }
        } // Insert() end
    } // BST end
} // namespace end
