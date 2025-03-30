var tree = new TreeNode(10, new TreeNode(6), new TreeNode(4));
bool result = tree.CheckTree(tree);
Console.WriteLine(result);

var falseTree = new TreeNode(5, new TreeNode(3), new TreeNode(1));
bool falseResult = tree.CheckTree(falseTree);
Console.WriteLine(falseResult);
//Definition for a binary tree node.
public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public int val = val;
    public TreeNode left = left;
    public TreeNode right = right;

    public bool CheckTree(TreeNode root)
    {
        // var rootValue = root.val;
        // var childrenSum = root.left.val + root.right.val;

        // if (rootValue == childrenSum)
        // {
        //     return true;
        // }

        // return false;
        
        return root.val == root.left.val + root.right.val;
    }
}