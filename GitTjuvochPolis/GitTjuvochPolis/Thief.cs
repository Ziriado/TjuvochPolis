using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTjuvochPolis
{
    internal class Thief:Person
    {
        public bool IsArrested { get; set; }
        public Thief(int SetX, int SetY) : base(SetX, SetY)
        {
            IsArrested = false;
            Symbol = 'T';
            isThief = false;
           
            }
        }
    }

