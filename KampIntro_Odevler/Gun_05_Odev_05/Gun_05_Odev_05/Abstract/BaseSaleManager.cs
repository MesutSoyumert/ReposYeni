using Gun_05_Odev_05.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun_05_Odev_05.Abstract
{
    public abstract class BaseSaleManager : ISaleService
    {
        public virtual void Add(Sale sale, Player player)
        {
            Console.WriteLine("Oyun satışı gerçekleşti : " + sale.SaleId + " " + sale.SaleName + " " + sale.SalePlayerId);
        }
    }
}
