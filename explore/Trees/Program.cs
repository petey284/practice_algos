using System;

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
            } else
            {
                Root.Insert(value);
            }
        }

        public void Print(Traversal traverse)
        {
            if (traverse == Traversal.Inorder)
            {

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
            stringTree.Insert("Hello");
        }
    }
}
