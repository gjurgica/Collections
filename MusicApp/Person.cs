using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoritMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }
        public Person(string firstName,string lastName,int age,Genre genre)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoritMusicType = genre;

        }
        public void GetFavoritSongs()
        {
            if(FavoriteSongs.Count == 0)
            {
                Console.WriteLine("This person hate music."); 
            }
            else
            {
                foreach(Song song in FavoriteSongs)
                {
                    Console.WriteLine($"- { song.Title}"); 
                }
            }
            
        }
    }
}
