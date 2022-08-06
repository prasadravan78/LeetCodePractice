namespace LeetCodeDay6Program1
{
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }

    internal class NaryPreorderTreeTraversal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public IList<int> Preorder(Node root)
        {
            var preOrderNodes = new List<int>();

            if (root != null)
            {
                preOrderNodes.Add(root.val);

                if (root.children != null)
                {
                    foreach (var node in root.children)
                    {
                        preOrderNodes.AddRange(Preorder(node));
                    }
                }
            }

            return preOrderNodes;
        }
    }
}