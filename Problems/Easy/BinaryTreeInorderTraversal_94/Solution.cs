using System.IO.Pipelines;
using System.Linq;

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
        while (true)
        {
            Console.Write("Введите значения узлов через запятую (пример: 1,null,2,3): ");
            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                continue;
            }

            TreeNode root = StringToTreeNode(input);
            Console.WriteLine($"Значения всех услов: {string.Join(" ", InorderTraversal(root))}");
        }
    }

    private TreeNode StringToTreeNode(string input)
    {
        var treeArr = input.Split(',').Select(s => int.TryParse(s, out int result) ? result : (int?)null);
        TreeNode root = null;
        TreeNode courrentTree = null;
        int counter = 0;

        foreach (int? item in treeArr)
        {
            if (counter == 0)
            {
                root = new TreeNode(item.GetValueOrDefault(0));
                courrentTree = root;
            }
            else if (counter == 1)
            {
                root?.left = new TreeNode(item.GetValueOrDefault(0));
            }
            else if (counter == 2)
            {
                root?.right = new TreeNode(item.GetValueOrDefault(0));
            }

            counter = ++counter > 2 ? 0 : counter;
        }

        return root;
    }
}