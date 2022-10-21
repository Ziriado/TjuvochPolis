using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace GitTjuvochPolis
{
    internal class Police : Person
    {
        public override List<Inventory> GetThings()
        {
            List<Inventory> confiscated = new List<Inventory>();

            return confiscated;
        }
        public Police(int SetX, int SetY) : base(SetX, SetY)
        {
            Symbol = 'P';
        }
    }
}
