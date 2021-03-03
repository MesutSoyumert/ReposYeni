using Gun_05_Odev_05.Abstract;
using Gun_05_Odev_05.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun_05_Odev_05.Concrete
{
    public class PlayerExistManager : IPlayerExistService
    {
        public bool CheckIfPlayerExist(Player player)
        {
            if (player.PlayerId == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
