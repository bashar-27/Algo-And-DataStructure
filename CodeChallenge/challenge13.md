## Introduction
The problem domain of the IsvalidateBrackets method is to check whether a given string of brackets is balanced or not. A balanced bracket expression is one where every opening bracket has a corresponding closing bracket in the correct order.
In other words, for each opening bracket ('(', '[', '{'), there should be a corresponding closing bracket (')', ']', '}') at the appropriate position in the input string.

The method uses a stack data structure to keep track of the opening brackets encountered while traversing the input string.
When an opening bracket is encountered, it is pushed onto the stack. When a closing bracket is encountered, the method checks if the stack is empty or not. If the stack is empty, 
it means there is no corresponding opening bracket, and the expression is not balanced, returning false.
If the stack is not empty, the method pops the top element from the stack and checks if it matches the current closing bracket. If they do not match, it means the expression is not balanced, 
and the method returns false.

After processing all the characters in the input string, the method checks if the stack is empty.
If the stack is empty, it means all the opening brackets have their corresponding closing brackets, and the expression is balanced, returning true.
If the stack is not empty, it means there are opening brackets without their corresponding closing brackets, and the expression is not balanced, returning false.

## WhiteBorad 
![zoo (3)](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/874623a8-44f1-4b4e-b465-1525a24756d2)

<hr>

## Console Run And Test Case

![Screenshot 2023-07-23 161918](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/bf922e18-e391-41e4-8b29-4e7503a96b6c)
![Screenshot 2023-07-23 161925](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/45b9b5a2-53c4-47f2-a970-22e4daf099d1)
