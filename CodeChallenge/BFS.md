# Breadth First Tree
This C# code demonstrates the Breadth-First Search (BFS) traversal algorithm on a binary tree. The BFS algorithm is used to traverse a binary tree level by level,
visiting all nodes at the current level before moving to the next level.

<hr>

## White Board:

![Screenshot 2023-08-05 233809](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/27b8914c-e949-4282-af92-04fac68d3071)

## Code Explanation

 The BFS method takes a Node representing the root of the binary tree as an argument. It performs the BFS traversal by utilizing a Queue to visit nodes level by level.

1- A Queue<Node> named queue is initialized to hold the nodes to be visited.

2- A List<int> named results is initialized to store the values encountered during the traversal.

3- The root node is enqueued to the queue to initiate the traversal.

4- While the queue is not empty, nodes are dequeued one by one.

5- The value of the dequeued node is added to the results list.

6- If the dequeued node has a left child, it is enqueued to the queue.

7- If the dequeued node has a right child, it is enqueued to the queue.

8- Once all nodes have been visited, the results list containing the BFS traversal order is returned.
