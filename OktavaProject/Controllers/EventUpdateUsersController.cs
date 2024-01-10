using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OktavaProject.BL;
using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;

namespace OktavaProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventUpdateUsersController : ControllerBase
    {
        private IEventUpdateUserBL eventUpdateUserBL;

        public EventUpdateUsersController(IEventUpdateUserBL eventUpdateUserBL)
        {
            this.eventUpdateUserBL = eventUpdateUserBL;
        }

        // GET: api/<EventUpdateUsersController>
        [HttpGet]
        public async Task<List<EventUpdateUserDTO>> GeteventUpdateUsers()
        {
            var eventUpdateUsers = await eventUpdateUserBL.GetEventUpdateUsers();
            return eventUpdateUsers;
        }

        // GET api/<EventUpdateUsersController>/5
        [HttpGet("{id}")]
        public async Task<EventUpdateUserDTO> Get(int id)
        {
            var eventUpdateUser = await eventUpdateUserBL.GetEventUpdateUserById(id);
            return eventUpdateUser;
        }

        // POST api/<EventUpdateUsersController>
        [HttpPost]
        public async Task<ActionResult<bool>> AddEventUpdateUser([FromBody] EventUpdateUserDTO eventUpdateUser)
        {
            try
            {
                bool isAddEventUpdateUser = await eventUpdateUserBL.AddEventUpdateUser(eventUpdateUser);
                return isAddEventUpdateUser;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT api/<EventUpdateUsersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Put(int id, [FromBody] EventUpdateUserDTO eventUpdateUser)
        {
            try
            {
                bool isUpdateEventUpdateUser = await eventUpdateUserBL.UpdateEventUpdateUser(eventUpdateUser, id);
                return isUpdateEventUpdateUser;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE api/<EventUpdateUsersController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            try
            {
                bool isRemoveEventUpdateUser = await eventUpdateUserBL.RemoveEventUpdateUser(id);
                return isRemoveEventUpdateUser;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
