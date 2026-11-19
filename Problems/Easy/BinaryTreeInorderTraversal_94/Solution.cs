namespace Problems.Easy.BinaryTreeInorderTraversal_94;

/// <summary>
/// Given the root of a binary tree, return the inorder traversal of its nodes' values.
/// </summary>
public class Solution : ITask
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        var inorderTraversal = new List<int>();

        if(root == null)
        {
            return inorderTraversal;
        }

        if (root.left != null)
        {
            inorderTraversal.AddRange(InorderTraversal(root.left));
        }

        inorderTraversal.Add(root.val);

        if (root.right != null)
        {
            inorderTraversal.AddRange(InorderTraversal(root.right));
            return inorderTraversal;
        }

        return inorderTraversal;
    }

    public void Run()
    {
        TreeNode root = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5, new TreeNode(6), new TreeNode(7))),
            new TreeNode(3, null, new TreeNode(8, new TreeNode(9))));
        Console.WriteLine($"Значения всех услов: {string.Join(" ", InorderTraversal(root))}");
    }
}