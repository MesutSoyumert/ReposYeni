using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Musteri:IEntity
    {
        public Musteri()
        {

        }
        public Musteri(int musteriid, string musteriadisoyadi, string musterisadresi, string musterisehir)
        {
            MusteriId = musteriid;
            MusteriAdiSoyadi = musteriadisoyadi;
            MusteriAdresi = musterisadresi;
            MusteriSehir = musterisehir;
        }

        public int MusteriId { get; set; }
        public string MusteriAdiSoyadi { get; set; }
        public string MusteriAdresi { get; set; }
        public string MusteriSehir { get; set; }
    }
}
