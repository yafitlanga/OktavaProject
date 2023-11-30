using OktavaProject.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProject.DL
{
    public class UserDL : IUserDL
    {
        OktavaDBContext _OktavaContext = new OktavaDBContext();
        public List<User> GetUsers()
        {
            return _OktavaContext.Users.ToList();
        }

    }
}
