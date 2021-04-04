using Gun_05_Odev_05.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun_05_Odev_05.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {
        public virtual void Add(Player player)
        {
            Console.WriteLine("Oyuncu veri tabanına eklendi : " + player.PlayerFirstName + " " + player.PlayerLastName);
        }
        public virtual void Update(Player player)
        {
            Console.WriteLine("Oyuncu bilgileri güncellendi : " + player.PlayerFirstName + " " + player.PlayerLastName);
        }
        public virtual void Delete(Player player)
        {
            Console.WriteLine("Oyuncu silindi : " + player.PlayerFirstName + " " + player.PlayerLastName);
        }

    }
}
