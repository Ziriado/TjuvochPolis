using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTjuvochPolis
{
    internal class Prison
    {
        public List<Person> prisoners = new List<Person>();//
        public void AddPerson(Person thiefs)
        {
            prisoners.Add(thiefs);
        }
        public void DrawPrison()
        {
            Console.SetCursorPosition(0, 28);
            char[,] thePrison = new char[10, 10];

            foreach (Thief t in prisoners)
            {
                thePrison[t.SetY, t.SetX] = t.Symbol;
            }

            for (int row = 0; row < thePrison.GetLength(0); row++)
            {
                for (int col = 0; col < thePrison.GetLength(1); col++)
                {
                    Console.Write(thePrison[row, col] == 0 ? ' ' : thePrison[row, col]);
                }

                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
