using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTech_DFS_BranchesTask
{
    public class Branch
    {
        // this (id) was added to make each node in the branch unique, so as to be identified in the (visited) array in DFS code
        public int id { get; set; } 
        public List<Branch> branches { get; set; }

        public Branch()
        {
            id = CurrentId.Id++;
            branches = new List<Branch>();
        }
    }
}
