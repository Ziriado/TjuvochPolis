namespace GitTjuvochPolis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City city = new City();
            
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                city.AddPerson(new Citizen(rnd.Next(0, 100), rnd.Next(0, 25)));
            }
            for (int i = 0; i < 5; i++)
            {
                city.AddPerson(new Thief(rnd.Next(0, 100), rnd.Next(0, 25)));
            }
            for (int i = 0; i < 5; i++)
            {
                city.AddPerson(new Police(rnd.Next(0, 100), rnd.Next(0, 25)));
            }

            city.DrawCity();

        }
    }
}