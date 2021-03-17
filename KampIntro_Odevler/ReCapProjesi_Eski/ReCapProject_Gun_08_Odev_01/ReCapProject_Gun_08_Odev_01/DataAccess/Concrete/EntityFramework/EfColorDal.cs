using ReCapProject_Gun_08_Odev_01.Core.DataAccess.EntityFramework;
using ReCapProject_Gun_08_Odev_01.DataAccess.Abstract;
using ReCapProject_Gun_08_Odev_01.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject_Gun_08_Odev_01.DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, CarRentalContext>, IColorDal
    {
    }
}
