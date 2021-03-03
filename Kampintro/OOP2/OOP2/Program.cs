using System;

namespace OOP2
{
    class Program
    {
    // Bu derste soyutlama çalışılacak
        static void Main(string[] args)
        {
            // Engin Demiroğ bireysel müşteri
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "1234567890";

            // Kodlama.io tüzel müşteri
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "123456789";

            // Gerçek Müşteri - Tüzel Müşteri
            // Ayrı class yap
            // MusteriTipi diye bir saha tutmaya gerek yok
            // SOLID ilkeleri gereği
            // Aynı Musteri class'ı gerçek ve tüzel müşteriyi tutabiliyor
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            // gerçek ve tüzel inherited olduğu için 
            // aynı operasyon class'ı olan musteriManager tarafından işlem görebilir


            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);


        }
    }
}
