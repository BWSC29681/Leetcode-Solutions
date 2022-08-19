namespace LeetcodeSolutionLibrary.Solutions
{
    public class LowestCommonAncestor_235 : LeetcodeSolutionBase, ILeetcodeSolution
    {
        public int Number => 235;
        public string Title => "Lowest Common Ancestor of a Binary Search Tree";
        public string Description => @"
Given a binary search tree (BST), find the lowest common ancestor (LCA) node of two given nodes in the BST.

According to the definition of LCA on Wikipedia: “The lowest common ancestor is defined between two nodes p and q as the lowest node in T that has both p and q as descendants (where we allow a node to be a descendant of itself).”

Example 1:
Input: root = [6,2,8,0,4,7,9,null,null,3,5], p = 2, q = 8
Output: 6
Explanation: The LCA of nodes 2 and 8 is 6.

Example 2:
Input: root = [6,2,8,0,4,7,9,null,null,3,5], p = 2, q = 4
Output: 2
Explanation: The LCA of nodes 2 and 4 is 2, since a node can be a descendant of itself according to the LCA definition.

Example 3:
Input: root = [2,1], p = 2, q = 1
Output: 2
 
Constraints:
The number of nodes in the tree is in the range [2, 105].
-109 <= Node.val <= 109
All Node.val are unique.
p != q
p and q will exist in the BST.";


        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (isDescendant(root.left, p) && isDescendant(root.left, q))
                return LowestCommonAncestor(root.left, p, q);
            else if (isDescendant(root.right, p) && isDescendant(root.right, q))
                return LowestCommonAncestor(root.right, p, q);
            else
                return root;
        }

        private bool isDescendant(TreeNode root, TreeNode descendant)
        {
            if (root == null)
                return false;

            if (root.val == descendant.val)
                return true;
            else
                return isDescendant(root.left, descendant) || isDescendant(root.right, descendant);
        }        

        public string GenerateSampleResults()
        {
            string results = "";

            RunTest(new int?[] { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 }, p: 2, q: 8);
            RunTest(new int?[] { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 }, p: 2, q: 4);
            RunTest(new int?[] { 2, 1 }, p: 2, q: 1);

            void RunTest(int?[] vals, int p, int q)
            {
                TreeNode? lca = LowestCommonAncestor(TreeNode.BuildTree(vals), new TreeNode(p), new TreeNode(q));
                results += $"{getArrayForDisplay(vals)}, {p}, {q}: {lca.val}\n";
            }

            return results;
        }
    }
}
