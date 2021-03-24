using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorExistManager : IColorExistService
    {
        public bool CheckIfColorExist(Color color)
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var result = colorManager.GetById(color.Id);

            if (result.Success == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
