using System.Collections.Generic;
using System.Linq;

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

public class Solution
{
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        // Get leaf sequences for both trees
        var leaves1 = GetLeafSequence(root1);
        var leaves2 = GetLeafSequence(root2);

        // Compare the sequences
        return leaves1.SequenceEqual(leaves2);
    }

    private List<int> GetLeafSequence(TreeNode root)
    {
        var leaves = new List<int>();
        CollectLeaves(root, leaves);
        return leaves;
    }

    private void CollectLeaves(TreeNode node, List<int> leaves)
    {
        if (node == null)
        {
            return;
        }

        if (node.left == null && node.right == null)
        {
            // It's a leaf node
            leaves.Add(node.val);
        }

        CollectLeaves(node.left, leaves);
        CollectLeaves(node.right, leaves);
    }
}
