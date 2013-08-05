using System.Collections.Generic;

namespace MazeBuilder
{
   public class DisjointSet
   {
      private readonly List<int> nodes;

      public DisjointSet(int numberOfNodes)
      {
         nodes = new List<int>(numberOfNodes);

         for (var i = 0; i < numberOfNodes; i++)
            nodes.Add(-1);
      }

      public int Find(int otherNode)
      {
         return nodes[otherNode] < 0 ? otherNode : Find(nodes[otherNode]);
      }

      public void Union(int node1, int node2)
      {
         if (nodes[node1] > nodes[node2])
         {
            nodes[node1] = node2;
            nodes[node2]--;
         }
         else
         {
            nodes[node2] = node1;
            nodes[node1]--;
         }
      }

      public int this[int i]
      {
         get { return nodes[i]; }
         set { nodes[i] = value; }
      }
   }
}
