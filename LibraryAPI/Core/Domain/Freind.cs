using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Core.Domain
{
    public class Freind
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public Guid userid { get; set; }

        public static Freind AddFreind(string sName, string sUserid, string sEmail)
        {
            Freind friend = new Freind();
            friend.id = Guid.NewGuid();
            friend.userid  = Guid.Parse(sUserid);
            friend.email = sEmail;
            friend.name = sName;
            return friend;
        }

        public string GetLink()
        {
            return "http://LibraryAPI/api/friend/" + name + "?key=" + id.ToString();
        }
    }
}
