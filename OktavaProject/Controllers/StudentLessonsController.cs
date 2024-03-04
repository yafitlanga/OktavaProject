using Microsoft.AspNetCore.Mvc;
using OktavaProject.BL;
using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OktavaProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentLessonsController : ControllerBase
    {
        private IStudentLessonBL studentLessonBL;

        public StudentLessonsController(IStudentLessonBL studentLessonBL)
        {
            this.studentLessonBL = studentLessonBL;
        }
        // GET: api/<StudentLessonsController>
        [HttpGet]
        public async Task <List<StudentLessonDTO>> GetStudentLessons()
        {
            return await studentLessonBL.GetStudentLessons();
        }
        // GET api/<StudentLessonsController>/5
        [HttpGet("{id}")]
        public async Task<StudentLessonDTO> Get(int id)
        {
            var studentLessonController = await studentLessonBL.GetStudentLessonById(id);
            return studentLessonController;
        }


        // POST api/<StudentLessonsController>
        [HttpPost]
        public async Task<ActionResult<bool>> AddStudentLesson([FromBody] StudentLessonDTO StudentLesson)
        {
            try
            {
                bool isAddStudent = await studentLessonBL.AddStudentLesson(StudentLesson);
                return isAddStudent;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        // PUT api/<StudentLessonsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Put(int id, [FromBody] StudentLessonDTO StudentLesson)
        {
            try
            {
                bool isUpdateStudent = await studentLessonBL.UpdateStudentLesson(StudentLesson, id);
                return isUpdateStudent;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        // DELETE api/<StudentLessonsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            try
            {
                bool isRemoveStudent = await studentLessonBL.RemoveStudentLesson(id);
                return isRemoveStudent;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
