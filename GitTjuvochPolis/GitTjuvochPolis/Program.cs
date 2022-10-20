namespace GitTjuvochPolis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City city = new City();
            
            Random rnd = new Random();

            for (int i = 0; i < 1; i++)
            {
                city.AddPerson(new Citizen(rnd.Next(0, 100), rnd.Next(0, 25)));
            }
            for (int i = 0; i < 1; i++)
            {
                city.AddPerson(new Thief(rnd.Next(0, 100), rnd.Next(0, 25)));
            }
            for (int i = 0; i < 1; i++)
            {
                city.AddPerson(new Police(rnd.Next(0, 100), rnd.Next(0, 25)));
            }
            while (true)
            {
                foreach (Person person in city.people)
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
                city.DrawCity();
                Thread.Sleep(100);
                Console.Clear();
            }
        }
    }
}