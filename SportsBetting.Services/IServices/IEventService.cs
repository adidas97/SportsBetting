using System;
using System.Collections.Generic;
using SportsBetting.Data.Models;
using SportsBetting.Services.Models;

namespace SportsBetting.Services.IServices
{
    public interface IEventService
    {
        ICollection<Event> GetEvents();
        void CreateEvent(Event model);
        void DeleteEvent(int id);
        EventEditModel EditById(int id);
        void Edit(int id, string eventName, double oddsForFirstTeam, 
            double oddsForDraw, double oddsForSecondTeam, DateTime eventStartDate);
    }
}
