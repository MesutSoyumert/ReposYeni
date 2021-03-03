using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    // BU tür classlar operasyonları içerir
    // Create, Read, Update, Delete gibi CRUD
    // Listeleme vb
    class ProductManager
    {

        // void olan metotlar akıbet bildirmez
        public void Add(Product product)
        {
            // product.ProductName = "Kamera";
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        // void olunca sadece işlemi yapar
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }

        public void BiseyYap(int sayi)
        {
            sayi = 99;
        }
    }
}
