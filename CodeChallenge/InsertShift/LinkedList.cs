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
