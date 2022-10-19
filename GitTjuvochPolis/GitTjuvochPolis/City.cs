using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTjuvochPolis
{
    internal class City
    {
        public List<Person> people = new List<Person>();
        public void Addperson(Person person)
        {
            people.Add(person);
        }
    }
}
