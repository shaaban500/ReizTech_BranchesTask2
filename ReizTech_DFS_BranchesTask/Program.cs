
namespace ReizTech_DFS_BranchesTask
{
    public static class Program
    {

        static void Main(string[] args)
        {
            // this is a simple example, You can try another one if you would like :)
            var tree1 = new Branch();
            var tree2 = new Branch();
            var tree3 = new Branch();
            var tree4 = new Branch();
            var tree5 = new Branch();
          
            tree1.branches.Add(tree2);
            tree2.branches.Add(tree3);
            tree2.branches.Add(tree4);
            tree4.branches.Add(tree5);

            var maxDepth = new MaxDepth();
            maxDepth.DFS(tree1);
            Console.WriteLine("Max depth is:" + maxDepth.maxLength);

        }
    }
}
