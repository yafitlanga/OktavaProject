using AutoMapper;
using OktavaProject.DL.Models;
using OktavaProject.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OktavaProjectEntities.DTO;
using Microsoft.Extensions.Logging;

namespace OktavaProject.BL
{
    public class EventBL: IEventBL
    {
        private IEventDL eventDL;
        private IMapper mapper;
        public EventBL(IEventDL eventDL, IMapper _mapper)
        {
            this.eventDL = eventDL;
            this.mapper = _mapper;
        }
        public async Task<List<EventDTO>> GetEvents()
        {
            List<Event> event1 = await eventDL.GetEvents();
            List<EventDTO> event2 = mapper.Map<List<EventDTO>>(event1);
            return event2;
        }
        public async Task<EventDTO> GetEventById(int id)
        {
            Event event1 = await eventDL.GetEventById(id);
            EventDTO event2 = mapper.Map<EventDTO>(event1);
            return event2;
        }
        public async Task<int> AddEvent(EventDTO _event)
        {
            Event e = mapper.Map<Event>(_event);
            int eventId = await eventDL.AddEvent(e);
            return eventId;
        }
        public async Task<bool> UpdateEvent(EventDTO _event, int id)
        {
            Event e = mapper.Map<Event>(_event);
            bool isUpdate = await eventDL.UpdateEvent(e, id);
            return isUpdate;
        }
        public async Task<bool> RemoveEvent(int id)
        {
            bool isRemove = await eventDL.RemoveEvent(id);
            return isRemove;
        }
    }
}
