using Microsoft.AspNetCore.Mvc;
using OktavaProject.BL;
using OktavaProject.DL;
using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OktavaProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcademicDegreeUsersController : ControllerBase
    {
        private IAcademicDegreeUserBL academicDegreeUserBL;
        public AcademicDegreeUsersController(IAcademicDegreeUserBL academicDegreeUserBL)
        {
            this.academicDegreeUserBL = academicDegreeUserBL;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<List<AcademicDegreeUserDTO>> GetAcademicDegreeUsers()
        {
            var academicDegreeUsers = await academicDegreeUserBL.GetAcademicDegreeUsers();
            return academicDegreeUsers;
        }

        [HttpPost]
        public async Task<ActionResult<bool>> AddAcademicDegreeUser([FromBody] AcademicDegreeUserDTO AcademicDegreeUser)
        {
            try
            {
                bool isAddAcademicDegreeUser = await academicDegreeUserBL.AddAcademicDegreeUser(AcademicDegreeUser);
                return isAddAcademicDegreeUser;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT api/<AcademicDegreeUsersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Put(int id, [FromBody] AcademicDegreeUserDTO AcademicDegreeUser)
        {
            try
            {
                bool isUpdateAcademicDegreeUser = await academicDegreeUserBL.UpdateAcademicDegreeUser(AcademicDegreeUser, id);
                return isUpdateAcademicDegreeUser;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("RemoveAcademicDegreeUserByUserId/{id}")]
        public async Task<ActionResult<bool>> RemoveAcademicDegreeUserByUserId(int id)
        {
            try
            {
                bool isRemoveAcademicDegreeUser = await academicDegreeUserBL.RemoveAcademicDegreeUserByUserId(id);
                return isRemoveAcademicDegreeUser;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE api/<AcademicDegreeUsersController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            try
            {
                bool isRemoveisUpdateAcademicDegreeUser = await academicDegreeUserBL.RemoveAcademicDegreeUser(id);
                return isRemoveisUpdateAcademicDegreeUser;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
