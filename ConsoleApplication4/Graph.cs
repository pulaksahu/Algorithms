using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Graph
    {
        public Vertex CloneVertex(Vertex node, Dictionary<Vertex, Vertex> map)
        {
            if (map.ContainsKey(node))
                return map[node];

            Vertex clone = new Vertex(node.Val);
            map.Add(node, clone);

            foreach(Vertex n in node.Neighbors)
            {
                clone.Neighbors.Add(CloneVertex(n, map));
            }
            return clone;            
        }


    }

    /// <summary>
    /// This is adjacency list or adjacency set
    /// </summary>
    public class Vertex
    {
        public Vertex()
        { }

        public Vertex(int data)
        {
            this.Val = data;
        }

        public int Val { get; set; }
        
        // Set of all vertices to which you can traverse from the current node
        // Edge exists from the current node the neighboring vertices
        // Directed/undirected graph can be represented like this
        public HashSet<Vertex> Neighbors { get; set; }
    }
}
