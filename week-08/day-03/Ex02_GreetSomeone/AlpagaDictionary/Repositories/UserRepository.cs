using AlpagaDictionary.Entities;
using AlpagaDictionary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlpagaDictionary.Repositories
{
    public class UserRepository
    {
        private Context UserContext;

        public List<User> GetList()
        {
            return UserContext.UserData.ToList();
        }

        public UserRepository(Context userContext)
        {
            UserContext = userContext;
        }

        public bool CheckUserExist(string name, string password)
        {
            var user = UserContext.UserData.FirstOrDefault(u => u.LoginName.Equals(name));

            if (user == null || password == null)
            {
                return false;
            }
            return (password.Equals(user.Password));           
        }

        public int GetUserId(string name)
        {
            var id = (from userId in UserContext.UserData
                     where userId.LoginName == name
                     select userId).FirstOrDefault();

            return Int32.Parse(id.UserId.ToString());            
        }
    }
}
