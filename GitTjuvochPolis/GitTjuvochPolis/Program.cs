namespace GitTjuvochPolis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City city = new City();
            Person person = new Person(0, 0);
            
            Random rnd = new Random();


            for (int i = 0; i < 10; i++)
            {
                city.AddPerson(new Citizen(rnd.Next(0, 100), rnd.Next(0, 25)));
            }
            for (int i = 0; i < 10; i++)        
            {
                city.AddPerson(new Thief(rnd.Next(0, 100), rnd.Next(0, 25)));
            }
            for (int i = 0; i < 10; i++)
            {
                city.AddPerson(new Police(rnd.Next(0, 100), rnd.Next(0, 25)));
            }
            while (true)
            {
                foreach (Person p in city.people)
                {
                    p.TakeStep();
                    foreach (Person otherP in city.people)
                    {
                        if (p != otherP)
                        {
                            person.CheckCollision(otherP, p);                        
                        }
                    }
                    //method for checking collision
                    //if collision happens check which subclasses
                    //create bool to check if thief is captured

                }
                city.DrawCity();
                //person.CheckCollision(person);
                Thread.Sleep(50);
                Console.Clear();
            }
        }
    }
}