using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controller
{
   public class UserController
    {
        private UserRepository UserList = UserRepository.GetInstance();
        public bool UserAdd(string name, string email, string password)
        {
            var result = false;
            User oUser = new User(name, email, password);
            
            if (UserList.GetUserByEmail(email, password) == null)
            {
                UserList.UserAdd(oUser);
                result = true;
            }
            return result;
        }
        public List<User> AllUser()
        {
            return UserList.UserAll();
        }
        public User GetUserByEmail(string email,string password)
        {
            return UserList.GetUserByEmail(email, password);
        }
    }
}
