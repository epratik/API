using LibraryAPI.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace LibraryAPI.Core.Interfaces
{
    public interface IFriendRepository
    {
        void AddFriend(Freind freind);
    }
}
