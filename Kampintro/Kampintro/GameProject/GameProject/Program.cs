using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1, 
                BirthYear = 1984, 
                FirstName = "ENGİN", 
                LastName ="DEMİROĞ", 
                IdentityNumber = 12345678901
            });
            Console.WriteLine("Hello World!");
        }
    }
}
