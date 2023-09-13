# challenge 30 : Hash Tables
## Explanation
 The code demonstrates the Implemintationn for the Hash Tables.

 ## White Board:
![Screenshot 2023-09-14 021956](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/c7ebad6e-63c0-4c76-b33f-bd643198512a)

 
 <hr>

## Step by step explanation:

The Hashtable is initialized by creating an array to store key-value pairs. Although the code doesn't explicitly specify the size of this array, it is assumed to be a predefined constant, denoted as `Hashtable.Size`.

Adding a key-value pair with `hashtable.Set("key", "value")` involves several steps. First, it calculates the hash code for the provided "key" using a method named `Hash`. Then, it maps this hash code to a specific index within the array, often achieved using the modulus operation. Subsequently, the key-value pair is inserted into the array at the determined index. If a situation arises where another key results in the same index (known as a collision), the code addresses it by creating a linked list of key-value pairs at that index.

When you retrieve a value by providing a "key" via `hashtable.Get("key")`, the process includes computing the hash code for the given "key", mapping it to an index in the array, and then searching the linked list (if one exists at that index) for the specified "key". The associated value is then returned.

Obtaining a list of unique keys with `hashtable.Keys()` follows a specific sequence. It iterates through the entire array, and for each index, it checks if a linked list exists. If a linked list is present, it traverses through the list to gather all distinct keys.

Regarding the actual hash function employed by the `Hash` method, its specific details are not provided in the provided code snippet. However, it is expected to generate consistent hash codes for the same key and distribute them evenly across the potential range of indices in the array.

<hr>

## Run Code :
![Screenshot 2023-09-14 014438](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/89f99aeb-782f-4ae2-b884-96067eb2b0ea)


## Test Code :

![Screenshot 2023-09-14 014348](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/04359589-0ab4-469d-b8b9-d75714d1cfe3)
