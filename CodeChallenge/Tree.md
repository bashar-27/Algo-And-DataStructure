# Trees
<!-- Short summary or background information -->
Implement Binary Trees And Binary Search Trees
## Challenge
<!-- Description of the challenge -->
* Create a `Node` class that has properties for the `value` stored in the node, the `left child` node, and the `right child` node.
* Create a `BinaryTree` class
  * Define a method for each of the depth first traversals called `preOrder`, `inOrder`, and `postOrder` which returns an array of the values, ordered appropriately.
* Create a `BinarySearchTree` class
  * Define a method named `add` that accepts a value, and adds a new node with that value in the correct location in the binary search tree.
  * Define a method named `contains` that accepts a value, and returns a boolean indicating whether or not the value is in the tree at least once.

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
### Approach
* Created a  Node class.
  * Properties: Value, Left, Right  
* Created a Tree class.
  * Properties: Root 
* Created a BinaryTree class
  * Created a PreOrder method that internally creates a list to hold all of the values then recursively steps through the tree caputuring each nodes value before going left or right. The values are returned as a list.
  * Created an InOrder method that internally creates a list to hold all of the values then recursively steps through the tree caputuring each nodes value after going left and before going right. The values are returned as a list.
  * Created a PostOrder method that internally creates a list to hold all of the values then recursively steps through the tree caputuring each nodes value after going left and right. The values are returned as a list.
* Created a BinarySearchTree class
  * Created an Add method that traverses the BST until the proper leaf is found for addition
  * Created a Contains method that traverses the BST and returns a True/False if the value is found our not

### Efficiency
**BinaryTree Traversal**
Time: O(n)
Space: O(h)

**BinarySearchTree Add**
Time: O(log n)
Space: O(1)

**BinarySearchTree Contains**
Time: O(log n)
Space: O(1)

## whiteboard:


![Untitled](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/e179c4f7-e23f-471f-b9ac-968b30fd5137)

## walkthrough :



## Console Code:
![Screenshot 2023-07-30 031712](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/4e23378e-9e6e-4fcf-a1df-aa3ad0236eeb)


## test unit:

![Screenshot 2023-07-30 031702](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/404fa354-0ad3-4e48-a6b6-36a00b6474b5)



```c#
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
    }
}











```
