using System;

namespace InsertShift
{
    public class Program
    {
        static void Main(string[] args)
        {


            LinkedList link = new LinkedList();
            link.Insert(5);
            link.Insert(6);
            link.Insert(7);
            link.Insert(8);
            link.InsertAfter(8, 20);
            link.Insert(9);
            link.InsertBefore(9, 55);
            Console.WriteLine(link.Include(8));
            Console.WriteLine(link.ToString());
            Console.WriteLine(link.CountInsert);
            Console.WriteLine(link.kthFromEnd(-1));
            Console.WriteLine(link.kthFromEnd(0));
            Console.WriteLine(link.kthFromEnd(1));
            Console.WriteLine(link.kthFromEnd(2));
            Console.WriteLine(link.kthFromEnd(3));
            Console.WriteLine(link.kthFromEnd(4));
            Console.WriteLine(link.kthFromEnd(5));
            Console.WriteLine(link.kthFromEnd(6));
            Console.WriteLine(link.kthFromEnd(7));

        }



    }
}