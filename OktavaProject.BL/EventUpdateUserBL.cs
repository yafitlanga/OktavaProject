using AutoMapper;
using OktavaProject.DL.Models;
using OktavaProject.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OktavaProjectEntities.DTO;
using OktavaProjectEntities;
using System.Runtime.Intrinsics.X86;

namespace OktavaProject.BL
{
    public class EventUpdateUserBL : IEventUpdateUserBL
    {
        private IEventUpdateUserDL eventUpdateUserDL;
        private IMapper mapper;

        public EventUpdateUserBL(IEventUpdateUserDL eventUpdateUserDL, IMapper _mapper)
        {
            this.eventUpdateUserDL = eventUpdateUserDL;
            this.mapper = _mapper;
        }
        public async Task<List<EventUpdateUserDTO>> GetEventUpdateUsers()
        {
            List<EventUpdateUser> eventUpdateUser1 = await eventUpdateUserDL.GetEventUpdateUsers();
            List<EventUpdateUserDTO> eventUpdateUser2 = mapper.Map<List<EventUpdateUserDTO>>(eventUpdateUser1);
            return eventUpdateUser2;
        }
        public async Task<EventUpdateUserDTO> GetEventUpdateUserById(int id)
        {
            EventUpdateUser eventUpdateUser1 = await eventUpdateUserDL.GetEventUpdateUserById(id);
            EventUpdateUserDTO eventUpdateUser2 = mapper.Map<EventUpdateUserDTO>(eventUpdateUser1);
            return eventUpdateUser2;
        }
        public async Task<bool> AddEventUpdateUser(EventUpdateUserDTO eventUpdateUser)
        {
            EventUpdateUser e = mapper.Map<EventUpdateUser>(eventUpdateUser);
            bool isAdd = await eventUpdateUserDL.AddEventUpdateUser(e);
            return isAdd;
        }
        public async Task<bool> UpdateEventUpdateUser(EventUpdateUserDTO eventUpdateUser, int id)
        {
            EventUpdateUser e = mapper.Map<EventUpdateUser>(eventUpdateUser);
            bool isUpdate = await eventUpdateUserDL.UpdateEventUpdateUser(e, id);
            return isUpdate;
        }
        public async Task<bool> RemoveEventUpdateUser(int id)
        {
            bool isRemove = await eventUpdateUserDL.RemoveEventUpdateUser(id);
            return isRemove;
        }
    }
}
