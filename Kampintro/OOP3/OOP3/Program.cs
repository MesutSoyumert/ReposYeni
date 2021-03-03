using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            
            IKrediManager tasitKrediManager = new TasitKrediManager();
            
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseloggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };
            
            // yukarıdaki kredi tiplerini ekrana gösterip
            // kullanıcının bir tanesini seçtiğini varsayalım
            // Interface onu implemet eden class'ın referansını tutar

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);


            // bu durumda ekrandan kullanıcının girdiği ilgili kredi türüne ait
            // hesaplama çalışır
            // Magic !!

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

            // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            // SOLID'in O harfi Open - Close Principle der ki:
            // sisteme yeni bir özellik eklendiğinde mevcut kodlar bozulmaz

            // yeni tür esnaf kredisi eklemek ve SmsGönderme istendiği zaman
            //EsnafKrediManager class olarak ekle
            //ISmsLogger diye bir interface implement et
        }
    }
}
