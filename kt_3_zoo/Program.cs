using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_3_zoo
{
    class Program
    {
        static void Main(string[] args)
        {   // luodaan uusi eläintarha
            Zoo korkeasaari = new Zoo();
            korkeasaari.ZooName = "Korkeasaari";
            korkeasaari.Address = "Mustikkamaanpolku 12, 00570 HELSINKI";

            // luodaan eläimiä 

            Animal animal1 = new Animal();
            animal1.Species = "Lion";
            animal1.Name = "Simba";
            animal1.Age = 12;
            animal1.Color = "Yellow";

            Animal animal2 = new Animal();
            animal2.Species = "Mandrill";
            animal2.Name = "Rafiki";
            animal2.Age = 74;
            animal2.Color = "Grey";

            Animal animal3 = new Animal();
            animal3.Species = "Unicorn";
            animal3.Name = "Pegasos";
            animal3.Age = 2;
            animal3.Color = "White";

            Animal animal4 = new Animal();
            animal4.Species = "Mongoose";
            animal4.Name = "Timon";
            animal4.Age = 7;
            animal4.Color = "Brown";

            // lisätään eläimet eläintarhaan..

            korkeasaari.AddAnimal(animal1);
            korkeasaari.AddAnimal(animal2);
            korkeasaari.AddAnimal(animal3);
            korkeasaari.AddAnimal(animal4);

            korkeasaari.PrintData();


          
        }
    }
}
