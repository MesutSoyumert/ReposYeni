using Gun_05_Odev_05.Abstract;
using Gun_05_Odev_05.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun_05_Odev_05.Concrete
{
    public class SaleManager : BaseSaleManager
    {
        IPlayerExistService _playerExistService;
        ICampaignExistService _campaignExistService;


        public SaleManager(IPlayerExistService playerExistService)
        {
            _playerExistService = playerExistService;
        }
        public override void Add(Sale sale, Player player)
        {

            if (_playerExistService.CheckIfPlayerExist(player) == true)
            {
                    base.Add(sale, player);
                    Console.WriteLine("Kampanyalı satış gerçekleştirildi");
                    Console.ReadLine();
                }
            else
            {
                Console.WriteLine("Satış yapılması istenen oyuncu kayıtlı değil");
                Console.ReadLine();
            }
        }
    }
}
