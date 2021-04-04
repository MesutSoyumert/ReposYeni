using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;
        public InMemoryColorDal()
        {
            _colors = new List<Color>
            {
                new Color {Id=1, Name="Beyaz"},
                new Color {Id=2, Name="Gri"},
                new Color {Id=3, Name="Siyah"},
                new Color {Id=4, Name="Kırmızı"},
                new Color {Id=5, Name="Mavi"},
            };
        }
        public void Add(Color color)
        {
            _colors.Add(color);
        }

        public void Delete(Color color)
        {
            Color colorToDelete = _colors.SingleOrDefault(p => p.Id == color.Id);
            _colors.Remove(color);
        }

        public List<Color> GetAll()
        {
            return _colors;
        }

        public List<Color> GetById(int id)
        {
            return _colors.Where(p => p.Id == id).ToList();
            ;
        }

        public void Update(Color color)
        {
            Color colorToUpdate = _colors.SingleOrDefault(p => p.Id == color.Id);
            colorToUpdate.Name = color.Name;
        }
    }
}
