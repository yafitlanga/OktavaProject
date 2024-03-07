using Microsoft.AspNetCore.Mvc;
using OktavaProject.BL;
using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OktavaProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonsController : ControllerBase
    {
        private ILessonBL lessonBL;

        public LessonsController(ILessonBL lessonBL)
        {
            this.lessonBL = lessonBL;
        }
        // GET: api/<LessonsController>
        [HttpGet]
        public async Task<List<Lesson>> GetLessons()
        {
            var lessons = await lessonBL.GetLessons();
            return lessons;          
        }
        // GET api/<LessonsController>/5
        [HttpGet("{id}")]
        public async Task<LessonDTO> GetLessonById(int id)
        {
            var lesson = await lessonBL.GetLessonById(id);
            return lesson;
        }

        [HttpPost]
        [Route("AddUser")]
        public async Task<ActionResult<bool>> AddLesson([FromBody] LessonDTO lesson)
        {
            try
            {
                bool isAddLesson = await lessonBL.AddLessons(lesson);
                return Ok(isAddLesson);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Put(int id, [FromBody] LessonDTO lesson)
        {
            try
            {
                bool isUpdateLesson = await lessonBL.UpdateLesson(lesson, id);
                return isUpdateLesson;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            try
            {
                bool isRemoveLesson = await lessonBL.RemoveLesson(id);
                return isRemoveLesson;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
