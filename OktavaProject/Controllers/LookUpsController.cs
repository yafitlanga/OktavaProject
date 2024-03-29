﻿using Microsoft.AspNetCore.Mvc;
using OktavaProject.BL;
using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;

//For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OktavaProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookUpsController : ControllerBase
    {
        //GET: api/<ValuesController>
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
        [Route("GetSkill")]
        public async Task<SkillDTO> GetSkillById(int id)
        {
            var skill = await lookUpBL.GetSkillById(id);
            return skill;
        }

        [HttpGet]
        [Route("GetSkillsByUserId")]
        public async Task<List<SkillDTO>> GetSkillsByUserId(int userId)
        {
            var skills = await lookUpBL.GetSkillsByUserId(userId);
            return skills;
        }

        [HttpGet]
        [Route("GetDays")]
        public async Task<List<DayDTO>> GetDays()
        {
            var Days = await lookUpBL.GetDay();
            return Days;
        }

        [HttpGet]
        [Route("GetDay")]
        public async Task<DayDTO> GetDayById(int id)
        {
            var Day = await lookUpBL.GetDayById(id);
            return Day;
        }

        [HttpGet]
        [Route("GetHours")]

        public async Task<List<HourDTO>> GetHours()
        {
            var Hours = await lookUpBL.GetHour();
            return Hours;
        }
        [HttpGet]
        [Route("GetHour")]
        public async Task<HourDTO> GetHourById(int id)
        {
            var Hour = await lookUpBL.GetHourById(id);
            return Hour;
        }
        [HttpGet]
        [Route("GetAcademicDegrees")]
        public async Task<List<AcademicDegreeDTO>> GetAcademicDegrees()
        {
            var AcademicDegrees = await lookUpBL.GetAcademicDegrees();
            return AcademicDegrees;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<AcademicDegreeDTO> GetAcademicDegreeById(int id)
        {
            var AcademicDegree = await lookUpBL.GetAcademicDegreeById(id);
            return AcademicDegree;
        }


    }
}
