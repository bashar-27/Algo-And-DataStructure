using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertShift
{
    public class AnimalShelter
    {
        private Queue<Animal> Dogs;
        private Queue<Animal> Cats;
        public AnimalShelter()
        {
            Dogs = new Queue<Animal>();
            Cats = new Queue<Animal>();
        }
        public void Enqueue (Animal animal)
        {
            if(animal.species.ToLower() == "cat") {
                Cats.Enqueue(animal);
            }
            if(animal.species.ToLower() == "dog")
            {
                Dogs.Enqueue(animal);
            }
        }
        public Animal Dequeue (string pref)
        {
            if(pref == "cat")
            {
                return Cats.Dequeue();
            }
            else if(pref == "dog")
            {
                return Dogs.Dequeue();
            }
            else throw new ArgumentException("Invalid preference. Only Dogs: 'dog', or Cats: 'cat' allowed.");
            

        }
        public void countDog(List <Animal>dogAnimal)
        {
            int i = 1;
            Console.WriteLine("The Number Of DOGS Is :" + Dogs.Count);
           foreach(Animal animal in Dogs)
            {
                Console.WriteLine(i+"_" + animal.Name+" ");
                i++;
            }
           
        }
        public void countCat(List<Animal> catAnimal)
        {
            int i = 1;
            Console.WriteLine("The Number Of CATS Is :" + Cats.Count);
            foreach (Animal animal in Cats)
            {
                Console.WriteLine(i + "-" + animal.Name + " ");
                i++;
            }

        }
    }
    
}
