using Gun_05_Odev_05.Abstract;
using Gun_05_Odev_05.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun_05_Odev_05.Concrete
{
    public class PlayerManager:BasePlayerManager
    {
        private IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService) 
        {
            _playerCheckService = playerCheckService;
        }
        public override void Add(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                base.Add(player);
            }
            else
            {
                Console.WriteLine ("Kayıt olmak isteyen oyuncu geçerli kimlik bilgilerine sahip değil");
                Console.ReadLine();
            }
        }
        public override void Update(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                base.Update(player);
            }
            else
            {
                Console.WriteLine ("Güncellenmek istenen oyuncu geçerli kimlik bilgilerine sahip değil");
                Console.ReadLine();
            }
        }
        public override void Delete(Player player)
        {
                base.Delete(player);
                Console.WriteLine ("Oyuncu kaydı silindi");
                Console.ReadLine();
        }
    }
}
