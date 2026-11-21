using Utils.Tree;

namespace Problems.Easy.SameTree_100;

public class Solution : ITask
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        bool isEqual = true;

        if (p == null || q == null)
        {
            if (p == null && q == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        if (p.val != q.val)
        {
            isEqual = false;
        }

        if (IsSameTree(p.left, q.left) == false || IsSameTree(p.right, q.right) == false)
        {
            isEqual = false;
        }

        return isEqual;
    }

    public void Run()
    {
        throw new NotImplementedException();
    }
}
