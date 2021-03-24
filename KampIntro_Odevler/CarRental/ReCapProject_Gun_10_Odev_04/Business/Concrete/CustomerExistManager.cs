using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerExistManager : ICustomerExistService
    {
        public bool CheckIfCustomerExist(Customer customer)
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            var result = customerManager.GetById(customer.Id);

            if (result.Success == true)
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
