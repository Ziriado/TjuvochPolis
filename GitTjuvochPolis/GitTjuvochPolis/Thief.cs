using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace GitTjuvochPolis
{
    internal class Thief : Person
    {
        public bool IsArrested { get; set; }
        public override List<Inventory> GetThings()
        {
            List<Inventory> loot = new List<Inventory>();

            return loot;
        }
        public Thief(int SetX, int SetY) : base(SetX, SetY)
        {
            IsArrested = false;
            Symbol = 'T';
            isThief = false;
        }
    }
}
