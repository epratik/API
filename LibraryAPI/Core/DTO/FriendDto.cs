using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Core.DTO
{
    public class FriendDto
    {
        public Guid id { get; set; }
        public string userid { get; set; }
        public string friendName { get; set; }
        public string email { get; set; }
    }
}
