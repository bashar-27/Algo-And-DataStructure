using InsertShift;

namespace TreeTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestPreOrderTrue()
        {
            BinarySearchTree testTree = new BinarySearchTree();
            testTree.root = new Node(1);
            testTree.root.left = new Node(2);
            testTree.root.right = new Node(3);
            testTree.root.left.left = new Node(4);
            testTree.root.left.right = new Node(5);
            List<int> expected = new List<int> { 1, 2, 4, 5, 3 };
            Assert.Equal(expected, testTree.PreOrder(testTree.root));
        }

        [Fact]
        public void TestPreOrderNull()
        {
            BinarySearchTree testTree = new BinarySearchTree();
          
            List<int> expected = new List<int> { };
            Assert.Equal(expected, testTree.PreOrder(testTree.root));
        }

        [Fact]
        public void TestPreOrderFalse()
        {
            BinarySearchTree testTree = new BinarySearchTree();
           
            testTree.root = new Node(1);
            testTree.root.left = new Node(2);
            testTree.root.right = new Node(3);
            testTree.root.left.left = new Node(4);
            testTree.root.left.right = new Node(5);
            List<int> notExpected = new List<int> { 1, 2, 3, 4, 5 };
            Assert.NotEqual(notExpected, testTree.PreOrder(testTree.root));
        }

    }

    public class InOrderTraversalTests
    {
        [Fact]
        public void TestInOrder()
        {
            BinarySearchTree testTree = new BinarySearchTree();
            testTree.root = new Node(1);
            testTree.root.left = new Node(2);
            testTree.root.right = new Node(3);
            testTree.root.left.left = new Node(4);
            testTree.root.left.right = new Node(5);
            List<int> expected = new List<int> { 4, 2, 5, 1, 3 };
            Assert.Equal(expected, testTree.InOrder(testTree.root));
        }

        [Fact]
        public void TestInOrderNull()
        {
            BinarySearchTree testTree = new BinarySearchTree();
           
            List<int> expected = new List<int> { };
            Assert.Equal(expected, testTree.InOrder(testTree.root));
        }

        [Fact]
        public void TestInOrderFalse()
        {
            BinarySearchTree testTree = new BinarySearchTree();
        
            testTree.root = new Node(1);
            testTree.root.left = new Node(2);
            testTree.root.right = new Node(3);
            testTree.root.left.left = new Node(4);
            testTree.root.left.right = new Node(5);
            List<int> notExpected = new List<int> { 1, 2, 3, 4, 5 };
            Assert.NotEqual(notExpected, testTree.InOrder(testTree.root));
        }
    }

    public class PostOrderTraversalTests
    {
        [Fact]
        public void TestPostOrder()
        {
            BinarySearchTree testTree = new BinarySearchTree();
       
            testTree.root = new Node(1);
            testTree.root.left = new Node(2);
            testTree.root.right = new Node(3);
            testTree.root.left.left = new Node(4);
            testTree.root.left.right = new Node(5);
            List<int> expected = new List<int> { 4, 5, 2, 3, 1 };
            Assert.Equal(expected, testTree.PostOrder(testTree.root));
        }

        [Fact]
        public void TestPostOrderNull()
        {
            BinarySearchTree testTree = new BinarySearchTree();
            List<int> expected = new List<int> { };
            Assert.Equal(expected, testTree.PostOrder(testTree.root));
        }

        [Fact]
        public void TestPostOrderFalse()
        {
            BinarySearchTree testTree = new BinarySearchTree();
        
            testTree.root = new Node(1);
            testTree.root.left = new Node(2);
            testTree.root.right = new Node(3);
            testTree.root.left.left = new Node(4);
            testTree.root.left.right = new Node(5);
            List<int> notExpected = new List<int> { 1, 2, 3, 4, 5 };
            Assert.NotEqual(notExpected, testTree.PostOrder(testTree.root));
        }
    }

}

public class BinarySearchTreeTests
{
    public class AddMethodTests
    {
        [Fact]
        public void TestAdd()
        {
            BinarySearchTree testTree = new BinarySearchTree();
            testTree.Add(100);
            Assert.Equal(100, testTree.root.Data);
        }

        [Fact]
        public void TestAddOrder()
        {
            BinarySearchTree testTree = new BinarySearchTree();
            testTree.root = new Node(5);
            testTree.Add(1);
            Assert.Equal(1, testTree.root.left.Data);

        }

        [Fact]
        public void TestMultiAddOrder()
        {
            BinarySearchTree testTree = new BinarySearchTree();
            testTree.Add(100);
            testTree.Add(50);
            testTree.Add(200);
            testTree.Add(25);
            testTree.Add(75);
            testTree.Add(150);
            testTree.Add(300);
            testTree.Add(60);
            testTree.Add(90);
            testTree.Add(342);
            List<int> expected = new List<int> { 100, 50, 25, 75, 60, 90, 200, 150, 300, 342 };
            IList<int> results = testTree.PreOrder(testTree.root);
            Assert.Equal(expected, results);
        }
    }

    public class ContainsMethodTests
    {
        [Fact]
        public void TestTrue()
        {
            BinarySearchTree testTree = new BinarySearchTree();
            testTree.Add(100);
            testTree.Add(50);
            testTree.Add(200);
            testTree.Add(25);
            testTree.Add(75);
            testTree.Add(150);
            Assert.True(testTree.Contains(25));
        }

        [Fact]
        public void TestFalse()
        {
            BinarySearchTree testTree = new BinarySearchTree();
            testTree.Add(100);
            testTree.Add(50);
            testTree.Add(200);
            testTree.Add(25);
            testTree.Add(75);
            testTree.Add(150);
            Assert.False(testTree.Contains(400));
        }

        [Fact]
        public void TestEmptyTree()
        {
            BinarySearchTree testTree = new BinarySearchTree();
            Assert.False(testTree.Contains(5));
        }
        private BinarySearchTree CreateBinarySearchTree()
        {
            BinarySearchTree testTree = new BinarySearchTree();
            testTree.Add(100);
            testTree.Add(50);
            testTree.Add(200);
            testTree.Add(25);
            testTree.Add(75);
            testTree.Add(150);
            testTree.Add(300);
            testTree.Add(60);
            testTree.Add(90);
            testTree.Add(342);
            return testTree;
        }

        [Fact]
        public void HappyPath()
        {
            // Arrange
            BinarySearchTree testTree = CreateBinarySearchTree();

            // Act
            int result = testTree.Max_tree();

            // Assert
            Assert.Equal(342, result);
        }

        [Fact]
        public void Max_tree_TreeIsEmpty()
        {
            // Arrange
            BinarySearchTree testTree = new BinarySearchTree();

            // Act
            int result = testTree.Max_tree();

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Max_tree_WhenSingleNodeTree()
        {
            // Arrange
            BinarySearchTree testTree = new BinarySearchTree();
            testTree.Add(42);

            // Act
            int result = testTree.Max_tree();

            // Assert
            Assert.Equal(42, result);
        }
        [Fact]
        public void BFStest()
        {


            BinarySearchTree binaryTree = new BinarySearchTree();
            binaryTree.AddBFS(2);
            binaryTree.AddBFS(7);
            binaryTree.AddBFS(5);
            binaryTree.AddBFS(2);
            binaryTree.AddBFS(6);
            binaryTree.AddBFS(9);
            binaryTree.AddBFS(5);
            binaryTree.AddBFS(11);
            binaryTree.AddBFS(4);

            List<int> result = binaryTree.BFS(binaryTree.root);


            List<int> expected = new List<int> { 2, 7, 5, 2, 6, 9, 5, 11, 4 };
            Assert.Equal(expected, result);
        }
        [Fact]
        public void FizzBuzzTest()
        {


            BinarySearchTree binaryTree = new BinarySearchTree();

            binaryTree.AddBFS(5);
            binaryTree.AddBFS(11);
            binaryTree.AddBFS(9);
            binaryTree.AddBFS(7);
            binaryTree.AddBFS(30);
            binaryTree.AddBFS(4);
            binaryTree.AddBFS(88);

            List<string> result = Program.FizzBuzzTree(binaryTree);


            List<string> expected = new List<string> { "Buzz", "11", "7", "4", "88", "FizzBuzz", "Fizz" };
            Assert.Equal(expected, result);
        }
    
      
            [Theory]
            [InlineData(new[] { 55, 21, 8, 99, 45, 33 }, new[] { 8, 21, 33, 45, 55, 99 })]
            [InlineData(new[] { 17, 42, 9, 77, 28 }, new[] { 9, 17, 28, 42, 77 })]
            [InlineData(new[] { 2, 11, 6, 1, 9, 3 }, new[] { 1, 2, 3, 6, 9, 11 })]
            public void TestInsertionSort(int[] input, int[] expectedOutput)
            {
                // Arrange

                // Act
                int[] sortedArray = Program.InsertionSort(input);

                // Assert
                Assert.Equal(expectedOutput, sortedArray);
            }


        }
    }

