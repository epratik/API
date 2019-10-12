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

        // GET: api/Friend
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Friend/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Friend
        [HttpPost]
        public ActionResult<string> PostFriend(FriendDto friendDto)
        {
            LibraryAPI.Core.Domain.Freind friend = LibraryAPI.Core.Domain.Freind.AddFreind(friendDto.id, friendDto.friendid);
            _friendRepo.AddFriend(friend);

            return friend.GetLink();
        }

        // PUT: api/Friend/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
