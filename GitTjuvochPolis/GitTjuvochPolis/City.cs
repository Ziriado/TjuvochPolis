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
        public List<Person> people = new List<Person>();//
        public void AddPerson(Person person)
        {
            people.Add(person);
        }
        public void DrawCity()
        {
            char [,] theCity = new char[25, 100];

            foreach (Person person in people)
            {
                theCity[person.SetY, person.SetX] = person.Symbol;
            }

            for (int row = 0; row <theCity.GetLength(0); row++)
            {
                for(int col = 0; col < theCity.GetLength(1); col++)
                {
                    Console.Write(theCity[row, col] == 0 ? ' ' : theCity[row,col]);
                }

                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}