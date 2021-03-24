using System;

namespace CleanCodeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductManager(new FakeBankService());
            //IProductService productService = new ProductManager(new CentralBankServiceAdapter());

            productService.Sell(new Product { Id = 1, Name = "Laptop", Price = 1000 },
                                new Customer { Id = 1, Name = "Engin", IsStudent = true, IsOfficer = false });
        }
    }
    class Customer : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsStudent { get; set; }
        public bool IsOfficer { get; set; }
    }
    class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class ProductManager : IProductService
    {
        private IBankService _bankService;
        public ProductManager(IBankService bankService)
        {
            _bankService = bankService;
        }
        public void Sell(Product product, Customer customer)
        {
            decimal price = product.Price;
            if (customer.IsStudent)
            {
                price = product.Price * (decimal)0.90;
            }
            if (customer.IsOfficer)
            {
                price = product.Price * (decimal)0.80;
            }
            price = _bankService.ConvertRate(new CurrencyRate { Currency = 1, Price = price });
            Console.WriteLine(price);
            Console.WriteLine();
        }
    }
    interface IProductService
    {
        void Sell(Product product, Customer customer);
    }
    interface IEntity
    {
    }
    class FakeBankService : IBankService
    {
        public decimal ConvertRate(CurrencyRate currencyRate)
        {
            return currencyRate.Price / (decimal) 5.30;
        }
    }

    internal interface IBankService
    {
        decimal ConvertRate(CurrencyRate currencyRate);
    }

    class CurrencyRate
    {
        public decimal Price { get; set; }
        public int Currency { get; set; }
    }
    class CentralBankServiceAdapter : IBankService
    {
        public decimal ConvertRate(CurrencyRate currencyRate)
        {
            CentralBankService centralBankService = new CentralBankService();
            return centralBankService.ConvertCurrency(currencyRate);
        }
    }

    class CentralBankService
    {
        public decimal ConvertCurrency(CurrencyRate currencyRate)
        {
            return currencyRate.Price / (decimal)5.28;
        }
    }
}
