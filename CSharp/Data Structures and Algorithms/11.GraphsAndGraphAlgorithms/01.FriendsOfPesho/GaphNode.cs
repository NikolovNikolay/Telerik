using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GraphNode : IComparable<GraphNode>
{
    private Dictionary<int, double> edges;    

    public GraphNode(int name, double distance)
    {
        this.edges = new Dictionary<int, double>();
        this.Name = name;
        this.Distance = distance;
        this.Processed = false;
    }

    public int Name { get; set; }

    public bool Processed { get; set; }

    public double Distance { get; set; }

    public bool IsHospital { get; set; }

    public Dictionary<int, double> Edges
    {
        get
        {
            return this.edges;
        }
    }

    public void AddEdge(int to, double value)
    {
        this.edges.Add(to, value);
    }

    public int CompareTo(GraphNode other)
    {
        return this.Distance.CompareTo(other.Distance);
    }
}