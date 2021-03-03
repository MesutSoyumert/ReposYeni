using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1, FirstName="Engin", LastName="Demiroğ", City="Ankara" };

            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");

            Customer customer3 = new Customer();
            customer3.Id = 3;

            Console.WriteLine(customer2.FirstName);

        }

    }
    class Customer
    {
        public Customer()
        {

        }
        // default contructor
        public Customer(int id, string firstname, string lastname, string city)
        {

            Id = id;
            FirstName = firstname;
            LastName = lastname;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
