using AlpagaDictionary.Models;
using AlpagaDictionary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlpagaDictionary.Services
{
    public class UserService
    {
        private UserRepository UserRepository;

        public UserService(UserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        public bool AuthenticateUser(string name, string password)
        {
            return UserRepository.CheckUserExist(name,password);
        }

        public int GetUserId(string name)
        {
            return UserRepository.GetUserId(name);
        }
    }
}