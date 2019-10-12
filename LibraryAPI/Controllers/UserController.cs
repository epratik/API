using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LibraryAPI.Core.Domain;
using LibraryAPI.Core.Interfaces;
using LibraryAPI.Core.DTO;

namespace LibraryAPI.Controllers
{
    
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserRepository _userRepo;
        public UserController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpPost]
        [Route("api/user/create")]
        public ActionResult<string> Create(UserDto userdto)
        {
            LibraryAPI.Core.Domain.User user = LibraryAPI.Core.Domain.User.CreateUser(userdto.name, userdto.email);
            _userRepo.AddUser(user);
            return user.GetLink();
        }

        [HttpGet]
        [Route("api/user/abc")]
        public ActionResult<string> abc()
        {
            return "hello";
        }
    }
}