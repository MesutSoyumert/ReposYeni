using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class MusteriManager : IMusteriService
    {
        IMusteriDal _musteriDal;

        public MusteriManager(IMusteriDal musteriDal)
        {
            _musteriDal = musteriDal;
        }

        public List<Musteri> GetAll()
        {
            return _musteriDal.GetAll();
        }

        public List<Musteri> GetAllByCity(string sehir)
        {
            return _musteriDal.GetAll(p=>p.MusteriSehir == sehir);
        }

    }
}
