namespace LeetCodeDay6Program2
{
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

    // Recursive Solution
    internal class BinaryTreeLevelOrderTraversal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> levelOrder = new List<IList<int>>();

            if (root != null)
            {
                BinaryLevelOrder(root, 0, ref levelOrder);

            }

            return levelOrder;
        }

        private void BinaryLevelOrder(TreeNode root, int level, ref IList<IList<int>> levelOrder)
        {
            if (root != null)
            {
                if (levelOrder.Count == level)
                {
                    levelOrder.Add(new List<int>());
                }

                levelOrder[level].Add(root.val);
                BinaryLevelOrder(root.left, level + 1, ref levelOrder);
                BinaryLevelOrder(root.right, level + 1, ref levelOrder);
            }

            return;
        }

        // Queue Solution
        public IList<IList<int>> LevelOrderIter(TreeNode root)
        {    
            IList<IList<int>> levelOrder = new List<IList<int>>();       
            Queue<TreeNode> treeNodes = new Queue<TreeNode>();              

            if (root != null)
            {
                levelOrder.Add(new List<int>() { root.val });
                treeNodes.Enqueue(root);
            }

            while (treeNodes.Any())
            {
                List<int> lvl = new List<int>();
                int qSize = treeNodes.Count;

                for (int i = 0; i < qSize; ++i)
                { 
                    TreeNode node = treeNodes.Dequeue();

                    if (node.left != null)
                    {
                        lvl.Add(node.left.val);
                        treeNodes.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        lvl.Add(node.right.val);
                        treeNodes.Enqueue(node.right);
                    }
                }

                if (lvl.Any())
                {
                    levelOrder.Add(lvl); 
                }
            }

            return levelOrder;
        }
    }
}