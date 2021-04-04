using Gun_05_Odev_05.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun_05_Odev_05.Entities
{
    public class Player:IEntity
    {
        public int PlayerId { get; set; }
        public string PlayerFirstName { get; set; }
        public string PlayerLastName { get; set; }
        public long PlayerNationalityId { get; set; }
        public DateTime PlayerDateOfBirth { get; set; }
    }
}
