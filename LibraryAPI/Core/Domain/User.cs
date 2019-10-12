using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Core.Domain
{
    public class User
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string email { get; set; }

        public static User CreateUser(string sName, string sEmail)
        {
            User user = new User();
            user.id = Guid.NewGuid();
            user.name = sName;
            user.email = sEmail;

            return user;
        }

        public string GetLink()
        {
            return "http://LibraryAPI/api/User/" + name + "?key=" + id.ToString();
        }
    }
}
