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


        }



    }
}