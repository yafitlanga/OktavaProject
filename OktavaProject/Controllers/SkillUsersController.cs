﻿using Microsoft.AspNetCore.Mvc;
using OktavaProject.BL;
using OktavaProject.DL;
using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OktavaProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillUsersController : ControllerBase
    {
        private ISkillUserBL skillUserBL;

        public SkillUsersController(ISkillUserBL skillUserBL)
        {
            this.skillUserBL = skillUserBL;
        }
        // GET: api/<SkillUsersController>
        [HttpGet]
        public async Task<List<SkillUserDTO>> Get()
        {
            var skillUsers = await skillUserBL.GetSkillUsers();
            return skillUsers;
        }

        // GET api/<SkillUsersController>/5
        [HttpGet("{id}")]
        public async Task<SkillUserDTO> GetSkillUser(int id)
        {
            var skillUser = await skillUserBL.GetSkillUserById(id);
            return skillUser;
        }

        [HttpPost]
        public async Task<ActionResult<bool>> AddSkillUser([FromBody] SkillUserDTO[] skillsUser)
        {
            try
            {
                bool isAddSkillUser = await skillUserBL.AddSkillUser(skillsUser);
                return isAddSkillUser;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT api/<SkillUsersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Put(int id, [FromBody] SkillUserDTO skillUser)
        {
            try
            {
                bool isUpdateSkillUser = await skillUserBL.UpdateSkillUser(skillUser, id);
                return isUpdateSkillUser;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("RemoveSkillUserByUserId/{id}")]
        public async Task<ActionResult<bool>> RemoveSkillUserByUserId(int id)
        {
            try
            {
                bool isRemoveSkillUser = await skillUserBL.RemoveSkillUserByUserId(id);
                return isRemoveSkillUser;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE api/<SkillUsersController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            try
            {
                bool isRemoveSkillUser = await skillUserBL.RemoveSkillUser(id);
                return isRemoveSkillUser;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
