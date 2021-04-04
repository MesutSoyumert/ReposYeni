using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMusteriService
    {
        List<Musteri> GetAll();
        List<Musteri> GetAllByCity(string sehir);
    }
}
