using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace GitTjuvochPolis
{
    internal class Citizen : Person
    {
        public override List<Inventory> GetThings()
        {
            List<Inventory> belongings = new List<Inventory>();
            belongings.Add(new Inventory("Wallet"));
            belongings.Add(new Inventory("Keys"));
            belongings.Add(new Inventory("Cell phone"));
            belongings.Add(new Inventory("Money"));

            return belongings;
        }
        public Citizen(int SetX, int SetY) : base(SetX, SetY)
        {
            Symbol = 'M';
        }
    }
}
