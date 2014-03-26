using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Graph
{
    private Dictionary<int, GraphNode> elements;

    public Graph()
    {
        this.elements = new Dictionary<int, GraphNode>();
    }

    public Dictionary<int, GraphNode> Elements
    {
        get
        {
            return this.elements;
        }
    }

    public int Count
    {
        get
        {
            return this.elements.Count;
        }
    }

    public void Add(GraphNode node)
    {
        this.elements.Add(node.Name, node);
    }
}