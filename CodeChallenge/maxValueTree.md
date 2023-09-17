# Find the Maximum Value in a Binary Tree
<!-- Short summary or background information -->
Find the Maximum Value in a Binary Tree

## Challenge
<!-- Description of the challenge -->
Write a function called `FindMaxValue` which takes binary tree as its only input. Without utilizing any of the built-in methods available to your language, return the maximum value stored in the tree. You can assume that the values stored in the Binary Tree will be numeric.

## WhiteBoard

![Screenshot 2023-07-31 000907](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/9d8d45a1-71e2-4375-be60-dc70de4ccfcf)

## Console And Test Unit

![Screenshot 2023-07-30 235159](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/c73ab812-7873-4ee3-94a8-b5e10f48231e)

![Screenshot 2023-07-30 235946](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/c8a9666a-4124-4995-9078-e8297b26f3e8)


## Function Code
<!-- Embedded whiteboard image -->
```
  public int Max_tree()
  {
      return Max_tree(root);
  }
  private int Max_tree(Node root)
  {
      if (root == null) {
          return 0;
      }
      else
      {
          int max = root.Data;
          int lMax = Max_tree(root.left);
          int rMax = Max_tree(root.right);
          if (max <lMax )
          {
              max = lMax;
          }
          if (max < rMax)
          {
              max = rMax;
              
          }
          return max;

      }

  }
```
