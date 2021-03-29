using SportsBetting.Data;
using SportsBetting.Data.Models;
using SportsBetting.Services.IServices;
using SportsBetting.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SportsBetting.Services.ServicesImplementation
{
    public class EventService : IEventService
    {
        private readonly EventsDbContext db;
        public EventService(EventsDbContext db)
        {
            this.db = db;
        }
        public void CreateEvent(Event model)
        {
            var sportEvent = new Event
            {
                EventStartDate = model.EventStartDate
            };

            db.Events.Add(sportEvent);

            db.SaveChanges();
        }

        public void DeleteEvent(int id)
        {
            var sportEvent = db.Events.Find(id);

            if (sportEvent == null)
            {
                return;
            }
            db.Remove(sportEvent);
            db.SaveChanges();
        }

        public void Edit(int id, string eventName, double oddsForFirstTeam, double oddsForDraw, double oddsForSecondTeam, DateTime eventStartDate)
        {
            var sportEvent = db.Events.Find(id);

            if (sportEvent == null)
            {
                return;
            }
            sportEvent.EventName = eventName;
            sportEvent.OddsForFirstTeam = oddsForFirstTeam;
            sportEvent.OddsForDraw = oddsForDraw;
            sportEvent.OddsForSecondTeam = oddsForSecondTeam;
            sportEvent.EventStartDate = eventStartDate;

            db.SaveChanges();
        }

        public EventEditModel EditById(int id)
        => db
            .Events
            .Where(e => e.EventId == id)
            .Select(a => new EventEditModel
            {

                EventName = a.EventName,
                OddsForFirstTeam = a.OddsForFirstTeam,
                OddsForDraw = a.OddsForDraw,
                OddsForSecondTeam = a.OddsForSecondTeam,
                EventStartDate = a.EventStartDate
            }).FirstOrDefault();

        public ICollection<Event> GetEvents()
        {
            var sportEvents = db.Events.Select(e => new Event
            {
                EventId = e.EventId,
                EventName = e.EventName,
                OddsForFirstTeam = e.OddsForFirstTeam,
                OddsForDraw = e.OddsForDraw,
                OddsForSecondTeam = e.OddsForSecondTeam,
                EventStartDate = e.EventStartDate
            }).ToList();

            return sportEvents;
        }
    }
}
