using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetZoo
{
    class Program
    {
        static List<PET> animals = new List<PET>();
        static void Main(string[] args)
        {
            PET animal1 = new PET();
            animal1.name = "Gullet";
            animals.Add((animal1));
            PET animal2 = new PET();
            animal2.name = "Berit";
            animals.Add((animal2));

            animals.Add(new cat()
        }
    }
}
