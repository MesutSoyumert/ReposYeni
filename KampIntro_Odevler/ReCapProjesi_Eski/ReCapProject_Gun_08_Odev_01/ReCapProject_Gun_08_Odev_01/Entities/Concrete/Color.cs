using ReCapProject_Gun_08_Odev_01.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject_Gun_08_Odev_01.Entities.Concrete
{
    public class Color : IEntity
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }
}
