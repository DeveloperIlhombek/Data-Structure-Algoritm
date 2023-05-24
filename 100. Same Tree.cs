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
    public bool IsSameTre(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
            return true;

        if (p == null || q == null || q.val != p.val)
            return false;

        return (IsSameTre(p.left, q.left) && IsSameTre(p.right, q.right));
    }
}
public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        TreeNode p = new TreeNode(1);
        p.left = new TreeNode(2);
        p.right = new TreeNode(3);

        TreeNode q = new TreeNode(1);
        q.left = new TreeNode(7);
        q.right = new TreeNode(1);

        bool result = solution.IsSameTre(p, q);
        Console.WriteLine(result);
    }
}