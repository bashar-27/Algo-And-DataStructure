# Graph Business Trip


The problem domain for this code can be summarized as follows:

Problem Statement:
Given a directed graph and an array of cities, the goal is to calculate the total cost of a business trip by finding a path that connects each pair of adjacent cities in the array. If a valid path cannot be found (due to missing cities in the graph or an unconnected pair of cities), the function should return null.

## White Board:

![Untitled1](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/c26f1202-b454-4627-8702-2ca3d9e72513)


## Step by Step



1. **Input Validation**:
   - The method starts with checking the length of the `cities` array. This operation has a time complexity of `O(1)` since accessing the length of an array is a constant-time operation.

2. **Initializing Variables**:
   - Initializing `totalCost` to 0 is a constant-time operation, `O(1)`.

3. **Loop Through Cities**:
   - The outer loop iterates over the `cities` array. It runs `n-1` times, where `n` is the length of the `cities` array. Therefore, the loop has a time complexity of `O(n)`.

4. **Node Lookup**:
   - Inside the loop, two node lookups are performed using `graph.GetNodeByValue(cities[i])` and `graph.GetNodeByValue(cities[i + 1])`. The time complexity of node lookup can vary depending on the implementation of the `GetNodeByValue` method. In the worst case, if it performs a linear search, it could be `O(m)` where `m` is the number of nodes in the graph. In the best case, if it uses a more efficient data structure (e.g., a hash map), it could be `O(1)`.

5. **Checking Valid Nodes**:
   - The check `if (startNode != null && endNode != null)` is a constant-time operation, `O(1)`.

6. **Edge Lookup**:
   - Inside this check, there is a loop iterating over the edges of `startNode`. The number of edges can vary depending on the implementation of the graph. In the worst case, if there are many edges, this loop could be `O(m)` where `m` is the maximum number of edges a node can have. In the best case, if the number of edges is limited and doesn't grow with the size of the graph, this could be considered constant time, `O(1)`.

7. **Checking End of Edge**:
   - The check `if (edge.GetEnd() == endNode)` is a constant-time operation, `O(1)`.

8. **Updating Total Cost**:
   - Updating `totalCost` with `totalCost += edge.GetWeight();` is a constant-time operation, `O(1)`.

9. **Path Found Check**:
   - The check `if (!pathFound)` is a constant-time operation, `O(1)`.

10. **Returning Values**:
    - Returning `null` or `totalCost` is a constant-time operation, `O(1)`.

11. **Overall Time Complexity**:
    - Considering all the steps, the dominant factor in the time complexity is the loop through the cities, making the overall time complexity `O(n)` where `n` is the number of cities provided in the input array.

12. **Space Complexity**:
    - The space complexity is `O(1)` because the method uses a fixed amount of memory that does not depend on the size of the input (i.e., the number of cities). The memory usage remains constant regardless of the input size.
   
13. ## Unit Tset And Run Code:


![Screenshot 2023-10-04 180806](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/fc169c6b-1c59-44e8-b1bb-0d39876f61dd)
![Screenshot 2023-10-04 180815](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/d578d597-ba7d-4af4-87d5-4fbc76787dd0)




