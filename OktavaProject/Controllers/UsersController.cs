using Microsoft.AspNetCore.Mvc;
using OktavaProject.BL;
using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OktavaProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserBL userBL;
        public UsersController(IUserBL userBL)
        {
            this.userBL = userBL;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public async Task<List<UserDTO>> GetUsers()
        {
            var users =await userBL.GetUsers(); 
            return users;
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public async Task<UserDTO> GetUserById(string userId)
        {
            var user = await userBL.GetUserById(userId);
            return user;
        }

        [HttpGet("Login")]
        public async Task<ActionResult<UserDTO>> Login(string userId, string password)
        {
            var userDTO = await userBL.Login(userId, password);
            if (userDTO == null)
            {
                return NotFound();
            }
            return Ok(userDTO);
        }

        // POST api/<UsersController>
        [HttpPost]
        [Route("AddUser")]
        public async Task<ActionResult<bool>> AddUser([FromBody] UserDTO user)
        {
            try
            {
                bool isAddUser = await userBL.AddUser(user);
                return isAddUser;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Put(int id, [FromBody] UserDTO user)
        {
            try
            {
                bool isUpdateUser = await userBL.UpdateUser(user, id);
                return isUpdateUser;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteUser(int id)
        {
            try
            {
                bool isRemoveUser = await userBL.RemoveUser(id);
                return isRemoveUser;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
