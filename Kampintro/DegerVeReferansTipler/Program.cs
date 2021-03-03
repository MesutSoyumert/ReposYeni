using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1'in değeri nedir? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            // sayilar1[0] değeri nedir? 999

            // int, decimal, float, double, bool 'Değer Tip' dir
            // array, class, interface 'Referans Tip' dir
            // çünkü değer tip olanlar memory'de stack'e yerleşir
            // referans tip olanlar memory'de heap'e yerleşir
            // new komutu heap'da alan oluşturur ve orayı kullanır
            // stack'da sayilar1 label'i ve heap'deki adresi bulunur
            // yani sayilar1 = sayilar2 ile eşitlenen arraylerde
            // sayilar1 labeline sayılar2'nin adresi atanır
            // C dilindeki pointer
            // sayilar1 = sayilar2 eşitlemesi sonrasında .NET
            // garbage.collector tarafından sayılar1 için tutulan değerler temizlenir


        }
    }
}
