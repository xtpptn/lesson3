using System;
using System.Collections.Generic;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {

            Animals = new List<Animal>();

            /*Animal animalEmpty = new Animal();*/
            Animal animalWithName = new Animal(34, "Slavik");

            Cat cat = new Cat(4, "Pushok");

            Dog dog = new Dog(8, "Sirko");

            Surikat surikat = new Surikat(8, "Timon");

            Papuha papuha = new Papuha(5, "Archi");

            Elephant elephant = new Elephant(13, "Dumbo");

            /*Console.WriteLine($"{animalWithName.Name} age is {animalWithName.Age}");*/

            /*animalWithName.GrowAge();*/

            /*Console.WriteLine(animalWithName.ToString());
            Console.WriteLine(cat.ToString());
            Console.WriteLine(dog.ToString());*/

            List<Animal> animals = new List<Animal>();
            List<int> ints = new List<int>();

            Animals.Add(cat);
            animals.Add(cat);
            animals.Add(dog);
            animals.Add(surikat);
            animals.Add(papuha);
            animals.Add(elephant);

            foreach(var item in animals)
            {
                item.Jump();
            }

            AddAnimalIntoCollection<Cat>(cat);
            AddAnimalIntoCollection<Surikat>(surikat);


        }


        public static List<Animal> Animals { get; set; }

        public static void AddAnimalIntoCollection<T>(T animal) where T : Animal
        {
            Animals.Add(animal);
        }

    }
}
