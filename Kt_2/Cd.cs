using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kt_2
{
    class Cd
    {
        public string Artist { get; set; }
        public int Price { get; set; }
        private List<Song> songs;
       

        public Cd()
        {
            songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
        }

        public void PrintData()
        {
            Console.WriteLine("CD Data: ");
            Console.WriteLine("- Artist: " + Artist);
            Console.WriteLine("- Price: " + Price);
            Console.WriteLine("- Songs: ");


            foreach (Song song in songs)
            {
                Console.WriteLine(song.ToString());
            }

        }



    }
}
