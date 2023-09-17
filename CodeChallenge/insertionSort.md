# challenge (26) : Insertion Sortion
## explanation
 the code demonstrates the Insertion Sort algorithm, which is an efficient sorting technique for small arrays or partially sorted arrays. It sorts the input array in ascending order by repeatedly inserting elements into their correct positions within the sorted portion of the array.

![Screenshot 2023-08-30 022735](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/c0b3ad38-9860-4336-98ef-b5718cc55854)

## Step-by-Step Explanation of Insertion Sort Algorithm

Below is a detailed breakdown of the Insertion Sort algorithm using the provided code:

### Initial Array:

1, 5, 8, 16, 32, 25, 74, 20


### Iteration 1:
- `i = 1`, `key = 5`
- Compare `key` (5) with `arr[0]` (1): 5 > 1, no shift needed
- Place `key` (5) at its correct position
- Array: `1, 5, 8, 16, 32, 25, 74, 20`

### Iteration 2:
- `i = 2`, `key = 8`
- Compare `key` (8) with `arr[1]` (5): 8 > 5, no shift needed
- Place `key` (8) at its correct position
- Array: `1, 5, 8, 16, 32, 25, 74, 20`

### Iteration 3:
- `i = 3`, `key = 16`
- Compare `key` (16) with `arr[2]` (8): 16 > 8, no shift needed
- Place `key` (16) at its correct position
- Array: `1, 5, 8, 16, 32, 25, 74, 20`

### Iteration 4:
- `i = 4`, `key = 32`
- Compare `key` (32) with `arr[3]` (16): 32 > 16, no shift needed
- Place `key` (32) at its correct position
- Array: `1, 5, 8, 16, 32, 25, 74, 20`

### Iteration 5:
- `i = 5`, `key = 25`
- Compare `key` (25) with `arr[4]` (32): 25 < 32, shift elements greater than 25 to the right
- Array after shifting: `1, 5, 8, 16, 32, 32, 74, 20`
- Place `key` (25) at its correct position
- Array: `1, 5, 8, 16, 25, 32, 74, 20`

### Iteration 6:
- `i = 6`, `key = 74`
- Compare `key` (74) with `arr[5]` (32): 74 > 32, no shift needed
- Place `key` (74) at its correct position
- Array: `1, 5, 8, 16, 25, 32, 74, 20`

### Iteration 7:
- `i = 7`, `key = 20`
- Compare `key` (20) with `arr[6]` (74): 20 < 74, shift elements greater than 20 to the right
- Array after shifting: `1, 5, 8, 16, 25, 32, 74, 74`
- Place `key` (20) at its correct position
- Array: `1, 5, 8, 16, 20, 32, 74, 74`

### Loop Ends:
- The loop ends since all elements have been processed.

### Final Sorted Array:
1, 5, 8, 16, 20, 32, 74, 74


### Insertion Sort Algorithm Implementation:

```csharp
int[] arr = { 1, 5, 8, 16, 32, 25, 74, 20 };

for (int i = 1; i < arr.Length; i++)
{
    int key = arr[i];
    int j = i - 1;

    while (j >= 0 && arr[j] > key)
    {
        arr[j + 1] = arr[j];
        j--;
    }

    arr[j + 1] = key;
}

foreach (int num in arr)
{
    Console.Write(num + " ");
}
Console.WriteLine();
```
And test unit 

![Screenshot 2023-08-30 022553](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/db6e3aa2-1c36-4fc9-8356-804b1bbf94c8)
