using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand {Id=1, Name="Skoda"},
                new Brand {Id=2, Name="Fiat"},
                new Brand {Id=3, Name="Renault"},
                new Brand {Id=4, Name="BMW"},
                new Brand {Id=5, Name="Mercedes"},
            };
        }

        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            Brand brandToDelete = _brands.SingleOrDefault(p => p.Id == brand.Id);
            _brands.Remove(brand);
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public List<Brand> GetById(int id)
        {
            return _brands.Where(p => p.Id == id).ToList();
        }

        public void Update(Brand brand)
        {
            Brand brandToUpdate = _brands.SingleOrDefault(p => p.Id == brand.Id);
            brandToUpdate.Name = brand.Name;
        }
    }
}
