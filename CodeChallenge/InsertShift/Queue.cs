using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertShift
{
    public class Queue
    {
        Node front;
        Node back;
        int count;

        public Stack stack1 { get; internal set; }
        public Stack<int> stack2 { get; internal set; }

        public Queue()
        {
            front = back = null;
            count = 0;
        }
        public bool IsEmpty () { return count == 0; }
        public void Enqueue(int val)
        {
            Node newNode = new Node(val);
            if (IsEmpty())
            {
                front = back = newNode;
                count++;
                return;
            }
            else
            {
                back.Next = newNode;
                back = newNode;
                count++;
            }
        }
        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The Queue Is Empty -.-");

              //  Console.WriteLine("The Queue Is Empty -.-");
            }
            int val = front.Data;
            front=front.Next;
            if(front == null)
            {
                back = null;
            }
            count--;
            return val;
        }
        public int peek()
        {
            int frontPeek = 0;
            if (IsEmpty())
            {
                throw new InvalidOperationException("empty queue peek not found.");
              //  Console.WriteLine("empty queue peek not found.");
            }
            frontPeek = front.Data;
            return frontPeek;
        }
        public void print()
        {
            Node current = front;
            Console.Write("[");
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine("]");
        }


    }
}
