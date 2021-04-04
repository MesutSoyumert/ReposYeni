using Gun_05_Odev_05.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun_05_Odev_05.Entities
{
    public class Sale : IEntity
    {
        public int SaleId { get; set; }
        public int SalePlayerId { get; set; }
        public string SaleName { get; set; }
        public DateTime SaleStartingDate { get; set; }
        public DateTime SaleEndingTime { get; set; }
        public Decimal SaleDiscountRate { get; set; }
    }
}
