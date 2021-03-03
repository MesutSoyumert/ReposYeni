using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Musteri
    {
        // Çok önemli
        // kullanmayacağın değişkeni class'da belirtme
        // Bireysel müşterilere ait olmayan SirketAdi, VergiNo gibi sahaları tutma
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        // Gerçek ve tuzel müşterideki ortak sahaları burada kullanırız
        // Musteri ebeveyn class, gerçek ve tüzel'ler 
        // ise inherited

    }
}
