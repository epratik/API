using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Core.Domain
{
    public class Freind
    {
        public Guid id { get; set; }
        public Guid friendid { get; set; }

        public static Freind AddFreind(Guid id, Guid userId)
        {
            Freind friend = new Freind();
            friend.id = Guid.NewGuid();
            friend.friendid = userId;
            return friend;
        }

        public string GetLink()
        {
            return "http://LibraryAPI/api/User/" + name + "?key=" + id.ToString();
        }
    }
}
