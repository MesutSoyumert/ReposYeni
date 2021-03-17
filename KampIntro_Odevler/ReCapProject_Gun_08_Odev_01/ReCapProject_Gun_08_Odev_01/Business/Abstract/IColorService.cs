using ReCapProject_Gun_08_Odev_01.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject_Gun_08_Odev_01.Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetById(int id);
        void Add(Color color);
        void Delete(Color color);
        void Update(Color color);

    }
}
