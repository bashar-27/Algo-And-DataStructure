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
           
        }


        
    }
}
