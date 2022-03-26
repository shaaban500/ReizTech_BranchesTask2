
namespace ReizTech_DFS_BranchesTask
{
    public class MaxDepth
    {
        public int length { get; set; }
        public int maxLength { get; set; }
        public bool[] visited;

        public MaxDepth()
        {
            length = 0;
            maxLength = 0;
            visited = new bool[100000];
        }

       
        public void DFS(Branch node)
        {
            visited[node.id] = true;

            for (int i = 0; i < node.branches.LongCount(); i++)
            {
                if (!visited[node.branches[i].id])
                {
                    length++;
                    DFS(node.branches[i]);
                    length--;
                }
            }

            if (length > maxLength)
            {
                maxLength = length;
            }
        }

    }
}
