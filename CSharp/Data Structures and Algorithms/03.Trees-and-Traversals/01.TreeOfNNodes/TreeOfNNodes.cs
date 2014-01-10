/*You are given a tree of N nodes represented
 * as a set of N-1 pairs of nodes (parent node, child node),
 * each in the range (0..N-1). ...*/

namespace TreeOfNNodes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class TreeOfNNodes
    {
        private static Node<int>[] nodes;

        static void Main()
        {
            // input set it
            Console.SetIn(new System.IO.StreamReader("input.txt"));

            int N = int.Parse(Console.ReadLine());
            nodes = new Node<int>[N];

            for (int i = 0; i < N; i++)
            {
                nodes[i] = new Node<int>(i);
            }

            for (int i = 0; i < N -1; i++)
            {
                string input = Console.ReadLine();
                var rawData = input.Split(' ');

                int parrent = int.Parse(rawData[0]);
                int child = int.Parse(rawData[1]);

                nodes[parrent].Children.Add(nodes[child]);
                nodes[child].HasParent = true;
            }


            // a) find the root of the tree
            var root = FindRootNode(nodes);
            Console.WriteLine("The root of the tree is: {0}", root.Value);

            // b) find all leafes in tree
            List<Node<int>> leafes = FindAllLeafes(nodes);
            Console.Write("The leafes are: ");
            foreach (var leaf in leafes)
            {
                Console.Write("{0} ", leaf.Value);
            }
            Console.WriteLine();

            // c) find all middle nodes
            Console.Write("The middle nodes are: ");
            List<Node<int>> middleNodes = FindMiddleNodes(nodes);
            foreach (var node in middleNodes)
            {
                Console.Write("{0} ", node.Value);
            }
            Console.WriteLine();

            // d) find longest path in tree
            Console.Write("The longest path in the tree is: {0}", FindLongestPath(FindRootNode(nodes)));
            Console.WriteLine();

            // e) * all paths in the tree with given sum S of their nodes
            FindPathWithSumS(9);
           
        }

        private static List<Node<int>> FindMiddleNodes(Node<int>[] nodes)
        {
            var middleNodes = new List<Node<int>>();
            foreach (var node in nodes)
            {
                if(node.HasParent && node.Children.Count > 0)
                {
                    middleNodes.Add(node);
                }                    
            }

            return middleNodes;
        }

        private static Node<int> FindRootNode(Node<int>[] nodes)
        {
            
            if(nodes.Length == 1)
            {
                return nodes[0];
            }

            foreach (var node in nodes)
            {
                if (!node.HasParent)
                    return node;
            }

            return new Node<int>(0);
        }

        private static List<Node<int>> FindAllLeafes (Node<int>[] nodes)
        {
            List<Node<int>> leafes = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                    leafes.Add(node);
            }

            return leafes;
        }

        private static int FindLongestPath(Node<int> root)
        {
            if (root.Children.Count == 0)
            {
                return 0;
            }

            int maxPath = 0;
            foreach (var node in root.Children)
            {
                maxPath = Math.Max(maxPath, FindLongestPath(node));
            }

            return maxPath + 1;
        }

        private static void FindPathWithSumS(int desiredSum)
        {
            List<Node<int>> bufferList = new List<Node<int>>();
            List<List<Node<int>>> allPaths = new List<List<Node<int>>>();
            FindPaths(FindRootNode(nodes), bufferList, allPaths);
            bool exists = false;
            var sb = new StringBuilder();
            foreach (var path in allPaths)
            {
                int sum = 0;
                for (int i = 0; i < path.Count; i++)
                {
                    sum += path[i].Value;
                }
                if(desiredSum == sum)
                {
                    
                    exists = true;
                    for (int i = 0; i < path.Count; i++ )
                    {
                        sb.AppendFormat("{0} ", path[i].Value);
                    }
                    sb.AppendLine();
                }
            }

            if(exists)
            {
                Console.WriteLine("Paths with sum {0}:", desiredSum);
                Console.WriteLine(sb.ToString());
            }
            else
            {
                Console.WriteLine("No path has sum of {0}", desiredSum);
            }
        }

        private static void FindPaths(Node<int> root, List<Node<int>> current, List<List<Node<int>>> allCombos)
        {
            
            current.Add(root);
            root.Marked = true;
            foreach (var child in root.Children)
            {
                FindPaths(child, current, allCombos);
            }
            
            if(root.Children.Count == 0)
            {
                List<Node<int>> buffer = new List<Node<int>>();
                foreach (var item in current)
                {
                    buffer.Add(item);
                }
                allCombos.Add(buffer);
            }

            current.RemoveAt(current.Count - 1);

        }
    }
}
