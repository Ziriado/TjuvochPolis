namespace GitTjuvochPolis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City city = new City();
            Prison prison = new Prison();
            Person person = new Person(0, 0);

            Random rnd = new Random();


            for (int i = 0; i < 12; i++)
            {
                city.AddPerson(new Citizen(rnd.Next(0, 100), rnd.Next(0, 25)));
            }
            for (int i = 0; i < 12; i++)
            {
                city.AddPerson(new Thief(rnd.Next(0, 100), rnd.Next(0, 25)));
            }
            for (int i = 0; i < 12; i++)
            {
                city.AddPerson(new Police(rnd.Next(0, 100), rnd.Next(0, 25)));
            }

            while (true)
            {
                Console.Clear();
                city.DrawCity();
                for (int i = 0; i < city.people.Count; i++)
                {
                    city.people[i].TakeStep();
                    for (int j = 1; j < city.people.Count; j++)
                    {
                        if (i != j)
                        {
                            person.CheckCollision(city.people[i], city.people[j]);
                            person.SendToPrison(city.people);
                        }
                    }
                    //method for checking collision
                    //if collision happens check which subclasses
                    //create bool to check if thief is captured
                    //Code alot yes
                }
                Console.CursorVisible = false;
                prison.DrawPrison();
                Thread.Sleep(500);
                
            }

        }
    }
}