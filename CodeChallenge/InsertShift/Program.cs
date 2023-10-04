using System;
using System.Collections.Generic;
using System.Linq;


namespace InsertShift
{


    public class Program
    {


        public static List<List<string>> LeftJoin(Dictionary<string, string> synonyms, Dictionary<string, string> antonyms)
        {
            List<List<string>> result = synonyms.Keys.Select(key =>
            {
                string synonymValue = synonyms[key];
                string antonymValue = antonyms.TryGetValue(key, out string value) ? value : null;
                return new List<string> { key, synonymValue, antonymValue };
            }).ToList();

            return result;
        }


        static void Main(string[] args)
        {

            Graph graph = new Graph(true);

            // Add nodes
            Graph.GraphNode nodeA = graph.AddNode("A");
            Graph.GraphNode nodeB = graph.AddNode("B");
            Graph.GraphNode nodeC = graph.AddNode("C");
            Graph.GraphNode nodeD = graph.AddNode("D");
            Graph.GraphNode nodeE = graph.AddNode("E");

            // Add weighted edges
            graph.AddEdge(nodeA, nodeB, 3);
            graph.AddEdge(nodeA, nodeC, 2);
            graph.AddEdge(nodeB, nodeD, 1);
            graph.AddEdge(nodeC, nodeE, 4);
            graph.AddEdge(nodeD, nodeE, 2);


            List<Graph.GraphNode> visitedNodes = graph.DepthFirst(nodeA);

            // Display the collection
            Console.WriteLine("Depth-First Traversal:");
            foreach (Graph.GraphNode node in visitedNodes)
            {
                Console.WriteLine(node.Value);
            }

            List<Graph.GraphNode> visitedNodesInBreadth = graph.BreadthFirst(nodeA);

            // Display the visited nodes
            //Console.WriteLine("Breadth-Visited Nodes:");
            //foreach (Graph.GraphNode node in visitedNodesInBreadth)
            //{
            //    Console.WriteLine(node.Value);
            //}

            // Print out nodes
            //Console.WriteLine("Nodes:");
            //foreach (var node in graph.GetNodes())
            //{
            //    Console.WriteLine(node.Value);
            //}   


            //Console.WriteLine("\nNeighbors of C:");
            //foreach (var edge in graph.GetNeighbors(nodeC))
            //{
            //    Console.WriteLine($"{edge.GetEnd().Value} (Weight: {edge.GetWeight()})");
            //}


            //Graph.GraphNode nodeCFound = graph.GetNodeByValue("K");
            //if (nodeCFound != null)
            //{
            //    Console.WriteLine($"\nNode with value 'K' found.");
            //}
            //else
            //{
            //    Console.WriteLine("\nNode with value 'K' not found.");
            //}


            //int size = graph.Size();
            //Console.WriteLine($"\nSize of the graph: {size}");


        //    Graph.GraphNode metroville = graph.AddNode("Metroville");
        //    Graph.GraphNode pandora = graph.AddNode("Pandora");
        //    Graph.GraphNode arendelle = graph.AddNode("Arendelle");
        //    Graph.GraphNode newMonstropolis = graph.AddNode("New Monstropolis");
        //    Graph.GraphNode naboo = graph.AddNode("Naboo");

        //    graph.AddEdge(metroville, pandora, 82);
        //    graph.AddEdge(metroville, newMonstropolis, 105);
        //    graph.AddEdge(pandora, arendelle, 99);
        //    graph.AddEdge(newMonstropolis, arendelle, 42);
        //    graph.AddEdge(newMonstropolis, naboo, 73);
        //    graph.AddEdge(arendelle, naboo, 37);

        //    string[][] testCases = new string[][] {
        //    new string[] {"Metroville", "Pandora" },
        //    new string[] {"Arendelle", "New Monstropolis", "Naboo" },
        //    new string[] {"Naboo", "Pandora" },
        //    new string[] {"Narnia", "Arendelle", "Naboo" },
        //    new string[] {"Metroville", "New Monstropolis", "Naboo" },
        //    new string[] {"Arendelle", "Pandora" },
        //    new string[] {"Naboo", "Arendelle", "New Monstropolis" }
        //};

        //    foreach (string[] testCase in testCases)
        //    {
        //        int? cost = Graph.BusinessTrip(graph, testCase);
        //        Console.WriteLine($"Trip from {string.Join(" -> ", testCase)}: {(cost.HasValue ? "$" + cost : "null")}");
        //    }
        }
    }

    public class KeyValue
    {
        public string Key { get; set; }
        public object Value { get; set; }
    }

    public class Hashtable
    {
        public const int Size = 100;
        public List<List<KeyValue>> table;

        public Hashtable()
        {
            table = new List<List<KeyValue>>(Size);
            for (int i = 0; i < Size; i++)
            {
                table.Add(new List<KeyValue>());
            }
        }

        public int CalculateHash(string key)
        {
            int hash = 0;
            foreach (char c in key)
            {
                hash += c;
            }
            return hash % Size;
        }

        public void Set(string key, object value)
        {
            int index = CalculateHash(key);
            List<KeyValue> bucket = table[index];

            foreach (var kvp in bucket)
            {
                if (kvp.Key == key)
                {
                    kvp.Value = value;
                    return;
                }
            }

            bucket.Add(new KeyValue { Key = key, Value = value });
        }

        public object Get(string key)
        {
            int index = CalculateHash(key);
            List<KeyValue> bucket = table[index];

            foreach (var kvp in bucket)
            {
                if (kvp.Key == key)
                {
                    return kvp.Value;
                }
            }

            return null;
        }

        public bool Has(string key)
        {
            int index = CalculateHash(key);
            List<KeyValue> bucket = table[index];

            foreach (var kvp in bucket)
            {
                if (kvp.Key == key)
                {
                    return true;
                }
            }

            return false;
        }

        public List<string> Keys()
        {
            List<string> keys = new List<string>();

            foreach (var bucket in table)
            {
                foreach (var kvp in bucket)
                {
                    keys.Add(kvp.Key);
                }
            }

            return keys;
        }

    }
}