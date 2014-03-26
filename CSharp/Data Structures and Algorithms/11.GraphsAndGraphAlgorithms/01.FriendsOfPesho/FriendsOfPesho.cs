using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FriendsOfPesho
{
    private static Graph town = new Graph();
    private static HashSet<int> hosps = new HashSet<int>();

    public static void Main()
    {
        // Getting the data from console input
        var parsedInput = GetInputData();
        var allNodes = parsedInput[0];
        var allEdges = parsedInput[1];
        var allHospitals = parsedInput[2];

        // Adding one fictiocious node to the graph, so we could easily work with indices
        town.Elements.Add(0, new GraphNode(0, 0));

        // Building the graph, creating nodes, with connections between them
        AddingNodesAndEdges(town, allEdges);

        // Calculating the minimum distance, using the Dijkstra algorithm 
        // (the method provides a graph, from which the minimal distance can be calculated)
        double minimumDistance = SolveWithDijkstra();

        // Print result
        Console.WriteLine(minimumDistance);
    }

    // Dijkstra algorithm with priority queue (changes values in static graph)
    public static Graph Dijkstra(Graph graph, GraphNode source)
    {
        PriorityQueue<GraphNode> q = new PriorityQueue<GraphNode>();
        source.Distance = 0;
        q.Enque(source);

        while (q.Count != 0)
        {
            var current = q.Deque();

            foreach (var v in current.Edges)
            {
                var alt = current.Distance + v.Value;
                if (alt < graph.Elements[v.Key].Distance)
                {
                    graph.Elements[v.Key].Distance = alt;
                    q.Enque(graph.Elements[v.Key]);
                }
            }
        }

        return graph;
    }

    // Method that uses the Dijkstra algorithm. After calculating the minimal distance
    // the the default values in the static graph are brought back, because of the next cycle
    public static double SolveWithDijkstra()
    {
        double min = double.PositiveInfinity;
        int count = 0;
        foreach (var hospital in hosps)
        {
            double res = 0;
            var result = Dijkstra(town, town.Elements[hospital]);
            for (int i = 1; i < result.Elements.Count; i++)
            {
                if (!hosps.Contains(result.Elements[i].Name))
                {
                    res += result.Elements[i].Distance;
                }
            }

            if (min > res)
            {
                min = res;
            }
            count++;

            if (count == hosps.Count)
            {
                break;
            }

            foreach (var node in town.Elements)
            {
                node.Value.Distance = double.PositiveInfinity;
            }
        }

        return min;
    }

    // Parsing the data from the console input
    public static int[] GetInputData()
    {
        var firstLineInput = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        var hospitals = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

        for (int i = 0; i < hospitals.Length; i++)
        {
            hosps.Add(hospitals[i]);
        }

        return firstLineInput;
    }

    // Building the graph
    public static void AddingNodesAndEdges(Graph town, int allEdges)
    {
        for (int i = 0; i < allEdges; i++)
        {
            var line = Console.ReadLine();
            var temp = line.Split(' ').Select(x => int.Parse(x)).ToArray();

            if (!town.Elements.ContainsKey(temp[0]))
            {
                town.Add(new GraphNode(temp[0], double.PositiveInfinity));
            }

            if (!town.Elements.ContainsKey(temp[1]))
            {
                town.Add(new GraphNode(temp[1], double.PositiveInfinity));
            }

            town.Elements[temp[0]].AddEdge(temp[1], (double)temp[2]);
            town.Elements[temp[1]].AddEdge(temp[0], (double)temp[2]);
        }
    }
}