using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertShift
{
    public class Stack
    {
        Node top;
        public Stack() { top = null; }
        public bool isEmpty()
        {
            return top == null;
        }
        public int push (int val)
        {
            Node newNode = new Node(0);
            if (newNode ==null)
            {
                Console.WriteLine("Cannot Push");
            }
            else
            {
                newNode.Data = val;
                newNode.Next = top;
                top = newNode;

            }
            return newNode.Data;
        }
        public void pop () {
        if (isEmpty())
            {
                Console.WriteLine("The Stack Is Empty ya Man!");
            }
            else
            {
                Node temp = top;
                top = top.Next;
                temp=temp.Next=null;
            }
        }
        public void peek()
        {
            int peekTop = 0;
            if (isEmpty())
            {
                Console.WriteLine("The Stack Empty On Peek");
            }
            else
            {
                peekTop = top.Data;
                Console.WriteLine($"The Peek :{peekTop}");
            }
        }
        public void print() {
            Node current = top;
            Console.Write("[");
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine("]");
        }

        public static implicit operator Stack(Stack<int> v)
        {
            throw new NotImplementedException();
        }
    }
}
