using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertShift
{
    public class Graph
    {
        private List<GraphNode> MyGraph;
        private bool isWeighted;
        public Graph(bool inputIsWeighted)
        {
            MyGraph = new List<GraphNode>();
            isWeighted = inputIsWeighted;
        }
        public GraphNode AddNode(string Value)
        {
            GraphNode newNode = new GraphNode(Value);
            MyGraph.Add(newNode);
            return newNode;
        }

        public void AddEdge(GraphNode First, GraphNode Second, int weight)
        {
            if (!this.isWeighted)
            {
                weight = -1; 
            }
            First.AddEdge(Second, weight);
        }

        public List<GraphNode> GetNodes()
        {
            if (MyGraph.Count == 0)
            {
                return null;
            }
            else
            {
                return MyGraph;

            }
        }
        public GraphNode GetNodeByValue(string Value)
        {
            foreach (GraphNode node in MyGraph)

            {
                if (node.Value == Value)
                {
                    return node;
                }
            }
            return null;
        }
        public List<Edge> GetNeighbors(GraphNode node)
        {
            return MyGraph.Find(v => v.Value == node.Value).Edges;
        }
        public int Size()
        {
            return MyGraph.Count();
        }

        public static int? BusinessTrip(Graph graph, string[] cities)
        {
            if (cities.Length < 2)
            {
                return null; 
            }

            int totalCost = 0;

            for (int i = 0; i < cities.Length - 1; i++)
            {
                Graph.GraphNode startNode = graph.GetNodeByValue(cities[i]);
                Graph.GraphNode endNode = graph.GetNodeByValue(cities[i + 1]);

                if (startNode != null && endNode != null)
                {
                    bool pathFound = false;

                    foreach (Graph.Edge edge in startNode.Edges)
                    {
                        if (edge.GetEnd() == endNode)
                        {
                            totalCost += edge.GetWeight();
                            pathFound = true;
                            break;
                        }
                    }

                    if (!pathFound)
                    {
                        return null; 
                    }
                }
                else
                {
                    return null; 
                }
            }

            return totalCost;
        }

        public class GraphNode
        {
            public string Value { get; set; }
            public List<Edge> Edges;

            public GraphNode(string value)
            {
                Value = value;
                Edges = new List<Edge>();
            }
            public void AddEdge(GraphNode endNode, int weight)
            {
                this.Edges.Add(new Edge(this, endNode, weight));
            }

        }

        public class Edge
        {
            private GraphNode start;
            private GraphNode end;
            private int weight;

            public Edge(GraphNode startNode, GraphNode endNode, int Weight)
            {
                start = startNode;
                end = endNode;
                weight = Weight;
            }

            public GraphNode GetStart()
            {
                return this.start;
            }

            public GraphNode GetEnd()
            {
                return this.end;
            }
            public int GetWeight()
            {
                return this.weight;
            }

        }
    }
}

