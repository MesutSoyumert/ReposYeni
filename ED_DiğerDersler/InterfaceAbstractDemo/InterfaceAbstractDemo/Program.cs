using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            //BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter);
            customerManager.Save(new Entities.Customer
            {
                DateOfBirthYear = 1985,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                NationalityId = 28861499108
            });
            Console.ReadLine();
        }
    }
}
