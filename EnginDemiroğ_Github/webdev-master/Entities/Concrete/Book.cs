using Core.Entities;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Entities.Concrete
{
    public class Book:IEntity
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        
    }
}
