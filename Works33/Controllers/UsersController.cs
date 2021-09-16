using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works33.BusinessAccess;
using Works33.Models;

namespace Works33.Controllers
    
{ 
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController:ControllerBase
    {
        private readonly IUserService userService;
        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUsers()
        {

            return await userService.GetUsersAsync();

        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<User>> GetUser(long id)
        {
            var user = await userService.GetUserByIdAsync(id);

            if (user == null) { return NotFound(); }
            return user;
        }


        [HttpPost]
        public async Task<ActionResult<User>> CreateUser(User user)
        {

           User u = await userService.AddUserAsync(user);


            return CreatedAtAction(nameof(GetUser), new { id = u.Id }, u);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateUser(long id, User user)
        {
            if (id != user.Id) { return BadRequest(); }

            if (!await userService.isUserExistAsync(id)) return NotFound();

            try
            {
                User u = await userService.UpdateUserAsync(user);
            }
            catch (Exception)

            {
                throw;
            }
            return NoContent();
        }



        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(long id)
        {

            if (!await userService.isUserExistAsync(id)) return NotFound();
            bool isDeleted = await userService.DeleteUserAsync(id);
            if (!isDeleted) { return BadRequest(); }
            return NoContent();

        }

    }
}
