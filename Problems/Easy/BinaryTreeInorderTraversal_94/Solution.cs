namespace Problems.Easy.BinaryTreeInorderTraversal_94;

/// <summary>
/// Given the root of a binary tree, return the inorder traversal of its nodes' values.
/// </summary>
public class Solution : ITask
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        var treeNodes = new List<int>();

        if(root == null)
        {
            return treeNodes;
        }

        if (root.left != null)
        {
            treeNodes.AddRange(InorderTraversal(root.left));
        }
        if (root.right != null)
        {
            treeNodes.AddRange(InorderTraversal(root.right));
        }

        treeNodes.Add(root.val);
        return treeNodes;
    }

    public void Run()
    {
        TreeNode root = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5, new TreeNode(6), new TreeNode(7))),
            new TreeNode(3, null, new TreeNode(8, new TreeNode(9))));
        Console.WriteLine($"Значения всех услов: {string.Join(" ", InorderTraversal(root))}");
    }
}