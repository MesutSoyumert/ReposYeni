using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id=2, CategoryId=5, UnitsInStock=5, 
                                            ProductName="Kalem", UnitPrice=35};
            // ProductManager PascalCase, productManager camelCase
            // C# case sensitive'dir
            // sol taraf stack sağ taraf heap'de oluşur
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            // product1.ProductName kamera çünkü referans tip

            int sayi = 100;
            productManager.BiseyYap(sayi);
            Console.WriteLine(sayi);
            // class taki sayı çağıran yerdekini etkilemez
            // classtaki sayi=99 buraya yansimadı çünkü değer tip
            // array, class, abstract class, interface referans tip
            // Product.cs'de tanımlananlar çağıran ve çağrılanda da geçerli
            // ref ve out nedir?

            productManager.Topla2(3, 6);
            // class'ta hesaplanan değeri çağıran yerde kullanmak istiyorsan
            // class'da void kullanmayacaksın
            // void olan class kendi iiçinde işini yapar geri döner, geriye bir şey döndürmez
            // cobol'da call yaparken using'de değer gönderip geri istiyorsan returnle class'dan
            // değer döndür, class'I çağırırken parameterleri gönderirsin

            int toplamaSonucu = productManager.Topla(3, 6);
            Console.WriteLine(toplamaSonucu*2);
            // aşağıdaki de çalışır
            Console.WriteLine(productManager.Topla(3, 6) * 2);
        }
    }
}
