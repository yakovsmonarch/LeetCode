namespace Utils.Tree;

public class BinaryTree
{
    public TreeNode ArrayToTree(int?[] treeArr)
    {
        if (treeArr == null || treeArr.Length == 0 || treeArr[0] == null)
        {
            return null;
        }

        TreeNode root = new TreeNode(treeArr[0].Value);
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int i = 1;
        var isOk = () => i < treeArr.Length && queue.Count > 0;

        while (isOk())
        {
            TreeNode node = queue.Dequeue();

            if (i < treeArr.Length)
            {
                if(treeArr[i] != null)
                {
                    node.left = new TreeNode(treeArr[i].Value);
                    queue.Enqueue(node.left);
                }
                i++;
            }

            if (i < treeArr.Length)
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
