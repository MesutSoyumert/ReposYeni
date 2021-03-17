using ReCapProject_Gun_08_Odev_01.Core.DataAccess;
using ReCapProject_Gun_08_Odev_01.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject_Gun_08_Odev_01.DataAccess.Abstract
{
    public interface IColorDal : IEntityRepository<Color>
    {
    }
}
