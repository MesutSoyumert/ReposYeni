using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            // Başvuran bilgilerini değerlendirme
            //
            // KonutKrediManager konutKrediManager = new KonutKrediManager();
            // konutKrediManager.Hesapla();
            // Yukarıdakileri böyle yazınca bütün kredi
            // başvuruları konut kredisi gibi hesaplanır
            // BasvuruYap class parametreleri olarak parantez içine
            // IKrediManager krediManager eklersek class'ımız
            // kredi türünden bağımsız olarak aşağıdaki
            // komutlarla çalışır
            
            krediManager.Hesapla();
            // sistemde hangi loglama seçildi ise ona göre logla
            // Buna Method Injection denir
            // Construction Injection ödevde araştırılacak
            // soyut halleri var somut hallerini inject ediyoruz
            // ne kadar loglama var ise çalıştır
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
           
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            } 
        }
    }
}
