using Utils.Tree;

namespace Problems.Easy.BinaryTreeInorderTraversal_94;

/// <summary>
/// Given the root of a binary tree, return the inorder traversal of its nodes' values.
/// </summary>
public class Solution : ITask
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        var inorderTraversal = new List<int>();

        if (root == null)
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
        BinaryTree binaryTree = new BinaryTree();

        while (true)
        {
            Console.Write("Введите значения узлов через запятую (пример: 1,null,2,3): ");
            var treeArr = Console.ReadLine().Split(',').Select(s => int.TryParse(s, out int result) ? result : (int?)null).ToArray();
            Utils.Tree.TreeNode root = binaryTree.ArrayToTree(treeArr);
            Console.WriteLine($"Значения всех услов: {string.Join(" ", InorderTraversal(root))}");
        }
    }

    
}