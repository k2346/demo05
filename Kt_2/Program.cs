using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a register
            

            //luo cd olio
            Cd collection = new Cd();
            collection.Artist = "Kreisibailaus kokoelma vol 12";
            collection.Price = 12;
            //luo parit biisit
            Song song1 = new Song();
            song1.Name = "Smurffit - Smurffijengi";
            song1.TrackLenght = "3:46";

            Song song2 = new Song();
            song2.Name = "Backstreet boys - Everybody";
            song2.TrackLenght = "2:55";

            Song song3 = new Song();
            song3.Name = "Sanni - Että mitähän vittua";
            song3.TrackLenght = "3:20";


            //lisätään kappaleet cd:hen

            collection.AddSong(song1);
            collection.AddSong(song2);
            collection.AddSong(song3);

            //tulosta cn:n sisältö

            collection.PrintData();
        }




    }
}
