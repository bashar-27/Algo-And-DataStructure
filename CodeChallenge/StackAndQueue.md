# Stack and Queue

## Summary
This is a simple implementation of the Stack and Queue data structures in C#. The `Stack` class represents a Last-In-First-Out (LIFO) data structure, and the `Queue` class represents a First-In-First-Out (FIFO) data structure.

## Description
The `Stack` class is implemented using a singly linked list. It provides the following methods:
- `isEmpty()`: Checks if the stack is empty.
- `push(val)`: Pushes an element onto the stack.
- `pop()`: Pops the top element from the stack.
- `peek()`: Retrieves the top element from the stack without removing it.

The `Queue` class is also implemented using a singly linked list. It provides the following methods:
- `IsEmpty()`: Checks if the queue is empty.
- `Enqueue(val)`: Enqueues an element at the back of the queue.
- `Dequeue()`: Dequeues the element from the front of the queue.
- `peek()`: Retrieves the element from the front of the queue without removing it.
- `print()`: Prints the elements of the queue.

## Approach & Efficiency
Both the Stack and Queue classes have a time complexity of O(1) for the push, pop, peek, enqueue, and dequeue operations. The implementation uses a linked list, which allows for efficient insertion and removal of elements at the top (for stack) and at the back/front (for queue) without the need for shifting elements.

## Solution
The provided code includes the implementation of the Stack and Queue classes. To use them in your project, follow these steps:

1. Include the `Stack` and `Queue` classes in your C# project.
2. Create instances of the `Stack` and `Queue` classes in your code.
3. Use the respective methods (`push`, `pop`, `peek` for Stack; `Enqueue`, `Dequeue`, `peek` for Queue) to manipulate the data in the stack or queue.

Here's an example usage:

```csharp
Stack stack = new Stack();
stack.Push(10);
int topElement = stack.Peek(); // Returns 10
stack.Pop();

Queue queue = new Queue();
queue.Enqueue(20);
int frontElement = queue.Peek(); // Returns 20
queue.Dequeue();
```
<h2>This WhiteBoard :</h2>

![zoo](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/4a89672e-7eb2-4d76-a143-c2880d7cb050)

<h2>Code And Test Image: </h2>

![Screenshot 2023-07-12 234041](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/ce51ecb9-8c94-441c-b6c8-1d023efe742c)


![Screenshot 2023-07-12 233840](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/238ad960-07fb-4c91-8ae7-6fd9f8cb8462)



