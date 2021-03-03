using Gun_05_Odev_05.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun_05_Odev_05.Entities
{
    public class Game : IEntity
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string GameType { get; set; }
        public decimal GamePrice { get; set; }
        public int  GameUnitsInStock { get; set; }

    }
}
