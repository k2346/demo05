/**
*Copyright Jenni Rohunen
*
*
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    /// <summary>
    /// This class holds person objects in a collection        // tämä kommentointitapa on ns. virallinen 
    /// </summary>
    class PersonRegister
    {   /// <summary>
        /// persons list stores person objects
        /// </summary>
        private List<Person> persons;          //Private määrittely suojaa listan //geneerinen määrittely listaan, lista ei voi sisältää kuin person luokan objekteja. TENTTIKYSYMYS
        /// <summary>
        /// default constructor initializes a colllection
        /// </summary>

        public PersonRegister()
        {
            persons = new List<Person>();
        }
        /// <summary>
        /// Adds a new person to collection
        /// </summary>
        /// <param name="person">person to added</param>
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }
        /// <summary>
        /// Returns a person to caller application
        /// </summary>
        /// <param name="index">person index collection</param>
        /// <returns>person index collection</returns>
        public Person GetPerson(int index) // index on syötettyjen personsien määrä

        {
            if (index < persons.Count) // count palauttaa lukumäärän // laitetaan pääohjelma huolehtimaan sitten tulostuksesta mitä sielä paikassa on
            {
                return persons.ElementAt(index);
            }
            else
            { 
                return null;
            }
        }

        public Person FindPerson(string socialSecurityNum) //public void ei palauttaisi mitään// public person palauttaa person  
        {
            foreach (Person person in persons) //käydään läpi kaikki henkilöt listassa nimeltä persons
            {//is sotu the same..
                if (socialSecurityNum.Equals(person.SocialSecurityNum))
                {
                    return person; // palauttaa henkilön millä oli samanlainen sotu mitä syötettiin
                }
            }
            return null; // ei löytynyt henkilöä sillä sotulla
        }

        public void PrintData()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("******My awesome collection********");
            Console.WriteLine("***********************************");

            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }

        }
    }
}
