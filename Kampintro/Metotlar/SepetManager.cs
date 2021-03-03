using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention
        // syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urun.Adi);
        }
        // aşağıdaki classtaki gibi tek tek tanımlamak yerine Urun class'ı ile oynarız
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urunAdi);
        }
    }
}
