using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IColorExistService
    {
        bool CheckIfColorExist(Color color);
    }
}
