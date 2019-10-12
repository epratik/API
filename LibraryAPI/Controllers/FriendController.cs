using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryAPI.Core.DTO;
using LibraryAPI.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class FriendController : ControllerBase
    {
        IFriendRepository _friendRepo;

        public FriendController(IFriendRepository friendRepo)
        {
            this._friendRepo = friendRepo;
        }


        // POST: api/Friend
        [HttpPost]
        [Route("api/friend/Create")]
        public ActionResult<string> Create(FriendDto dto)
        {
            LibraryAPI.Core.Domain.Freind friend = LibraryAPI.Core.Domain.Freind.AddFreind(dto.friendName,dto.userid,dto.email);
            _friendRepo.AddFriend(friend);

            return friend.GetLink();
        }

    }
}
