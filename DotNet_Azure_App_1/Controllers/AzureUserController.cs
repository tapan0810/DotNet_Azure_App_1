using DotNet_Azure_App_1.Models;
using DotNet_Azure_App_1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_Azure_App_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AzureUserController(IAzureUserService _service) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AzureUser>>> GetAllUsers()
        {
            var users = await _service.GetAllUsersAsync();
            if (users is null)
            {
                return NotFound("No users found.");
            }
            return Ok(users);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<AzureUser>> GetUserById(int id)
        {
            var user = await _service.GetUserByIdAsync(id);
            if (user is null)
            {
                return NotFound($"User with ID {id} not found.");
            }
            return Ok(user);
        }
        [HttpPost]
        public async Task<ActionResult<AzureUser>> CreateUser(AzureUser user)
        {
            if (user is null)
            {
                return BadRequest("User data is null.");
            }
            var createdUser = await _service.CreateUserAsync(user);
            return CreatedAtAction(nameof(GetUserById), new { id = createdUser.Id }, createdUser);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<AzureUser>> UpdateUser(int id, AzureUser user)
        {
            if (user is null)
            {
                return BadRequest("User data is null.");
            }
            var updatedUser = await _service.UpdateUserAsync(user, id);
            if (updatedUser is null)
            {
                return NotFound($"User with ID {id} not found.");
            }
            return Ok(updatedUser);
        }

        [HttpPut]
        public async Task<ActionResult> DeleteUser(int id)
        {
            var result = await _service.DeleteUserAsync(id);
            if (!result)
            {
                return NotFound($"User with ID {id} not found.");
            }
            return NoContent();
        }

    }
}
