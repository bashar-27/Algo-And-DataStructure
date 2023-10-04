using InsertShift;

namespace TreeTest
{
    public class UnitTest1
    {
        //        [Fact]
        //        public void TestPreOrderTrue()
        //        {
        //            BinarySearchTree testTree = new BinarySearchTree();
        //            testTree.root = new Node(1);
        //            testTree.root.left = new Node(2);
        //            testTree.root.right = new Node(3);
        //            testTree.root.left.left = new Node(4);
        //            testTree.root.left.right = new Node(5);
        //            List<int> expected = new List<int> { 1, 2, 4, 5, 3 };
        //            Assert.Equal(expected, testTree.PreOrder(testTree.root));
        //        }

        //        [Fact]
        //        public void TestPreOrderNull()
        //        {
        //            BinarySearchTree testTree = new BinarySearchTree();

        //            List<int> expected = new List<int> { };
        //            Assert.Equal(expected, testTree.PreOrder(testTree.root));
        //        }

        //        [Fact]
        //        public void TestPreOrderFalse()
        //        {
        //            BinarySearchTree testTree = new BinarySearchTree();

        //            testTree.root = new Node(1);
        //            testTree.root.left = new Node(2);
        //            testTree.root.right = new Node(3);
        //            testTree.root.left.left = new Node(4);
        //            testTree.root.left.right = new Node(5);
        //            List<int> notExpected = new List<int> { 1, 2, 3, 4, 5 };
        //            Assert.NotEqual(notExpected, testTree.PreOrder(testTree.root));
        //        }

        //    }

        //    public class InOrderTraversalTests
        //    {
        //        [Fact]
        //        public void TestInOrder()
        //        {
        //            BinarySearchTree testTree = new BinarySearchTree();
        //            testTree.root = new Node(1);
        //            testTree.root.left = new Node(2);
        //            testTree.root.right = new Node(3);
        //            testTree.root.left.left = new Node(4);
        //            testTree.root.left.right = new Node(5);
        //            List<int> expected = new List<int> { 4, 2, 5, 1, 3 };
        //            Assert.Equal(expected, testTree.InOrder(testTree.root));
        //        }

        //        [Fact]
        //        public void TestInOrderNull()
        //        {
        //            BinarySearchTree testTree = new BinarySearchTree();

        //            List<int> expected = new List<int> { };
        //            Assert.Equal(expected, testTree.InOrder(testTree.root));
        //        }

        //        [Fact]
        //        public void TestInOrderFalse()
        //        {
        //            BinarySearchTree testTree = new BinarySearchTree();

        //            testTree.root = new Node(1);
        //            testTree.root.left = new Node(2);
        //            testTree.root.right = new Node(3);
        //            testTree.root.left.left = new Node(4);
        //            testTree.root.left.right = new Node(5);
        //            List<int> notExpected = new List<int> { 1, 2, 3, 4, 5 };
        //            Assert.NotEqual(notExpected, testTree.InOrder(testTree.root));
        //        }
        //    }

        //    public class PostOrderTraversalTests
        //    {
        //        [Fact]
        //        public void TestPostOrder()
        //        {
        //            BinarySearchTree testTree = new BinarySearchTree();

        //            testTree.root = new Node(1);
        //            testTree.root.left = new Node(2);
        //            testTree.root.right = new Node(3);
        //            testTree.root.left.left = new Node(4);
        //            testTree.root.left.right = new Node(5);
        //            List<int> expected = new List<int> { 4, 5, 2, 3, 1 };
        //            Assert.Equal(expected, testTree.PostOrder(testTree.root));
        //        }

        //        [Fact]
        //        public void TestPostOrderNull()
        //        {
        //            BinarySearchTree testTree = new BinarySearchTree();
        //            List<int> expected = new List<int> { };
        //            Assert.Equal(expected, testTree.PostOrder(testTree.root));
        //        }

        //        [Fact]
        //        public void TestPostOrderFalse()
        //        {
        //            BinarySearchTree testTree = new BinarySearchTree();

        //            testTree.root = new Node(1);
        //            testTree.root.left = new Node(2);
        //            testTree.root.right = new Node(3);
        //            testTree.root.left.left = new Node(4);
        //            testTree.root.left.right = new Node(5);
        //            List<int> notExpected = new List<int> { 1, 2, 3, 4, 5 };
        //            Assert.NotEqual(notExpected, testTree.PostOrder(testTree.root));
        //        }
        //    }

        //}

        //public class BinarySearchTreeTests
        //{
        //    public class AddMethodTests
        //    {
        //        [Fact]
        //        public void TestAdd()
        //        {
        //            BinarySearchTree testTree = new BinarySearchTree();
        //            testTree.Add(100);
        //            Assert.Equal(100, testTree.root.Data);
        //        }

        //        [Fact]
        //        public void TestAddOrder()
        //        {
        //            BinarySearchTree testTree = new BinarySearchTree();
        //            testTree.root = new Node(5);
        //            testTree.Add(1);
        //            Assert.Equal(1, testTree.root.left.Data);

        //        }

        //        [Fact]
        //        public void TestMultiAddOrder()
        //        {
        //            BinarySearchTree testTree = new BinarySearchTree();
        //            testTree.Add(100);
        //            testTree.Add(50);
        //            testTree.Add(200);
        //            testTree.Add(25);
        //            testTree.Add(75);
        //            testTree.Add(150);
        //            testTree.Add(300);
        //            testTree.Add(60);
        //            testTree.Add(90);
        //            testTree.Add(342);
        //            List<int> expected = new List<int> { 100, 50, 25, 75, 60, 90, 200, 150, 300, 342 };
        //            IList<int> results = testTree.PreOrder(testTree.root);
        //            Assert.Equal(expected, results);
        //        }
        //    }

        //    public class ContainsMethodTests
        //    {
        //        [Fact]
        //        public void TestTrue()
        //        {
        //            BinarySearchTree testTree = new BinarySearchTree();
        //            testTree.Add(100);
        //            testTree.Add(50);
        //            testTree.Add(200);
        //            testTree.Add(25);
        //            testTree.Add(75);
        //            testTree.Add(150);
        //            Assert.True(testTree.Contains(25));
        //        }

        //        [Fact]
        //        public void TestFalse()
        //        {
        //            BinarySearchTree testTree = new BinarySearchTree();
        //            testTree.Add(100);
        //            testTree.Add(50);
        //            testTree.Add(200);
        //            testTree.Add(25);
        //            testTree.Add(75);
        //            testTree.Add(150);
        //            Assert.False(testTree.Contains(400));
        //        }

        //        [Fact]
        //        public void TestEmptyTree()
        //        {
        //            BinarySearchTree testTree = new BinarySearchTree();
        //            Assert.False(testTree.Contains(5));
        //        }
        //        private BinarySearchTree CreateBinarySearchTree()
        //        {
        //            BinarySearchTree testTree = new BinarySearchTree();
        //            testTree.Add(100);
        //            testTree.Add(50);
        //            testTree.Add(200);
        //            testTree.Add(25);
        //            testTree.Add(75);
        //            testTree.Add(150);
        //            testTree.Add(300);
        //            testTree.Add(60);
        //            testTree.Add(90);
        //            testTree.Add(342);
        //            return testTree;
        //        }

        //        [Fact]
        //        public void HappyPath()
        //        {
        //            // Arrange
        //            BinarySearchTree testTree = CreateBinarySearchTree();

        //            // Act
        //            int result = testTree.Max_tree();

        //            // Assert
        //            Assert.Equal(342, result);
        //        }

        //        [Fact]
        //        public void Max_tree_TreeIsEmpty()
        //        {
        //            // Arrange
        //            BinarySearchTree testTree = new BinarySearchTree();

        //            // Act
        //            int result = testTree.Max_tree();

        //            // Assert
        //            Assert.Equal(0, result);
        //        }

        //        [Fact]
        //        public void Max_tree_WhenSingleNodeTree()
        //        {
        //            // Arrange
        //            BinarySearchTree testTree = new BinarySearchTree();
        //            testTree.Add(42);

        //            // Act
        //            int result = testTree.Max_tree();

        //            // Assert
        //            Assert.Equal(42, result);
        //        }
        //        [Fact]
        //        public void BFStest()
        //        {


        //            BinarySearchTree binaryTree = new BinarySearchTree();
        //            binaryTree.AddBFS(2);
        //            binaryTree.AddBFS(7);
        //            binaryTree.AddBFS(5);
        //            binaryTree.AddBFS(2);
        //            binaryTree.AddBFS(6);
        //            binaryTree.AddBFS(9);
        //            binaryTree.AddBFS(5);
        //            binaryTree.AddBFS(11);
        //            binaryTree.AddBFS(4);

        //            List<int> result = binaryTree.BFS(binaryTree.root);


        //            List<int> expected = new List<int> { 2, 7, 5, 2, 6, 9, 5, 11, 4 };
        //            Assert.Equal(expected, result);
        //        }
        //        [Fact]
        //        public void FizzBuzzTest()
        //        {


        //            BinarySearchTree binaryTree = new BinarySearchTree();

        //            binaryTree.AddBFS(5);
        //            binaryTree.AddBFS(11);
        //            binaryTree.AddBFS(9);
        //            binaryTree.AddBFS(7);
        //            binaryTree.AddBFS(30);
        //            binaryTree.AddBFS(4);
        //            binaryTree.AddBFS(88);

        //            List<string> result = Program.FizzBuzzTree(binaryTree);


        //            List<string> expected = new List<string> { "Buzz", "11", "7", "4", "88", "FizzBuzz", "Fizz" };
        //            Assert.Equal(expected, result);
        //        }


        //            [Theory]
        //            [InlineData(new[] { 55, 21, 8, 99, 45, 33 }, new[] { 8, 21, 33, 45, 55, 99 })]
        //            [InlineData(new[] { 17, 42, 9, 77, 28 }, new[] { 9, 17, 28, 42, 77 })]
        //            [InlineData(new[] { 2, 11, 6, 1, 9, 3 }, new[] { 1, 2, 3, 6, 9, 11 })]
        //            public void TestInsertionSort(int[] input, int[] expectedOutput)
        //            {


        //                // Act
        //                int[] sortedArray = Program.InsertionSort(input);


        //                Assert.Equal(expectedOutput, sortedArray);
        //            }




        //        //Merge sort test
        //        [Theory]

        //        [InlineData(new[] { 8, 4, 23, 42, 16, 15 }, new[] { 4, 8, 15, 16, 23, 42 })]
        //        [InlineData(new[] { 5, 4, 3, 2, 1 }, new[] { 1, 2, 3, 4, 5 })]
        //        [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 })]
        //        [InlineData(new[] { 1 }, new[] { 1 })]
        //        [InlineData(new int[] { }, new int[] { })] // Empty arr
        //        public void MergeSort_Sorts(int[] input, int[] expected)
        //        {


        //          int []arr= Program.MergeSort(input, 0, input.Length - 1);

        //            Assert.Equal(expected, input);

        public class LeftJoinTests
        {
            [Fact]
            public void HappyPath_ShouldReturnJoinedLists()
            {
                // Arrange
                Dictionary<string, string> synonyms = new Dictionary<string, string>
        {
            { "happy", "joyful" },
            { "sad", "unhappy" },
            { "angry", "furious" }
        };

                Dictionary<string, string> antonyms = new Dictionary<string, string>
        {
            { "happy", "unhappy" },
            { "sad", "joyful" },
            { "angry", "calm" }
        };

                List<List<string>> expected = new List<List<string>>
        {
            new List<string> { "happy", "joyful", "unhappy" },
            new List<string> { "sad", "unhappy", "joyful" },
            new List<string> { "angry", "furious", "calm" }
        };

                // Act
                List<List<string>> result = Program.LeftJoin(synonyms, antonyms);

                // Assert
                Assert.Equal(expected, result);
            }

            [Fact]
            public void EdgeCase_ShouldHandleEdgeCase()
            {
                // Arrange
                Dictionary<string, string> synonyms = new Dictionary<string, string>
        {
            { "happy", "joyful" },
            { "sad", "unhappy" },
            { "angry", "furious" }
        };

                Dictionary<string, string> antonyms = new Dictionary<string, string>
        {
            { "happy", "unhappy" },
            { "sad", "joyful" },
            { "angry", "calm" },
            { "joyful", "happy" } // Adding an extra entry for an edge case
        };

                List<List<string>> expected = new List<List<string>>
        {
            new List<string> { "happy", "joyful", "unhappy" },
            new List<string> { "sad", "unhappy", "joyful" },
            new List<string> { "angry", "furious", "calm" }
        };

                // Act
                List<List<string>> result = Program.LeftJoin(synonyms, antonyms);

                // Assert
                Assert.Equal(expected, result);
            }

            [Fact]
            public void ExpectedFailure_ShouldReturnCorrectResult()
            {
                // Arrange
                Dictionary<string, string> synonyms = new Dictionary<string, string>
    {
        { "happy", "joyful" },
        { "sad", "unhappy" },
        { "angry", "furious" }
    };

                Dictionary<string, string> antonyms = new Dictionary<string, string>
    {
        { "happy", "unhappy" },
        { "sad", "joyful" },
        { "angry", "calm" }
    };

                List<List<string>> expected = new List<List<string>>
    {
        new List<string> { "happy", "joyful", "unhappy" },
        new List<string> { "sad", "happy", "joyful" }, // This line is changed
        new List<string> { "angry", "furious", "calm" }
    };

                // Act
                List<List<string>> result = Program.LeftJoin(synonyms, antonyms);

                // Assert
                Assert.NotEqual(expected, result);
            }
        }
            [Fact]
        public void SortByName()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie { Title = "The Terminator", Year = 1984 },
                new Movie { Title = "A Clockwork Orange", Year = 1971 },
                new Movie { Title = "Inception", Year = 2010 }
            };

            List<Movie> sortedMovies = Sorting.SortByName(new List<Movie>(movies));

            Assert.Equal("A Clockwork Orange", sortedMovies[0].Title);
            Assert.Equal("Inception", sortedMovies[1].Title);
            Assert.Equal("The Terminator", sortedMovies[2].Title);
        }

        [Fact]
        public void SortByYear()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie { Title = "The Terminator", Year = 1984 },
                new Movie { Title = "A Clockwork Orange", Year = 1971 },
                new Movie { Title = "Inception", Year = 2010 }
            };

            List<Movie> sortedMovies = Sorting.SortByYear(new List<Movie>(movies));

            Assert.Equal(2010, sortedMovies[0].Year);
            Assert.Equal(1984, sortedMovies[1].Year);
            Assert.Equal(1971, sortedMovies[2].Year);
        }

        [Fact]
        public void CompareTitlesReturnNegative()
        {
            int result = Sorting.CompareTitles("A Clockwork Orange", "Inception");

            Assert.True(result < 0);
        }

        [Fact]
        public void CompareTitles_ShouldReturnPositive()
        {
            int result = Sorting.CompareTitles("Inception", "A Clockwork Orange");

            Assert.True(result > 0);
        }

        [Fact]
        public void WhenTitlesAreEqual()
        {
            int result = Sorting.CompareTitles("Inception", "Inception");

            Assert.Equal(0, result);
        }
        [Fact]
        public void SettingKeyValue()
        {

            Hashtable hashtable = new Hashtable();


            hashtable.Set("name", "John");

            Assert.Equal("John", hashtable.Get("name"));
        }

        [Fact]
        public void NonExistentKeyReturnNull()
        {

            Hashtable hashtable = new Hashtable();

            object result = hashtable.Get("nonexistent");


            Assert.Null(result);
        }

        [Fact]
        public void UniqueKeys()
        {

            Hashtable hashtable = new Hashtable();
            hashtable.Set("name", "John");
            hashtable.Set("age", 30);
            hashtable.Set("city", "New York");


            List<string> keys = hashtable.Keys();


            Assert.Contains("name", keys);
            Assert.Contains("age", keys);
            Assert.Contains("city", keys);
            Assert.Equal(3, keys.Count);
        }

        [Fact]
        public void CollisionWithinHashtable()
        {

            Hashtable hashtable = new Hashtable();


            hashtable.Set("name", "John");
            hashtable.Set("eman", "Jane");


            Assert.Equal("John", hashtable.Get("name"));
            Assert.NotEqual("Jane", hashtable.Get("salim"));
        }

        [Fact]
        public void HashKeyToInRangeValue()
        {

            Hashtable hashtable = new Hashtable();


            int hash = hashtable.CalculateHash("name");


            Assert.InRange(hash, 0, Hashtable.Size - 1);
        }


        [Fact]
        public void AddNode()
        {
            // Arrange
            Graph graph = new Graph(true);

            // Act
            Graph.GraphNode node = graph.AddNode("A");

        
            Assert.NotNull(node);
            Assert.Equal("A", node.Value);
        }


        [Fact]
        public void GetNodes()
        {
            // Arrange
            Graph graph = new Graph(true);
            graph.AddNode("A");
            graph.AddNode("B");

            // Act
            var nodes = graph.GetNodes();

            // Assert
            Assert.NotNull(nodes);
            Assert.Equal(2, nodes.Count);
        }

        [Fact]
        public void GetNodeByValue()
        {
            // Arrange
            Graph graph = new Graph(true);
            Graph.GraphNode nodeA = graph.AddNode("A");
            Graph.GraphNode nodeB = graph.AddNode("B");

            // Act
            var foundNode = graph.GetNodeByValue("B");

            // Assert
            Assert.NotNull(foundNode);
            Assert.Equal(nodeB, foundNode);
        }

        [Fact]
        public void GetNeighbors()
        {
            // Arrange
            Graph graph = new Graph(true);
            Graph.GraphNode nodeA = graph.AddNode("A");
            Graph.GraphNode nodeB = graph.AddNode("B");
            graph.AddEdge(nodeA, nodeB, 3);

            // Act
            var neighbors = graph.GetNeighbors(nodeA);

            // Assert
            Assert.Single(neighbors);
            Assert.Equal(nodeB, neighbors[0].GetEnd());
            Assert.Equal(3, neighbors[0].GetWeight());
        }

        

        [Fact]
        public void ExpectedFailure()
        {
            // Arrange
            Graph graph = new Graph(true);
            Graph.GraphNode nodeA = graph.AddNode("A");
            Graph.GraphNode nodeB = graph.AddNode("B");

            // Act & Assert
            var foundNode = graph.GetNodeByValue("C"); // Attempt to find non-existent node

            Assert.Null(foundNode);
        }


        public class BusinessTripTests
        {
            // ... (previous test methods)

            [Fact]
            public void BusinessTrip()
            {
                // Arrange
                Graph graph = new Graph(true);

                Graph.GraphNode metroville = graph.AddNode("Metroville");
                Graph.GraphNode pandora = graph.AddNode("Pandora");
                Graph.GraphNode arendelle = graph.AddNode("Arendelle");
                Graph.GraphNode newMonstropolis = graph.AddNode("New Monstropolis");
                Graph.GraphNode naboo = graph.AddNode("Naboo");

                graph.AddEdge(metroville, pandora, 82);
                graph.AddEdge(metroville, newMonstropolis, 105);
                graph.AddEdge(pandora, arendelle, 99);
                graph.AddEdge(newMonstropolis, arendelle, 42);
                graph.AddEdge(newMonstropolis, naboo, 73);
                graph.AddEdge(arendelle, naboo, 37);

                string[] cities = { "Metroville", "Pandora", "Arendelle" };

              
                int? result = Graph.BusinessTrip(graph, cities);


                Assert.NotNull(result);
                Assert.Equal(181, result);
            }

            [Fact]
            public void BusinessTrip_InvalidPatl()
            {
                
                Graph graph = new Graph(true);
          

                string[] cities = { "Metroville", "Pandora", "Naboo" }; 

            
                int? result = Graph.BusinessTrip(graph, cities);

                Assert.Null(result);
            }

            [Fact]
            public void BusinessTrip_LessThanTwoCitie()
            {
             
                Graph graph = new Graph(true);
              

                string[] cities = { "Metroville" }; 

          
                int? result = Graph.BusinessTrip(graph, cities);

             
                Assert.Null(result);
            }


            [Fact]
            public void BreadthFirst1()
            {
                // Arrange
                Graph graph = new Graph(true);
                Graph.GraphNode nodeA = graph.AddNode("A");
                Graph.GraphNode nodeB = graph.AddNode("B");
                Graph.GraphNode nodeC = graph.AddNode("C");
                Graph.GraphNode nodeD = graph.AddNode("D");
                Graph.GraphNode nodeE = graph.AddNode("E");

                graph.AddEdge(nodeA, nodeB, 3);
                graph.AddEdge(nodeA, nodeC, 2);
                graph.AddEdge(nodeB, nodeD, 1);
                graph.AddEdge(nodeC, nodeE, 4);
                graph.AddEdge(nodeD, nodeE, 2);

                // Act
                List<Graph.GraphNode> visitedNodes = graph.BreadthFirst(nodeA);

                // Assert
                string result = string.Join(", ", visitedNodes.Select(node => node.Value));
                Assert.Equal("A, B, C, D, E", result);
            }

            [Fact]
            public void BreadthFirst2()
            {
                // Arrange
                Graph graph = new Graph(true);
                Graph.GraphNode nodeA = graph.AddNode("A");

                // Act
                List<Graph.GraphNode> visitedNodes = graph.BreadthFirst(nodeA);

                // Assert
                Assert.Single(visitedNodes);
                Assert.Equal("A", visitedNodes[0].Value);
            }

            [Fact]
            public void BreadthFirst3()
            {
                // Arrange
                Graph graph = new Graph(true);

                // Act
                List<Graph.GraphNode> visitedNodes = graph.BreadthFirst(null);

                // Assert
                Assert.Empty(visitedNodes);
            }
        }
        [Fact]
        public void DepthFirst1()
        {
            // Arrange
            Graph graph = new Graph(true);
            Graph.GraphNode nodeA = graph.AddNode("A");

            // Act
            List<Graph.GraphNode> visitedNodes = graph.DepthFirst(nodeA);

            // Assert
            Assert.Single(visitedNodes);
            Assert.Equal("A", visitedNodes[0].Value);
        }

        [Fact]
        public void DepthFirst2()
        {
            // Arrange
            Graph graph = new Graph(true);
            Graph.GraphNode nodeA = graph.AddNode("A");
            Graph.GraphNode nodeB = graph.AddNode("B");
            Graph.GraphNode nodeC = graph.AddNode("C");

            // Act
            List<Graph.GraphNode> visitedNodes = graph.DepthFirst(nodeA);

            // Assert
            Assert.NotEqual(3, visitedNodes.Count);
         
        }

        [Fact]
        public void DepthFirst3()
        {
            // Arrange
            Graph graph = new Graph(true);
            Graph.GraphNode nodeA = graph.AddNode("A");
            Graph.GraphNode nodeB = graph.AddNode("B");
            Graph.GraphNode nodeC = graph.AddNode("C");
            Graph.GraphNode nodeD = graph.AddNode("D");
            Graph.GraphNode nodeE = graph.AddNode("E");

            graph.AddEdge(nodeA, nodeB, 3);
            graph.AddEdge(nodeA, nodeC, 2);
            graph.AddEdge(nodeB, nodeD, 1);
            graph.AddEdge(nodeC, nodeE, 4);
            graph.AddEdge(nodeD, nodeE, 2);

            // Act
            List<Graph.GraphNode> visitedNodes = graph.DepthFirst(nodeA);

            // Assert
            Assert.Equal(5, visitedNodes.Count);
            Assert.Equal("A", visitedNodes[0].Value);
            Assert.Equal("B", visitedNodes[1].Value);
            Assert.Equal("D", visitedNodes[2].Value);
            Assert.Equal("E", visitedNodes[3].Value);
            Assert.Equal("C", visitedNodes[4].Value);
        }

    }

}

    

