using LibraryAPI.Core.Domain;
using LibraryAPI.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Infrastructure
{
    public class FriendRepository : IFriendRepository
    {
        private LibraryContext context;
        public FriendRepository(LibraryContext libraryContext)
        {
            context = libraryContext;
        }

       
        public void AddFriend(Freind freind)
        {
            context.Freinds.Add(freind);
            context.SaveChanges();
        }
    }
}
