﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OktavaProject.BL;
using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;


namespace OktavaProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private IContactBL contactBL;

        public ContactsController(IContactBL contactBL)
        {
            this.contactBL = contactBL;
        }

        // GET: api/<ContactsController>
        [HttpGet]
        [Route("Getcontacts")]
        public async Task<List<ContactDTO>> Getcontacts()
        {
            var contacts = await contactBL.GetContacts();
            return contacts;
        }

        // GET api/<ContactsController>/5
        [HttpGet("{id}")]
        public async Task<ContactDTO> Get(int id)
        {
            var contact = await contactBL.GetContactById(id);
            return contact;
        }

        // POST api/<ContactsController>
        [HttpPost]
        [Route("AddContact")]
        public async Task<ActionResult<int>> AddContact([FromBody] ContactDTO contact)
        {
            try
            {
                int contactId = await contactBL.AddContact(contact);
                return Ok(contactId);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }



        //[HttpPost]
        //public async Task<ActionResult<bool>> AddContact([FromBody] ContactDTO contact)
        //{
        //    try
        //    {
        //        bool isAddContact = await contactBL.AddContact(contact);
        //        return isAddContact;
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, ex.Message);
        //    }
        //}

        // PUT api/<ContactsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Put(int id, [FromBody] ContactDTO contact)
        {
            try
            {
                bool isUpdateContact = await contactBL.UpdateContact(contact, id);
                return isUpdateContact;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE api/<ContactsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            try
            {
                bool isRemoveContact = await contactBL.RemoveContact(id);
                return isRemoveContact;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}

