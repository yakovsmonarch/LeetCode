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
            List<int?> treeArr = Console.ReadLine().Split(',').Select(s => int.TryParse(s, out int result) ? result : (int?)null).ToList();
            TreeNode root = StringToTreeNode(treeArr);
            Console.WriteLine($"Значения всех услов: {string.Join(" ", InorderTraversal(root))}");
        }
    }

    private TreeNode StringToTreeNode(List<int?> treeArr)
    {
        if (treeArr == null || treeArr.Count == 0 || treeArr[0] == null)
        {
            return null;
        }

        TreeNode root = new TreeNode(treeArr[0].Value);
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int i = 1;
        var isOk = () => i < treeArr.Count && queue.Count > 0;

        while (isOk())
        {
            TreeNode node = queue.Dequeue();

            if (i < treeArr.Count)
            {
                if(treeArr[i] != null)
                {
                    node.left = new TreeNode(treeArr[i].Value);
                    queue.Enqueue(node.left);
                }
                i++;
            }

            if (i < treeArr.Count)
            {
                if(treeArr[i] != null)
                {
                    node.right = new TreeNode(treeArr[i].Value);
                    queue.Enqueue(node.right);
                }
                i++;
            }
        }

        return root;
    }
}