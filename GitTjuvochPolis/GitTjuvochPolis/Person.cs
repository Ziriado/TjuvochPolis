using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTjuvochPolis
{
    internal class Person
    {
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
            SetX = ((SetX + moveX  % 100) + 100) % 100;
            SetY = ((SetY + moveY % 25) + 25) % 25;
        }

        internal void Meeting()
        {
        }
    }


    class Citizen : Person
    {
        public Citizen(int SetX, int SetY) : base(SetX, SetY)
        {
            Symbol = 'M';
        }
    }
    class Thief : Person
    {
        public Thief(int SetX, int SetY) : base(SetX, SetY)
        {
            Symbol = 'T';
        }
    }
    class Police : Person
    {
        public Police(int SetX, int SetY) : base(SetX, SetY)
        {
            Symbol = 'P';
        }
    }
}
