using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTjuvochPolis
{
    internal class Police : Person
    {
        public Police(int SetX, int SetY) : base(SetX, SetY)
        {
            Symbol = 'P';
        }
    }
}
