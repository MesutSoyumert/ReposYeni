using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        // Bu sadece özellik içeren class'tır
        // Primary Key ID ilk sırada yazılır
        public int Id { get; set; }
        // Secondary key ikinci sıraya Id suffix ile yazılır
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }


    }
}
