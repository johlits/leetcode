/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
​
public class Solution {
    public int RangeSumBST(TreeNode root, int L, int R) {
        var l = 0;
        var r = 0;
        var v = 0;
        if (root.left != null) {
            l = RangeSumBST(root.left, L, R);
        }
        if (root.right != null) {
            r = RangeSumBST(root.right, L, R);
        }
        if (root.val >= L && root.val <= R)
            v = root.val;
        return v + l + r;
    }
}
