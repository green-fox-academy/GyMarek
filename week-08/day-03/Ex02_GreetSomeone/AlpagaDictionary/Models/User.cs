using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlpagaDictionary.Models
{
    public class User
    {       
        public Dictionary<string, string> Users;
        
        public User(Dictionary<string, string> users)
        {
            Users = users;
            Users.Add("adriennzakar", "12345");
            Users.Add("AlbertBach", "12345");
            Users.Add("bkorbuly", "12345");
            Users.Add("bpo106", "12345");
            Users.Add("bramble100", "12345");
            Users.Add("CarrotTheHero", "12345");
            Users.Add("csibivili", "12345");
            Users.Add("CsKriszta93", "12345");
            Users.Add("evelinhlacsok", "12345");
            Users.Add("floraballabas", "12345");
            Users.Add("garamreka", "12345");
            Users.Add("gbotond", "12345");
            Users.Add("GyMarek", "12345");
            Users.Add("HerrNorbert", "12345");
            Users.Add("kondfox", "12345");
            Users.Add("kovacsnorb", "12345");
            Users.Add("leventekobor94", "12345");
            Users.Add("moodytea", "12345");
            Users.Add("Suviii", "12345");
            Users.Add("totger", "12345");
            Users.Add("trojanosall", "12345");
            Users.Add("truupi", "12345");
            Users.Add("vargacsilla", "12345");
            Users.Add("wangliqin123", "12345");
        }
    }
}
