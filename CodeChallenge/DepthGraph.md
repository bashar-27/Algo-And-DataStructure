# Graph Depth First

## Descreption
Depth First Traversal (or DFS) for a graph is similar to Depth First Traversal of a tree. The only catch here is, that, unlike trees, graphs may contain cycles (a node may be visited twice). To avoid processing a node more than once, use a boolean visited array. A graph can have more than one DFS traversal.

## White Board 
![Untitled3](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/e5f7503b-fd57-405e-b3e6-9c56c4287246)

## walk through the code step by step:

Description:
This method performs a depth-first traversal on a graph starting from a specified node. It explores as far down a branch as possible before backtracking, ensuring that all reachable nodes from the starting node are visited.

Signature:
public List<GraphNode> DepthFirst(GraphNode startNode)

Parameters:
- startNode (GraphNode): The node from which the depth-first traversal begins.

Returns:
- List<GraphNode>: A collection of nodes in the order they were visited during the traversal.

Algorithm:
1. Input Check:
   - If startNode is null, return an empty list.

2. Initialization:
   - Initialize an empty list visitedNodes to store visited nodes.
   - Initialize an empty HashSet visitedSet to keep track of visited nodes.
   - Initialize a stack data structure to facilitate the traversal.
   - Add startNode to visitedSet and push it onto the stack.

3. Loop Begins:
   - While the stack is not empty, continue traversal.

4. Current Node Selection:
   - Pop the top node from the stack.

5. Visited Check:
   - If the current node is not in visitedSet, proceed.

6. Node Marked as Visited:
   - Add the current node to visitedNodes.
   - Add the current node to visitedSet.

7. Neighbor Traversal:
   - For each edge connected to the current node:
     - Get the neighboring node (neighborNode) at the end of the edge.

8. Neighbor Visited Check:
   - If neighborNode is not in visitedSet, push it onto the stack.

9. Loop Continues:
   - Check if there are more nodes in the stack.

10. Loop Ends:
   - If the stack is empty, traversal is complete.

11. Return Visited Nodes:
    - visitedNodes now contains nodes in the order they were visited.

12. Method Ends:
    - Return visitedNodes.

## Execute And Test Code: 


![Screenshot 2023-10-04 195023](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/00095422-afdc-4a15-bc65-4d5f9d2ad7a1)
![Screenshot 2023-10-04 195614](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/bbd581b9-c2d8-4ab0-8fc1-cc48e600265d)





