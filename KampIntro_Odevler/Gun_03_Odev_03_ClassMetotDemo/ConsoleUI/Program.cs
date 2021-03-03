using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager(new EfMusteriDal());

            foreach (var musteri in musteriManager.GetAll())
            {
                MusteriListeSatiri(musteri);
            }
        }

        private static void MusteriListeSatiri(Entities.Concrete.Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriId.ToString(), " + ",
                              musteri.MusteriAdiSoyadi, " + ",
                              musteri.MusteriAdresi, " + ",
                              musteri.MusteriSehir);
        }
    }
}
