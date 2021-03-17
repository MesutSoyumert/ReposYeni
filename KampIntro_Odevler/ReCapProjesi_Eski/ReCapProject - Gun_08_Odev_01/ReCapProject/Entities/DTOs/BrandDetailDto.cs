using ReCapProject.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject.Entities.DTOs
{
    public class BrandDetailDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
