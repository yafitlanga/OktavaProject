using AutoMapper;
using OktavaProject.DL.Models;
using OktavaProject.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OktavaProjectEntities.DTO;
using System.Diagnostics.Contracts;

namespace OktavaProject.BL
{
    public class ContactBL : IContactBL
    {
        private IContactDL contactDL;
        private IMapper mapper;
        public ContactBL(IContactDL contactDL, IMapper _mapper)
        {
            this.contactDL = contactDL;
            this.mapper = _mapper;
        }
        public async Task<List<ContactDTO>> GetContacts()
        {
            List<Contact> contact1 = await contactDL.GetContacts();
            List<ContactDTO> contact2 = mapper.Map<List<ContactDTO>>(contact1);
            return contact2;
        }
        public async Task<bool> AddContact(ContactDTO Contact)
        {
            Contact u = mapper.Map<Contact>(Contact);
            bool isAdd = await contactDL.AddContact(u);
            return isAdd;
        }
        public async Task<bool> UpdateContact(ContactDTO contact, int id)
        {
            Contact u = mapper.Map<Contact>(contact);
            bool isUpdate = await contactDL.UpdateContact(u, id);
            return isUpdate;
        }
        public async Task<bool> RemoveContact(int id)
        {
            bool isRemove = await contactDL.RemoveContact(id);
            return isRemove;
        }
    }
}
