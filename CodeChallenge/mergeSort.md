# Merge Sort Algorithm

## Problem Domain
You are given an unsorted integer array, and you want to sort it in ascending order using the Merge Sort algorithm. Merge Sort is a divide-and-conquer algorithm that divides the array into two halves, sorts them separately, and then merges the sorted halves to produce the final sorted array.

## Input
- An unsorted integer array `arr`.
- The length of the array `n`.

## Output
- A sorted integer array.

## Algorithm
1. **MergeSort(arr, left, right)**
    - Check if `left` is less than `right`. If not, return the array as it's already sorted.
    - Calculate the middle index `mid` as `(left + right) / 2`.
    - Recursively call `MergeSort` on the left half of the array, i.e., `MergeSort(arr, left, mid)`.
    - Recursively call `MergeSort` on the right half of the array, i.e., `MergeSort(arr, mid + 1, right)`.
    - Merge the two sorted halves using the `Merge` function.

2. **Merge(arr, left, mid, right)**
    - Initialize variables `i`, `j`, and `k` to 0, 0, and `left` respectively.
    - Calculate the sizes of the left and right subarrays, `lArr` and `rArr`, respectively.
    - Create new subarrays `leftSubArr` and `rightSubArr` to store the left and right halves.
    - Copy elements from the original array into `leftSubArr` and `rightSubArr`.
    - Merge the two subarrays back into the original array in sorted order.
    - Compare elements from `leftSubArr` and `rightSubArr`, and place the smaller element in the original array.
    - Continue this process until all elements from both subarrays are merged into the original array.
    - Return the sorted array.

## Big O Complexity
- **Time Complexity**: Merge Sort has a time complexity of O(n log n) in the worst, average, and best cases. This is because it divides the array into halves and merges them, and each of these operations takes O(n log n) time.
- **Space Complexity**: The space complexity is O(n) due to the additional space required for the subarrays during the merge process.

<hr>

## This is two images for Run code and test it

![Screenshot 2023-09-02 193824](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/d870d0bb-7c57-4a5d-8749-ba6d2ab60596)
![Screenshot 2023-08-30 022553](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/b69c6ecc-bff3-4b40-b0f0-38723fbf51e7)

![Screenshot 2023-09-02 233323](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/005a1e59-ed9b-4360-93df-fbe71c4429a2)


