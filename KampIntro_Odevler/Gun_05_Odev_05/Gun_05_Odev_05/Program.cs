using Gun_05_Odev_05.Abstract;
using Gun_05_Odev_05.Adapters;
using Gun_05_Odev_05.Concrete;
using Gun_05_Odev_05.Entities;
using System;

namespace Gun_05_Odev_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("_________________________________");
            Console.WriteLine("1. Oyuncu ekleme");
            Console.WriteLine("2. Oyuncu güncelleme");
            Console.WriteLine("3. Oyuncu silme");

            //Aşağıdaki satırı kampanya entegre ettikten sonra devre dışına aldım
            // Console.WriteLine("4. Oyun satışı");
            //yukarıdaki satırı kampanya entegre ettikten sonra devre dışına aldım

            Console.WriteLine("5. Kampanya ekleme");
            Console.WriteLine("6. Kampanya güncelleme");
            Console.WriteLine("7. Kampanya silme");
            Console.WriteLine("8. Kampanyalı oyun satışı");
            Console.WriteLine("");
            Console.WriteLine("Seçiminizi Giriniz : ");


            switch (Console.ReadLine())
            {
                case "1":
                    BasePlayerManager playerManagerAdd = new PlayerManager(new MernisServiceAdapter());
                    playerManagerAdd.Add(new Entities.Player
                    {
                        PlayerDateOfBirth = new DateTime(1960, 11, 29),
                        PlayerFirstName = "Mesut",
                        PlayerLastName = "Soyumert",
                        PlayerNationalityId = 12345678901
                    });
                    Console.ReadLine();
                    break;
                case "2":
                    BasePlayerManager playerManagerUpdate = new PlayerManager(new MernisServiceAdapter());

                    playerManagerUpdate.Update(new Entities.Player
                    {
                        PlayerId = 1,
                        PlayerDateOfBirth = new DateTime(1960, 11, 29),
                        PlayerFirstName = "Mesut",
                        PlayerLastName = "Soyumert",
                        PlayerNationalityId = 12345678901
                    });
                    Console.ReadLine();
                    break;
                case "3":
                    BasePlayerManager playerManagerDelete = new PlayerManager(new MernisServiceAdapter());

                    playerManagerDelete.Delete(new Entities.Player
                    {
                        PlayerId = 1,
                        PlayerDateOfBirth = new DateTime(1960, 11, 29),
                        PlayerFirstName = "Mesut",
                        PlayerLastName = "Soyumert",
                        PlayerNationalityId = 12345678901
                    });
                    Console.ReadLine();
                    break;
                //Aşağıdaki satırları kampanya entegre ettikten sonra devre dışına aldım
                //case "4":
                //    int playerId = 0;
                //    Console.WriteLine("Oyun satışı yapılacak oyuncuyu giriniz : ");
                //    playerId = Convert.ToInt16(Console.ReadLine());

                //    BaseSaleManager saleManagerAdd = new SaleManager(new PlayerServiceAdapter());

                //    saleManagerAdd.Add(new Entities.Sale
                //    {
                //        SaleId = 1,
                //        SalePlayerId = playerId,
                //        SaleName = "Minecraft",
                //        SaleStartingDate = DateTime.Now,
                //        SaleEndingTime = DateTime.Now,
                //        SaleDiscountRate = 0
                //    }, new Entities.Player
                //    {
                //        PlayerId = playerId
                //    }, new Entities.Campaign
                //    {

                //    });
                //    Console.ReadLine();
                //    break;
                //Yukarıdaki satırları kampanya entegre ettikten sonra devre dışına aldım

                case "5":
                    BaseCampaignManager campaignManagerAdd = new CampaignManager();
                    campaignManagerAdd.Add(new Entities.Campaign
                    {
                        CampaignName = "Emekliye %50 indirimli Minecraft",
                        CampaignStartingDate = DateTime.Now,
                        CampaignEndingTime = DateTime.Now.AddMonths(3),
                        CampaignDiscountRate = 50,
                        CampaignValidGameType = "Strateji"
                    });
                    Console.ReadLine();
                    break;
                case "6":
                    BaseCampaignManager campaignManagerUpdate = new CampaignManager();
                    campaignManagerUpdate.Update(new Entities.Campaign
                    {
                        CampaignName = "Emekliye %80 indirimli Minecraft, üç ay daha uzatıldı",
                        CampaignStartingDate = DateTime.Now,
                        CampaignEndingTime = DateTime.Now.AddMonths(6),
                        CampaignDiscountRate = 80,
                        CampaignValidGameType = "Strateji"
                    });
                    Console.ReadLine();
                    break;
                case "7":
                    BaseCampaignManager campaignManagerDelete = new CampaignManager();
                    campaignManagerDelete.Delete(new Entities.Campaign
                    {
                        CampaignId = 1,
                        CampaignStartingDate = DateTime.Now,
                        CampaignEndingTime = DateTime.Now.AddMonths(6),
                        CampaignDiscountRate = 80,
                        CampaignValidGameType = "Strateji"
                    });
                    Console.ReadLine();
                    break;
                case "8":
                    int playerIdCampaign = 0;
                    Console.WriteLine("Oyun satışı yapılacak oyuncuyu giriniz : ");
                    playerIdCampaign = Convert.ToInt16(Console.ReadLine());

                    BaseSaleManager saleManagerWithCampaign = new SaleManager(new PlayerServiceAdapter());

                    saleManagerWithCampaign.Add(new Entities.Sale
                    {
                        SaleId = 2,
                        SalePlayerId = playerIdCampaign,
                        SaleName = "Minecraft",
                        SaleStartingDate = DateTime.Now,
                        SaleEndingTime = DateTime.Now,
                        SaleDiscountRate = 0
                    }, new Entities.Player
                    {
                        PlayerId = playerIdCampaign
                    });
                    Console.ReadLine();
                    break;
            }
        }
    }
}
