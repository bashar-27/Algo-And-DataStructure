
<h1>Linked List Kth</h1>

<h4>Based on previous lab in this code, we first check if the input index k is valid. If k is negative or greater than or equal to CountInsert (which seems to represent the number of nodes in the linked list), we display an error message and return -1.

If the index is valid, we initialize a current variable with the Head of the linked list and calculate the position of the node we want to access using<code> CountInsert - k - 1</code>. Then, we traverse the list by moving current to the next node position times.

Finally, we return the value of the node referenced by current.Data.

Note that this code assumes you have a Node class with a Data property and a Next property that represents the value and the reference to the next node, respectively. Additionally, make sure you have correctly initialized the Head and CountInsert variables before calling the ReverseIndex method.. :</h4>
<hr>
<h3>This white board for CC06</h3>
  
 ![Screenshot 2023-06-28 041507](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/b1ad2a96-edc8-43f8-b421-698845e5ada8)


<hr>

*How To Open Linked List Code*

![Screenshot 2023-06-28 042533](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/6f85247f-506a-4c45-8d9d-362a98d1b5d3)


![Screenshot 2023-06-28 042559](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/41f5467b-d993-4fe0-8721-548bf7b2251a)

![Screenshot 2023-06-28 042633](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/08275214-12b2-4a51-8232-ad4e906bd8fe)

![Screenshot 2023-06-28 042652](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/a1fec5bf-3e04-4090-b0c8-c0555621dae0)

*Console And Test Code*


![Screenshot 2023-07-04 015427](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/5090a8d2-6702-4976-a86c-cbc14146b7c6)
![Screenshot 2023-07-04 015345](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/afa9d20d-cd3d-4ae9-9f0f-12626711d27c)

