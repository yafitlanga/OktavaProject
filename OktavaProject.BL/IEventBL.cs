﻿using OktavaProject.DL.Models;
using OktavaProjectEntities.DTO;

namespace OktavaProject.BL
{
    public interface IEventBL
    {
        Task<List<EventDTO>> GetEvents();
        Task<List<EventDTO>> GetEventsOnlyActive();
        Task<int> AddEvent(EventDTO _event);
        Task<bool> UpdateEvent(EventDTO _event, int id);
        Task<bool> RemoveEvent(int id);
        Task<EventDTO> GetEventById(int id);

    }
}