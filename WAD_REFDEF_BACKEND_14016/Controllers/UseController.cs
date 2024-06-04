using Microsoft.AspNetCore.Mvc;
using WAD_REFDEF_BACKEND_14016.Data;
using WAD_REFDEF_BACKEND_14016.Models;
using WAD_REFDEF_BACKEND_14016.Repository;

namespace WAD_REFDEF_BACKEND_14016.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UseController : ControllerBase
    {
        private readonly KeyUseDbContext _context;
        private readonly IUserRespositiory _userRepository;

        public UseController(IUserRespositiory context)
        {
            _userRepository = context;
        }

        // GET: api/Users
        [HttpGet("GetAll")]
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _userRepository.GetAllUser();
        }

        // GET: api/Users/5
        [HttpGet("GetById")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _userRepository.GetSingleUser(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // POST: api/Users
        [HttpPost("Add")]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            _userRepository.CreateUser(user);

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // PUT: api/Users/5
        [HttpPut("Update")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            await _userRepository.UpdateUser(user,id);
            return NoContent();
        }

        // DELETE: api/Users/5
        [HttpDelete("Delete")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            await _userRepository.DeleteUser(id);
            return NoContent();
        }

    }
}
