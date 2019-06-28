using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UsersService.Services;
using UsersService.ViewModels;

namespace UsersService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersDataService userService;
        public UsersController(IUsersDataService userService)
        {
            this.userService = userService;
        }

        // GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<UserModel>> Get()
        {
            return new ObjectResult(userService.GetAllUsers());
        }

        // GET api/user/5
        [HttpGet("{userId}")]
        public ActionResult<UserModel> Get(int userId)
        {
            return new ObjectResult(userService.GetUserById(userId));
        }

        // POST api/users
        [HttpPost]
        public ActionResult<UserModel> Post([FromBody] UserModel newUser)
        {
            return new ObjectResult(userService.CreateUser(newUser));
        }

        // PUT api/users/5
        [HttpPut("{userId}")]
        public ActionResult<UserModel> Put(int userId, [FromBody] UserModel dirtyUser)
        {
            var foundUser = userService.UpdateUser(userId, dirtyUser);
            if (foundUser == null)
            {
                return new NotFoundObjectResult(dirtyUser);
            }
            return foundUser;
        }

        // DELETE api/users/5
        [HttpDelete("{userId}")]
        public ActionResult Delete(int userId)
        {
            var isDeleted = userService.DeleteUser(userId);
            if (!isDeleted)
            {
                return new NotFoundObjectResult(userId);
            }
            return new OkResult();
        }
    }
}
