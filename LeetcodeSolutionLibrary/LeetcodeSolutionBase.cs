namespace LeetcodeSolutionLibrary
{
    public class LeetcodeSolutionBase
    {
        protected string getArrayForDisplay(int?[] nums)
        {
            return "[" + string.Join(',', nums) + "]";
        }

        protected string getArrayForDisplay(int[] nums)
        {
            int?[] newNums = new int?[nums.Length];
            for (int i = 0; i < nums.Length; i++) newNums[i] = nums[i];
            return getArrayForDisplay(newNums);
        }

        //Definition for a binary tree node.
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }

            public static TreeNode BuildTree(int?[] vals)
            {
                var root = new TreeNode(vals[0].Value);

                for (int i = 1; i < vals.Length; i++)
                    if (vals[i].HasValue)
                        AddTreeNode(root, vals[i].Value);
                return root;
            }

            private static void AddTreeNode(TreeNode root, int val)
            {
                if (val < root.val)
                {
                    if (root.left == null) root.left = new TreeNode(val);
                    else AddTreeNode(root.left, val);
                }
                else
                {
                    if (root.right == null) root.right = new TreeNode(val);
                    else AddTreeNode(root.right, val);
                }

            }
        }
    }
}