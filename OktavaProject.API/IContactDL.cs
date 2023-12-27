﻿using OktavaProject.DL.Models;

namespace OktavaProject.DL
{
    public interface IContactDL
    {
        Task<List<Contact>> GetContacts();
        Task<bool> AddContact(Contact contact);
        Task<bool> UpdateContact(Contact contact, int id);
        Task<bool> RemoveContact(int id);

    }
}