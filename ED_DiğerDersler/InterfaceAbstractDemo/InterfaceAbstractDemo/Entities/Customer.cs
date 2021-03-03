using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Entities
{
    public class Customer:IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalityId { get; set; }
        public int DateOfBirthYear { get; set; }
        public int Id { get; set; }
    }
}
