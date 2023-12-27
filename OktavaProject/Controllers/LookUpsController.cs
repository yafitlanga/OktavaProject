using Microsoft.AspNetCore.Mvc;
using OktavaProject.BL;
using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OktavaProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookUpsController : ControllerBase
    {
        // GET: api/<ValuesController>
        private ILookUpBL lookUpBL;
        public LookUpsController(ILookUpBL lookUpBL)
        {
            this.lookUpBL = lookUpBL;
        }

        [HttpGet]
        [Route("GetSkills")]
        public async Task<List<SkillDTO>> GetSkills()
        {
            var Skills = await lookUpBL.GetSkills();
            return Skills;
        }
        [HttpGet]
        [Route("GetDays")]
        public async Task<List<DayDTO>> GetDays()
        {
            var Days = await lookUpBL.GetDay();
            return Days;
        }

        [HttpGet]
        [Route("GetHours")]
        public async Task<List<HourDTO>> GetHours()
        {
            var Hours = await lookUpBL.GetHour();
            return Hours;
        }
        [HttpGet]
        [Route("GetAcademicDegrees")]
        public async Task<List<AcademicDegreeDTO>> GetAcademicDegrees()
        {
            var AcademicDegrees = await lookUpBL.GetAcademicDegrees();
            return AcademicDegrees;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

    }
}
