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
    public class UserExistManager : IUserExistService
    {
        public bool CheckIfUserExist(User user)
        {
            UserManager userManager = new UserManager(new EfUserDal());

            var result = userManager.GetById(user.Id);

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
