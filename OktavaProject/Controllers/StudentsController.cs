using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OktavaProject.BL;
using OktavaProject.DL;
using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;

namespace OktavaProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private IStudentBL studentBL;

        public StudentsController(IStudentBL studentBL)
        {
            this.studentBL = studentBL;
        }

        // GET: api/<StudentsController>
        [HttpGet]
        [Route("GetStudents")]
        public async Task<List<StudentDTO>> GetStudents()
        {
            var students = await studentBL.GetStudents();
            return students;
        }

        //GET api/<StudentsController>/5
        [HttpGet]
        [Route("GetStudentById/{studentId}")]
        public async Task<List<StudentDTO>> GetStudentById(int studentId)
        {
            var student = await studentBL.GetStudentById(studentId);
            return student;
        }

        //GET api/<StudentsController>/5
        [HttpGet("{userId}")]
        public async Task<List<StudentDTO>> GetStudentByUserId(int userId)
        {
            var student = await studentBL.GetStudentByUserId(userId);
            return student;
        }
        // POST api/<StudentsController>
        [HttpPost]
        [Route("AddStudent")]
        public async Task<ActionResult<bool>> AddStudent([FromBody] StudentDTO student)
        {
            try
            {
                bool isAddStudent = await studentBL.AddStudent(student);
                return Ok(isAddStudent);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Put(int id, [FromBody] StudentDTO student)
        {
            try
            {
                bool isUpdateStudent = await studentBL.UpdateStudent(student, id);
                return isUpdateStudent;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteStudent(int id)
        {
            try
            {
                bool isRemoveStudent = await studentBL.RemoveStudent(id);
                return isRemoveStudent;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}