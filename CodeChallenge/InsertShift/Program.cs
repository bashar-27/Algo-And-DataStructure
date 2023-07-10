using System;

namespace InsertShift
{
    public class Program
    {
        static void Main(string[] args)
        {


            LinkedList link = new LinkedList();
            LinkedList link2 = new LinkedList();
            link.Insert(5);
            link.Insert(6);
            link.Insert(7);
            link.Insert(8);
            //link.InsertAfter(8, 20);
            //link.Insert(9);
            //link.InsertBefore(9, 55);
            link2.Insert(100);
            link2.Insert(200);
            link2.Insert(300);
            link2.Insert(400);
            link2.Insert(500);
            link2.Insert(600);

            //Console.WriteLine(link.ToString());

            Console.WriteLine(link2.ToString());
            //LinkedList list3 = new LinkedList();
            //list3= LinkedList.zipList(link, link2);
            //Console.WriteLine(list3.ToString());

            LinkedList list4 = new LinkedList();
            list4 = LinkedList.ReverseLink(link2);
            Console.WriteLine(list4.ToString());
            Console.WriteLine("---------------------------------------------");


        }



        }
       
    

}
