using EntityFrameWorkDemo.Business;
using EntityFrameWorkDemo.DataAccess.Concrete;
using System;
using System.Linq;

namespace EntityFrameWorkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ADO.NET
            //Entity Framework - bir ORM - Object Relational Mapping
            //NHibernate alternatif
            // Dapper var, ADO.NET için kullanılabilir

            //GetAll();
            //GetproductsByCategory(1);

            ProductManager productManager = new ProductManager(new EfProductDal());

            productManager.Add(new Product {ProductName = "Masa", QuantityPerUnit = "4 ayaklı masa", CategoryId = 1, UnitPrice = 1000, UnitsInStock = 10 });

            //productManager.Update(new Product { ProductId = 78, ProductName = "Masa 2", QuantityPerUnit = "6 ayaklı masa", CategoryId = 2, UnitPrice = 1000, UnitsInStock = 10 });

            //productManager.Delete(new Product { ProductId = 78, ProductName = "Masa 2", QuantityPerUnit = "6 ayaklı masa", CategoryId = 2, UnitPrice = 1000, UnitsInStock = 10 });

            Console.WriteLine(productManager.GetById(1).ProductName);
            
            
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            
            // Employees ile Personel mappingi için alt satırlar
            PersonelManager personelManager = new PersonelManager(new EfPersonelDal());
            foreach (var personel in personelManager.GetAll())
            {
                Console.WriteLine("{0} / {1} / {2}", personel.Id, personel.Name, personel.Surname);
            }
        }

        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();
            foreach (var product in northwindContext.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }
        private static void GetproductsByCategory(int categoryId)
        {
            NorthwindContext northwindContext = new NorthwindContext();

            var result = northwindContext.Products.Where(p => p.CategoryId == categoryId);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
