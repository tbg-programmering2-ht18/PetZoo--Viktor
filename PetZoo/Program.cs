using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetZoo
{
    class Program
    {
        static List<Pet> animals = new List<Pet>();
        static void Main(string[] args)
        {
            Pet animal1 = new Pet();
            animal1.name = "Gullet";
            animals.Add((animal1));
            Pet animal2 = new Pet();
            animal2.name = "Berit";
            animals.Add((animal2));

            foreach (Pet animal in animals)
            {
                Console.WriteLine(animal.name);
            }
            Console.ReadKey();
            
        }
    }
}
