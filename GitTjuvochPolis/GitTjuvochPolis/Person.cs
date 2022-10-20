using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTjuvochPolis
{
    internal class Person
    {
        public bool isArrested = false;
        public int SetX { get; set; }

        public int SetY { get; set; }

        public int Direction { get; set; }

        public virtual char Symbol { get; set; }

        public Person(int setX, int setY)
        {
            Random rnd = new Random();
            SetX = setX;
            SetY = setY;
            Direction = rnd.Next(0, 10);
        }

        public void TakeStep()
        {
            int moveX = 0;
            int moveY = 0;

            switch (Direction)//N S W E NW NE SW SE.
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
            //SetX += moveX;
            //SetY += moveY;
            SetX = ((SetX + moveX % 100) + 100) % 100;
            SetY = ((SetY + moveY % 25) + 25) % 25;
            //if (SetY >= 25)
            //{
            //    SetY = 1;
            //}
            //if (SetY <= 0)
            //{
            //    SetY = 24;
            //}
            //if (SetX >= 100)
            //{
            //    SetX = 1;
            //}
            //if (SetX <= 0)
            //{
            //    SetX = 99;
            //}
        }

        public void CheckCollision(Person person, Person personTwo)
        {
            if (person is Thief && personTwo is Citizen || person is Citizen && personTwo is Thief)
            {
                if (person.SetX == personTwo.SetX && person.SetY == personTwo.SetY)
                {
                    Console.SetCursorPosition(0, 26);
                    Console.WriteLine("Tjuv rånar medborgare!");
                    Thread.Sleep(100);
                }
            }
            if (person is Police && personTwo is Thief || person is Thief && personTwo is Police)
            {
                if (person.SetX == personTwo.SetX && person.SetY == personTwo.SetY)
                {
                    Console.SetCursorPosition(0, 26);
                    Console.WriteLine("Polis fångar tjuv!");
                    if (person is Thief)
                    {
                        person.isArrested = true;
                    }
                    //((Thief)person).isArrested = true;
                    Thread.Sleep(2000);

                }
            }
        }

        public void SendToPrison(List<Person> p)
        {
            Prison prison = new Prison();
            for (int i = 0; i < p.Count; i++)
            {
                if (p[i] is Thief)
                {
                    if (p[i].isArrested == true)
                    {
                        p.Remove(p[i]);
                        //prison.prisoners.Add(p[i]);
                        prison.AddPerson(p[i]);
                    }
                }
            }
        }
    }
}
