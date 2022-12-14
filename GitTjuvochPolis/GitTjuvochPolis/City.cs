using GitTjuvochPolis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTjuvochPolis
{
    internal class City
    {
        Citizen citizen = new Citizen(0, 0);
        public List<Person> people = new List<Person>();
        Prison prison = new Prison();
        Random rnd = new Random();
        Person person = new Person(0, 0);
        public void AddPerson(Person person, List<Inventory> inventory)
        {
            people.Add(person);
            if (person.isArrested == true){
                prison.AddPerson(person);
                people.Remove(person);
            }
        }
        public void DrawCity()
        {
            char[,] theCity = new char[25, 100];

            foreach (Person person in people)
            {
                theCity[person.SetY, person.SetX] = person.Symbol;
            }

            for (int row = 0; row < theCity.GetLength(0); row++)
            {
                for (int col = 0; col < theCity.GetLength(1); col++)
                {
                    Console.Write(theCity[row, col] == 0 ? ' ' : theCity[row, col]);
                }

                Console.WriteLine();
            }
            Console.WriteLine();
            ListOfPersons();
        }
        public void ListOfPersons()
        {
            int count = 0;
            for (int i = 0; i < people.Count; i++)
            {
                Console.SetCursorPosition(101, count);

                Console.Write($"{people[i].GetType().Name}:\t{people[i].SetX}, {people[i].SetY}, {people[i].Inventory.Count}\t");
                //if (people[i] is Citizen)
                //{
                //    var a = ((Citizen)people[i]).Inventory;
                //    foreach (var b in a.ToList())
                //    {
                //        Console.Write($"{b.thingName} ");
                //    }
                //}
                //else if (people[i] is Thief)
                //{
                //    var a = ((Thief)people[i]).Inventory;
                //    foreach (var b in a.ToList())
                //    {
                //        Console.Write($"{b.thingName} ");
                //    }
                //}
                //else if (people[i] is Police)
                //{
                //    var a = ((Police)people[i]).Inventory;
                //    foreach (var b in a.ToList())
                //    {
                //        Console.Write($"{b.thingName} ");
                //    }
                //}
                Console.WriteLine($"");
                count++;
            }
        }
    }
}