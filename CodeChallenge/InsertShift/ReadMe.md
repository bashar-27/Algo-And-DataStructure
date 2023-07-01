
<h1>Linked List</h1>

<h4>This is a simple way to make a single link list ,the code provides basic operations for inserting nodes, searching for values if included or not, and generating a string representation of a singly linked list. this is the whiteboard for the problem. :</h4>
  
 ![Screenshot 2023-06-28 041507](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/b1ad2a96-edc8-43f8-b421-698845e5ada8)


<hr>

*How To Open Linked List Code*

![Screenshot 2023-06-28 042533](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/6f85247f-506a-4c45-8d9d-362a98d1b5d3)


![Screenshot 2023-06-28 042559](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/41f5467b-d993-4fe0-8721-548bf7b2251a)

![Screenshot 2023-06-28 042633](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/08275214-12b2-4a51-8232-ad4e906bd8fe)

![Screenshot 2023-06-28 042652](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/a1fec5bf-3e04-4090-b0c8-c0555621dae0)

*Console And Test Code*

![Screenshot 2023-06-28 043006](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/d3f8d9cd-903b-40db-b188-5071ca72e979)

![Screenshot 2023-06-28 043043](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/b73bc91a-f5d8-4413-91c4-113d80b9b46a)

<hr>

<h2>After added new two method insert before and after</h2>


![Screenshot 2023-07-02 023655](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/7b885b61-19bd-442e-b5fe-b8d3264fb679)

![Screenshot 2023-07-02 023743](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/ac942fde-e0d4-4ac7-a5e8-8ef8a42202b0)

<h1>Linked List Code</h1>
<code>
  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InsertShift
{
    public class LinkedList
    {
        public int Count=0;
        public int CountInsert = 0;
        public Node Head { get; set; }
        public Node Tail { get; set; } 
        public LinkedList()
        {
            Head = null;
            Count++;
        }

        public void Insert(int val)
        {
            CountInsert++;
            Node node = new Node(val);
            if (Head == null)
            {
                Head = node;
                Tail = node;
                Head.Next = null;

            }
            else { 
            Tail.Next =node;
            Tail = node;
            }

        }
        public bool Include(int val)
        {
            Node current = Head; 
            while (current != null)
            {
                if (current.Data == val)
                    return true; 
                current = current.Next;
            }
            return false;

        }
        public string ToString()
        {
            Node current = Head;
            string str = "";
            for (int i = 0; i<CountInsert;i++)
            {

                str += $"{{{current.Data}}}->";
                current = current.Next;
              
            }
            return str+"NULL";
        }

        public void InsertBefore(int value, int newValue)
        {
            CountInsert++;
            if (Head == null)
                return;

            if (Head.Data == value)
            {
                Node newNode = new Node(newValue);
                newNode.Next = Head;
                Head = newNode;
                return;
            }

            Node current = Head;
            while (current.Next != null)
            {
                if (current.Next.Data == value)
                {
                    Node newNode = new Node(newValue);
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
        }

        public void InsertAfter(int value, int newValue)
        {
            CountInsert++;
            Node current = Head;
            while (current != null)
            {
                if (current.Data == value)
                {
                    Node newNode = new Node(newValue);
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    if (current == Tail)
                        Tail = newNode;
                    return;
                }
                current = current.Next;
            }
        }

    }
}

</code>

<hr>

<h1>Test Code</h1>
<code>using System;
using Xunit;
using System.Runtime;
using InsertShift;
using System.Collections.Generic;



namespace TestProject3
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
           LinkedList list = new LinkedList();
            Assert.Null(list.Head);

        }
        [Fact]
        public void Test2()
        {
            LinkedList list = new LinkedList();
            list.Insert(5);
            Assert.NotNull(list.Head);
            Assert.Equal(5, list.Head.Data);
        }

        [Fact]
        public void HeadPointsToFirstNode()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(5);
            linkedList.Insert(10);
            Assert.NotNull(linkedList.Head);
            Assert.Equal(5, linkedList.Head.Data);
        }

        [Fact]
        public void CanInsertMultipleNodes()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(5);
            linkedList.Insert(10);
            linkedList.Insert(15);
            Assert.NotNull(linkedList.Tail);
            Assert.Equal(15, linkedList.Tail.Data);
        }

        [Fact]
        public void IncludesReturnsTrueWhenValueExists()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(5);
            linkedList.Insert(10);
            linkedList.Insert(15);
            bool exists = linkedList.Include(10);
            Assert.True(exists);
        }

        [Fact]
        public void IncludesReturnsFalseWhenValueDoesNotExist()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(5);
            linkedList.Insert(10);
            linkedList.Insert(15);
            bool exists = linkedList.Include(20);
            Assert.False(exists);
        }

        [Fact]
        public void CanReturnAllValuesInLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(5);
            list.Insert(10);
            list.Insert(15);
            string expected = "{5}->{10}->{15}->NULL ";
            string result = list.ToString();
            Assert.Equal(expected, result);
        }
        [Fact]
        public void BeforeMiddle()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(5);
            linkedList.Insert(10);
            linkedList.Insert(15);
            linkedList.InsertBefore(10, 7);
            string expected = "{5}->{7}->{10}->{15}->NULL";
            string result = linkedList.ToString();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void BeforeFirst()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(5);
            linkedList.Insert(10);
            linkedList.InsertBefore(5, 2);
            string expected = "{2}->{5}->{10}->NULL";
            string result = linkedList.ToString();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void AfterMiddle()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(5);
            linkedList.Insert(10);
            linkedList.Insert(15);
            linkedList.InsertAfter(10, 12);
            string expected = "{5}->{10}->{12}->{15}->NULL";
            string result = linkedList.ToString();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void AfterLast()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(5);
            linkedList.Insert(10);
            linkedList.InsertAfter(10, 13);
            string expected = "{5}->{10}->{13}->NULL";
            string result = linkedList.ToString();
            Assert.Equal(expected, result);
        }
    }
}
</code>

