using Microsoft.VisualBasic;
using System;

namespace InsertShift
{
    public  class LinkedList
    {
        public int Count = 0;
        public static int CountInsert = 0;
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
            else
            {
                Tail.Next = node;
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
            string result = "";
            while (current != null)
            {
                result += $"{{{current.Data}}}->";
                current = current.Next;
            }
            result += "NULL";
            return result;
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


        public int kthFromEnd(int k)
        {
            Node current = Head;
            int position = (CountInsert - 1) - k;
            if (CountInsert == 1) { return current.Data;}
            if (k >= CountInsert|| k<0)
            {
                Console.WriteLine("ERROR! \nPlease Insert Valid Index");
                return -1;
            }
         
            for (int i = 0; i < position; i++)
            {
                current = current.Next;
            }
            
           
            return current.Data;
        }
      
    public static LinkedList zipList(LinkedList list1, LinkedList list2)
    {
        LinkedList list3 = new LinkedList();

        Node pointer1 = list1.Head;
        Node pointer2 = list2.Head;

        while (pointer1 != null && pointer2 != null)
        {
            list3.Insert(pointer1.Data);
            list3.Insert(pointer2.Data);

            pointer1 = pointer1.Next;
            pointer2 = pointer2.Next;
        }


        while (pointer1 != null)
        {
            list3.Insert(pointer1.Data);
            pointer1 = pointer1.Next;
        }


        while (pointer2 != null)
        {
            list3.Insert(pointer2.Data);
            pointer2 = pointer2.Next;
        }
        

        return list3;
    }

        public static LinkedList ReverseLink(LinkedList list)
        {
            LinkedList newList = new LinkedList();
            Node current = list.Head;
            Node prev = null;
         
            
            while (current != null)
            {
                Node node = new Node(current.Data);
                Node next = current.Next;
                node.Next = prev;
                prev = node;
                current = current.Next;
            }

            newList.Head = prev;
            return newList;
        }

       

    }
}
