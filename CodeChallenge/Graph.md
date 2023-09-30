# Graph 

![Untitled](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/f5af9ad3-9cd4-4e54-9ba8-bce0d96c134b)


## Explanation
This code defines a graph data structure where vertices and edges are represented using C# classes. It allows you to create a graph, add vertices and edges, retrieve information about the graph, and print the graph's contents.

### Code Structure
- The code is organized into three main classes: `Vertex`, `Edge`, and `Graph`.
- `Vertex<T>` represents a vertex in the graph and holds its value.
- `Edge<T>` represents an edge between two vertices and includes a weight.
- `Graph<T>` is the main class representing the graph. It includes methods to add vertices, add edges, retrieve vertices, get neighbors of a vertex, and more.

### Main Method
- The `Main` method serves as the entry point of the program.
- It demonstrates the usage of the `Graph` class by creating a graph with cities as vertices and distances as edge weights.
- The program prints information about the graph, such as vertices, neighbors of a specific vertex, and the size of the graph.

### How It Works (Step by Step)

1. **Graph Initialization**:
   - When the program starts, it creates an instance of the `Graph<string>` class, initializing an empty graph.

2. **Vertex Creation**:
   - The code adds four vertices representing cities: New York, Los Angeles, Chicago, and San Francisco. This is done using the `AddVertex` method.

3. **Edge Creation**:
   - Edges are added between these cities to represent distances. For example, an edge with a weight of 3000 is added between New York and Los Angeles. This is done using the `AddEdge` method.
   - Similar edges are added between other cities.

4. **Vertex and Edge Retrieval**:
   - The program demonstrates retrieving information about the graph.
   - It retrieves a list of all vertices using the `GetVertices` method and prints their names.
   - It also retrieves the neighbors of a specific vertex, such as New York, using the `GetNeighbors` method and prints the neighbor cities along with their distances.

5. **Graph Size**:
   - The program calculates and prints the size of the graph using the `Size` method, which returns the total number of vertices in the graph.

6. **Graph Printing**:
   - The code includes a `Print` method that allows you to print the entire graph, showing the vertices and edges along with their weights.

7. **Output**:
   - The program's output is displayed in the console, showing the vertices, neighbors of New York, and the size of the graph.

8. **Usage Customization**:
   - You can customize the `Main` method to create your own graph with different vertices and edges or use the code as a basis for implementing other graph-related operations.

By following these steps, you can create, populate, and interact with a graph data structure in C#.

![Screenshot 2023-09-29 034737](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/dcd9b8cc-6e69-429e-b774-671fc04bc6f8)
![Screenshot 2023-09-29 034835](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/bf1b6ade-7d36-4c26-8fcb-0e8c7be55bff)
