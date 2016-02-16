using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_3_zoo
{
    class Zoo
    {
        public string ZooName { get; set; }
        public string Address { get; set; }
       // private List<Employee> staff;
        private List<Animal> animals;

        public Zoo()
        // uusi lista mikä sisältää eläimiä
        {
            animals = new List<Animal>();
        }

        // uusi lista mikä sisältää työtekijät
    //    {    
     //       staff = new List<Employee>();
      //  }


        // eläimen lisäys metodi
        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        // tulostetaan lista
        public void PrintData()
        {
            Console.WriteLine( ZooName + ", " + Address);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("-----------In our Zoo you can see..-------------");
            Console.WriteLine("------------------------------------------------");


            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }

    }
}
