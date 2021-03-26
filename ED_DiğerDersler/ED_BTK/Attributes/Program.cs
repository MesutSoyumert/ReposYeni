using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {
                Id=1, 
                LastName="Soyumert", 
                Age=60 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }
    [ToTable("Customers")]
    [ToTable("TblCustomers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }
    class CustomerDal
    {
        [Obsolete("Artık bunu kullanma, bunun yerine AddNew metodunu kullan(Don't use Add, instead use AddNew method)")]
        public void Add(Customer customer) 
        {
            Console.WriteLine("{0},{1},{2},{3} added!",
                customer.Id,
                customer.FirstName,
                customer.LastName,
                customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!",
                customer.Id,
                customer.FirstName,
                customer.LastName,
                customer.Age);
        }
    }
    //[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)] Bu komutla field bazında da yapılabilir.
    [AttributeUsage(AttributeTargets.Property)]
    class RequiredPropertyAttribute : Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
