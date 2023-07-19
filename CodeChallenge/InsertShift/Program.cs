using System;
using System.Collections.Generic;


namespace InsertShift
{
    public class Program
    {
        static void Main(string[] args)
        {
            AnimalShelter animalShelter = new AnimalShelter();
            Animal Dog = new Animal() { species = "dog", Name = "Hasky" };
            Animal Dog2 = new Animal() { species = "DOG", Name = "pitBull" };
            Animal Cat1 = new Animal() { species = "Cat", Name = "shirazi" };
            Animal Cat2 = new Animal() { species = "cat", Name = "siami" };
            Animal Cat3 = new Animal() { species = "cat", Name = "Britch" };
            List<Animal> DogsLst = new List<Animal>();
            List<Animal> CatsLst = new List<Animal>();
            Console.WriteLine("Add Dogs");
            animalShelter.Enqueue(Dog);
            DogsLst.Add(Dog);
            animalShelter.Enqueue(Dog2);
            DogsLst.Add(Dog2);
            animalShelter.countDog(DogsLst);


            Console.WriteLine("\nAdd Cats ");
            animalShelter.Enqueue(Cat1);
            CatsLst.Add(Cat1);
            animalShelter.Enqueue(Cat2);
            CatsLst.Add(Cat2);
            animalShelter.Enqueue(Cat3);
            CatsLst.Add(Cat3);
            animalShelter.countCat(CatsLst);

            Console.WriteLine("\n\nRemove Dogs");
            animalShelter.Dequeue(Dog.species);
            DogsLst.Remove(Dog);
            animalShelter.countDog(DogsLst);


            Console.WriteLine("\nRemove Cats");
            animalShelter.Dequeue(Cat3.species);
            DogsLst.Remove(Cat3);
            animalShelter.countCat(CatsLst);

            PseudoQueue pseudoQueue = new PseudoQueue();

            // Enqueue some values
            pseudoQueue.Enqueue(10);
            pseudoQueue.Enqueue(20);
            pseudoQueue.Enqueue(30);

            // Dequeue and print the values
            Console.WriteLine(pseudoQueue.Dequeue()); // Output: 10
            Console.WriteLine(pseudoQueue.Dequeue()); // Output: 20

            // Enqueue another value
            pseudoQueue.Enqueue(40);

            // Dequeue and print the remaining value
            Console.WriteLine(pseudoQueue.Dequeue());
            Console.WriteLine(pseudoQueue.Dequeue());

            //Stack stack = new Stack();
            //Queue queue = new Queue();
            //Console.WriteLine("-----------------STACK-------------------");
            //stack.push(50);
            //stack.push(40);
            //stack.push(30);
            //stack.print();
            //stack.peek();
            //stack.pop();
            //stack.print();
            //stack.peek();
            //Console.WriteLine("-----------------QUEUE-------------------");

            //queue.Enqueue(100);
            //queue.Enqueue(200);
            //queue.Enqueue(300);
            //queue.print();
            //Console.WriteLine($"De-Queue :{queue.Dequeue()}");
            //Console.WriteLine($"Peek Element:{queue.peek()}");
            //queue.print();

            //LinkedList link = new LinkedList();
            //LinkedList link2 = new LinkedList();
            //link.Insert(5);
            //link.Insert(6);
            //link.Insert(7);
            //link.Insert(8);
            //link.InsertAfter(8, 20);
            //link.Insert(9);
            //link.InsertBefore(9, 55);
            //link2.Insert(100);
            //link2.Insert(200);
            //link2.Insert(300);
            //link2.Insert(400);
            //link2.Insert(500);
            //link2.Insert(600);

            //Console.WriteLine(link.ToString());

            //Console.WriteLine(link2.ToString());
            //LinkedList list3 = new LinkedList();
            //list3= LinkedList.zipList(link, link2);
            //Console.WriteLine(list3.ToString());

            //LinkedList list4 = new LinkedList();
            //list4 = LinkedList.ReverseLink(link2);
            //Console.WriteLine(list4.ToString());
            // Console.WriteLine("---------------------------------------------");

        }



    }
       
    

}
