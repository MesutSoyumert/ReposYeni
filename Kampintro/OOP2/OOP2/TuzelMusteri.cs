using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Corporate /legal) customer
    // Özellik class'larına operasyon ekleme
    // TuzelMusteri:Musteri 'ye inheritance denir
    // TuzelMusteri bir Musteri'dir diyoruz
    // Musteri'deki özelliklerin hepsi TuzelMusteri'de de vardır

    class TuzelMusteri:Musteri
    {
       
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
