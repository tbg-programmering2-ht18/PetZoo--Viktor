using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetZoo
{
    class Pet
    {

        public string name { get; set; }
        public string sound { get; set; }
        public bool CanFly { get; set; }


        public string show()
        {
            if (CanFly == true)
            {
                return string.Format("name: {0}\nsound: {1}\nType: {2} and can fly!!,", name, sound, GetType());
            }
            else
            {
                return string.Format("name: {0}\nsound: {1}\nType: {2} and can fly!!,", name, sound, GetType());
            }
        }
    }
    class Dinosaur :Pet
    {
        
        public Dinosaur(string name)
        {

           this.name = name;
            sound = "Rawr";
            CanFly = false; //hej
        }
        

       
    }

}

