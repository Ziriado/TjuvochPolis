using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTjuvochPolis
{
    internal class Citizen : Person
    {
        public Citizen(int SetX, int SetY) : base(SetX, SetY)
        {
            Symbol = 'M';
        }
    }
}
