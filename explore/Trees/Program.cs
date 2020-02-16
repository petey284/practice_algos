using System;
using System.Collections.Generic;

namespace Trees
{
    using StringTree = Tree<string>;
    using IntTree = Tree<int>;

    public enum Traversal
    {
        Inorder,
        Postorder,
        Preorder
    }

    public class Tree<T>
        where T: IComparable
    {
        public TreeNode<T> Root{ get; set; }

        public void Insert(T value)
        {
            if (Root == null)
            {
                Root = new TreeNode<T>(value);
            }
            else
            {
                Root.Insert(value);
            }
        }

        public void Insert(List<T> list)
        {
            foreach (var element in list)
            {
                this.Insert(element);
            }
        }

        public void Print(Traversal traverse)
        {
            if (Root == null) { return; }
            if (traverse == Traversal.Inorder)
            {
                Root.TraverseInOrder();
                Console.WriteLine();
            } else if (traverse == Traversal.Postorder)
            {

            } else
            {

            }
        }
    }

    public class TreeNode<T>
        where T: IComparable
    {
        private T data { get; set; }
        private TreeNode<T> Left { get; set; }
        private TreeNode<T> Right { get; set; }

        public TreeNode(T data)
        {
            this.data = data;
        }

        public void TraverseInOrder()
        {
            if (Left != null)
            {
                Left.TraverseInOrder();
            }
            Console.Write(data.ToString() + ", ");
            if (Right != null)
            {
                Right.TraverseInOrder();
            }
        }

        public void Insert(T value)
        {
            // If duplicate value, then noop
            if (value.CompareTo(this.data) == 0)
            {
                return;
            }

            if (value.CompareTo(this.data) < 0)
            {
                if (Left == null)
                {
                    Left = new TreeNode<T>(value);
                } else {
                    Left.Insert(value);
                }
            } else  {

                if (Right == null)
                {
                    Right = new TreeNode<T>(value);
                } else
                {
                    Right.Insert(value);
                }
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Implement basic tree ADT

            // Tree with string type
            var stringTree = new StringTree();
            var stringList = new List<string>(){"Hello", "how", "are", "you"};
            stringTree.Insert(stringList);
            
            stringTree.Print(Traversal.Inorder);

            var intTree = new IntTree();
            var intList = new List<int>() { 1, 2, 59, 603, 10 };
            intTree.Insert(intList);

            intTree.Print(Traversal.Inorder);

            Console.ReadLine();
        }
    }
}
