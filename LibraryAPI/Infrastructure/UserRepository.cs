using LibraryAPI.Core.Domain;
using LibraryAPI.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        private LibraryContext context;
        public UserRepository(LibraryContext libraryContext)
        {
            context = libraryContext;
        }

        public void AddUser( User user)
        {
            context.Users.Add(user);
        }
    }
}
