using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            // array'e bir eleman daha eklemek gerekti
            // isimler[4] = "İlker";
            // Console.WriteLine(isimler[4]);
            // yukarıdaki gibi yaparsak out of array runtime error alır

            //aşağıdaki yapınca düzelir array sayısını arttırırız
            isimler = new string[5];
            isimler[4] = "İlker";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);
            // isimler[0] null, çünkü string'i new ettik, bütün array space oldu
            // array eleman sayısını arttırdık ama eski değerleri kaybettik
            // bu aşağıdaki gibi koleksiyonlarla çözülür
            // array yerine koleksiyon tercih edilir
            // new deyince heap'te boşluk ataması yapar

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            
            // isimler2.Add komutu ile de eklenebilir
            // array'e bir eleman daha eklemek gerekti
            
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            

        }
    }
}
