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

        //public int Direction { get; set; }

        public virtual char Symbol { get; set; }

        public Person(int setX, int setY)
        {
            this.SetX = setX;
            SetY = setY;
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
