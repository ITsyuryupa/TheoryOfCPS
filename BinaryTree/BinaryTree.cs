using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeN
{
    internal class BinaryTree
    {
        #region
        //private class Node
        //{
        //    public int Value { get; set; }

        //    public Node? Right;
        //    public Node? Left;
        //    public Node? Parent;

        //    public Node(int value)
        //    {
        //        Value = value;
        //    }
        //}

        //private Node Root;

        //public int Count = 1;


        //public BinaryTree(int value)
        //{
        //    Node node = new Node(value);
        //    node.Value = value;
        //    Root = node;
        //}

        //public void Add(int value)
        //{
        //    Node newNode = new Node(value);
        //    Node parent = Root;
        //    while (newNode.Parent == null)
        //    {
        //        if (parent.Value > value)
        //        {
        //            if (parent.Left == null)
        //            {
        //                parent.Left = newNode;
        //                newNode.Parent = parent;
        //            }
        //            else
        //            {
        //                parent = parent.Left;
        //            }
        //        }
        //        else
        //        {
        //            if (parent.Right == null)
        //            {
        //                parent.Right = newNode;
        //                newNode.Parent = parent;
        //            }
        //            else
        //            {
        //                parent = parent.Right;
        //            }
        //        }
        //    }
        //    Count++;
        //}

        //public void Print()
        //{
        //    for (int i = 0; i < this.Count; i++)
        //    {
        //        Console.Write("  ");
        //    }
        //    Console.Write($"({this.Root.Value})");

        //    for (int i = 0; i < this.Count; i++)
        //    {
        //        Console.Write("  ");
        //    }

        //    //int start = 1;
        //    while (true)
        //    {
        //        //for (int i = start; i < tree.Count; i++)
        //        //{
        //        //    Console.Write(" ");
        //        //}

        //        //start++;
        //    }
        //} 
        #endregion

        public int[,] tree;

        private int iRoot;
        private int jRoot;

        private int Count;
        private int Capaciti;

        

        public BinaryTree(int capaciti, int rootValue)
        {
            iRoot = 0;
            jRoot = capaciti * 5 / 2;
            tree = new int[jRoot * 2, jRoot * 2];

            
            tree[iRoot, jRoot] = rootValue;

            Capaciti = capaciti;
            Count++;

        }

        public void Add(int value)
        {
            int step = this.jRoot;
            if (this.Count + 1 > this.Capaciti)
            {
                return;
            }
            int i = this.iRoot, j = this.jRoot;
            while (true)
            {
                if (this.tree[i, j] != 0)
                {
                    if (this.tree[i, j] >= value)
                    {
                        i = i + 1;
                        j = j - step/(2 * (i + 1));
                        continue;
                    }
                    else if (this.tree[i, j] < value)
                    {
                        i = i + 1;
                        j = j + step / (2 * (i + 1));
                    }
                }
                else
                {
                    this.tree[i, j] = value;
                    Count++;
                    return;
                }
            }
            
                
        }

        public void Del(int value)
        {
            for (int i = 0; i < this.tree.GetLength(0); i++)
            {
                for (int j = 0; j < this.tree.GetLength(1); j++)
                {
                    if (tree[i, j] == value)
                    {
                        tree[i, j] = 0;
                        DelChild(i + 1, j - tree.GetLength(0) / (4 * (i + 2)), this.tree);
                        DelChild(i + 1, j + tree.GetLength(0) / (4 * (i + 2)), this.tree);
                        return;
                    }
                }
            }
        }

        public void DelChild(int i, int j, int[,] tree)
        {
            while (true)
            {
                if (tree[i, j] != 0)
                {
                    tree[i, j] = 0;
                    i = i + 1;
                    DelChild(i, j - tree.GetLength(0) / (4 * (i + 1)), tree);
                    DelChild(i, j + tree.GetLength(0) / (4 * (i + 1)), tree);
                }
                else
                {
                    return;
                }
                
            }
        }

    } 


}
