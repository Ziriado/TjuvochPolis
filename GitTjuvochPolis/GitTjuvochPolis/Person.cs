using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GitTjuvochPolis
{
    internal class Person
    {
        public bool isArrested = false;

        public bool isThief = false;
        public int SetX { get; set; }

        public int SetY { get; set; }

        public int Direction { get; set; }

        public virtual char Symbol { get; set; }

        public List<Inventory> Inventory { get; set; }

        public virtual List<Inventory> GetThings()
        {
            {
                List<Inventory> inventory = new List<Inventory>();

                return inventory;
            }
        }

        public Person(int setX, int setY)
        {
            Random rnd = new Random();
            SetX = setX;
            SetY = setY;
            Direction = rnd.Next(0, 10);
            Inventory = GetThings();
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
            Citizen citizen = new Citizen(0, 0);
            Random rnd = new Random();
            int randomItem = rnd.Next(0, Inventory.Count);
            
            if (person is Thief && personTwo is Citizen || person is Citizen && personTwo is Thief)
            {
                if (person.SetX == personTwo.SetX && person.SetY == personTwo.SetY)
                {
                    if (person is Thief || personTwo is Thief)
                    {
                        isThief = true;
                    }
                    Console.SetCursorPosition(0, 26);
                    Console.WriteLine("Tjuv rånar medborgare!");                    
                    Thread.Sleep(800);
                    if (person is Citizen && Inventory.Count > 0)
                    {       
                        personTwo.Inventory.Add(person.Inventory[randomItem]);
                        person.Inventory.RemoveAt(randomItem);
                    }
                    else if (personTwo is Citizen && Inventory.Count > 0)
                    {
                        person.Inventory.Add(personTwo.Inventory[randomItem]);
                        personTwo.Inventory.RemoveAt(randomItem);
                    }
                }
            }
            if (person is Police && personTwo is Thief || person is Thief && personTwo is Police)
            {
                if (person.SetX == personTwo.SetX && person.SetY == personTwo.SetY)
                {
                    Console.SetCursorPosition(0, 26);
                    
                    
                    if (person is Thief && isThief==true|| personTwo is Thief && isThief==true)
                    {
                        Console.WriteLine("Polis fångar tjuv!");
                        person.isArrested = true;
                        Thread.Sleep(1000);
                    }
                    //((Thief)person).isArrested = true;
                    if(person is Thief &&isThief==false ||personTwo is Thief && isThief==false)
                    {
                        Console.WriteLine("Polisen vinkar till den blivande tjuven");
                        Thread.Sleep(1000);
                    }
                    if (person is Police)
                    {
                        person.Inventory.AddRange(personTwo.Inventory);
                        personTwo.Inventory.Clear();
                    }
                    else if (personTwo is Police)
                    {
                        personTwo.Inventory.AddRange(person.Inventory);
                        person.Inventory.Clear();
                    }

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
