using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsersService.ViewModels;

namespace UsersService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<UserModel>> Get()
        {
            var users = new List<UserModel> {
                new UserModel
                {
                    Id = 1,
                    FirstName = "User1",
                    LastName = "Mocked",
                    Email = "user1@something.com"
                },
                new UserModel
                {
                    Id = 2,
                    FirstName = "User2",
                    LastName = "Mocked",
                    Email = "user2@something.com"
                },
                new UserModel
                {
                    Id = 3,
                    FirstName = "User3",
                    LastName = "Mocked",
                    Email = "user3@something.com"
                },
            };

            return users;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
