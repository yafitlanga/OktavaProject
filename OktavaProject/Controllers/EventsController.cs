using Microsoft.AspNetCore.Mvc;
using OktavaProject.BL;
using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OktavaProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        // GET: api/<EventController>
        
        private IEventBL eventBL;
        
        public EventsController(IEventBL eventBL)
        {
            this.eventBL = eventBL; 
        }
        [HttpGet]
        public async Task<List<EventDTO>> GetEvents()
        {
            var events = await eventBL.GetEvents();
            return events;
        }

        // GET api/<EventController>/5
        [HttpGet("{id}")]
        public async Task<EventDTO> Get(int id)
        {
            var events= await eventBL.GetEventById(id);
            return events;
        }


        // POST api/<EventController>
        [HttpPost]
        public async Task<ActionResult<bool>> AddEvent([FromBody] EventDTO _event)
        {
            try
            {
                bool isAddEvent = await eventBL.AddEvent(_event);
                return isAddEvent;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Put(int id, [FromBody] EventDTO _event)
        {
            try
            {
                bool isUpdateEvent = await eventBL.UpdateEvent(_event, id);
                return isUpdateEvent;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
        // DELETE api/<EventController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            try
            {
                bool isRemoveEvent = await eventBL.RemoveEvent(id);
                return isRemoveEvent;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
