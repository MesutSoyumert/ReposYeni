using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            // string kurs2 = "Programlamaya başlangıç için temel kurs";
            // string kurs3 = "Java Kursu";
            // string kurs4 = "Python Kursu";
            // string kurs4 = "C++ Kursu";

            // array - dizi olarak tanımlanabilir. kurslar isimli array içine

            // string[] kurslar = kurslarigetir;
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                                              "Programlamaya başlangıç için temel kurs",
                                              "Java Kursu",
                                              "Python Kursu", 
                                              "C++ Kursu"};

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for döngüsü bitti");
                        
            // Array için foreach daha kolay
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs); 
            }

            Console.WriteLine("Sayfa sonu - footer göster");
        }
    }
}
