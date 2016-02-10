using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a register
            PersonRegister myFriends = new PersonRegister();

            //create a new person
            Person person1 = new Person();
            person1.Firstname = "Matti";
            person1.Lastname = "Mainio";
            person1.SocialSecurityNum = "231- 225";

            Person person2 = new Person { Firstname = "Kirsi", Lastname = "Kernel", SocialSecurityNum = "123 - 4856" };

            // add person to the collection
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);

            //get one person from register
            Person person3 = myFriends.GetPerson(0); //index = 0
            if (person3 != null)
            {
                Console.WriteLine(person3.ToString());
            }
            else
            {
                Console.WriteLine("Can't find person in that index");
            }

            string sotu = "123 - 4856";
            Console.WriteLine("Finding person with sotu..");
            Person person4 = myFriends.FindPerson(sotu);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            } else
            {
                Console.WriteLine("Can't fina person with that sotu..");
            }

            myFriends.PrintData();
            }
    }
}
