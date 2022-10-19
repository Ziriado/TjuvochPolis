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
        public List<Person> people = new List<Person>();
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
        }

        public void TakeStep(int random)
        {
            int moveX = 0;
            int moveY = 0;
          
            switch (random)//N S W E NW NE SW SE
            {
                case 1: //Norrut
                    moveX = 0;
                    moveY = -1;
                    break;
                case 2: //SÖder
                    moveX = 0;
                    moveY = 1;
                    break;
                case 3: //west
                    moveX = -1;
                    moveY = 0;
                    break;
                case 4: //east
                    moveX = 1;
                    moveY = 0;
                    break;
                case 5: //northwest
                    moveX = -1;
                    moveY = -1;
                    break;
                case 6: //northeast
                    moveX = +1;
                    moveY = -1;
                    break;
                case 7: //southwest
                    moveX = -1;
                    moveY = +1;
                    break;
                case 8: //southeast
                    moveX = +1;
                    moveY = +1;
                    break;
                case 9: // standstill
                    moveX = 0;
                    moveY = 0;
                    break;                    
            }
        }

    }
}