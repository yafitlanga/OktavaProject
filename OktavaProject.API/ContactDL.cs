using Microsoft.EntityFrameworkCore;
using OktavaProject.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktavaProject.DL
{
    public class ContactDL : IContactDL
    {
        OktavaDBContext _OktavaContext = new OktavaDBContext();
        public async Task<List<Contact>> GetContacts()
        {
            try
            {
                var contacts = await _OktavaContext.Contacts.ToListAsync();
                return contacts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> AddContact(Contact contact)
        {
            try
            {
                await _OktavaContext.Contacts.AddAsync(contact);
                _OktavaContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdateContact(Contact contact, int id)
        {
            try
            {
                Contact contactToUpdate = await _OktavaContext.Contacts.FirstOrDefaultAsync(x => x.Id == id);
                if (contactToUpdate != null)
                {
                    contactToUpdate.Name = contact.Name;
                    contactToUpdate.Mail = contact.Mail;
                    contactToUpdate.Phone = contact.Phone;
                    contactToUpdate.Detailes = contact.Detailes;
                    contactToUpdate.Date = contact.Date;
                }
                else
                {
                    return false;
                }
                _OktavaContext.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> RemoveContact(int id)
        {
            try
            {
                Contact contactToRemove = await _OktavaContext.Contacts.FirstOrDefaultAsync(x => x.Id == id);
                if (contactToRemove != null)
                {
                    _OktavaContext.Contacts.Remove(contactToRemove);
                    _OktavaContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

