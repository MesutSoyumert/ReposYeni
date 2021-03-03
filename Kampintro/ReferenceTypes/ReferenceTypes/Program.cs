using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // int, decimal, float, enum, boolean türü değişkenler valu types değişkenlerdir
            // value type değişkenler memory'de stack'e yerleşir, adresin yanında değeri tutulur
            // reference type değişkenler memory'de heap'e yerleşir, adres tutulut
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;

            sayi2 = 100;

            Console.WriteLine("Sayı 1 : " + sayi1);

            //arrays, class, interface ... reference types değişkenlerdir
            // referans tip depişkenlerin stack'de değeri yerine değerlerin bulunduğu heap adresi tutulur

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;

            Console.WriteLine("Sayılar1[0} : " + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1;
            person1.FirstName = "Derin";

            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "234567890";

            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer;
            customer.FirstName = "Ahmet";


            // (((Customer)person3).CreditCardNumber) yazılışına boxing denir
            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);

        }
    }
    //Persone parent tipi bir sınıftır
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    //base class : Person, Customer child bir class'tır, inherited denir
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee : Person
    {
        public int  EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        // yukarıdaki class tanımlamalarında Person parent, Customer ve Employee child classlar
        // olduğu için Customer ve Employee için de ortak kullanılabilecek PersonManager class'ı oluşturulur
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }

    }
}
