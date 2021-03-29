using Microsoft.AspNetCore.Mvc;
using System;
using SportsBetting.Services.IServices;
using SportsBetting.Data.Models;
using SportsBetting.Web.Models;

namespace SportsBetting.Web.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventService service;
        public EventController(IEventService service)
        {
            this.service = service;
        }
        public IActionResult PreviewMode()
        {
            var sportEvents = service.GetEvents();

            return View(sportEvents);
        }
        public IActionResult EditMode()
        {
            var sportEvents = service.GetEvents();

            return View(sportEvents);
        }
        [HttpPost]
        public IActionResult EditById(int id, EventViewModel model)
        {
            service.Edit(id, model.EventName, model.OddsForFirstTeam, model.OddsForDraw, model.OddsForSecondTeam,
                model.EventStartDate);
            return RedirectToAction("EditMode");
        }

        public IActionResult EditById(int id)
        {
            var sportEvent = service.EditById(id);
            if (sportEvent == null)
            {
                return NotFound();
            }
            return View(new EventViewModel
            {
                EventName = sportEvent.EventName,
                OddsForFirstTeam = sportEvent.OddsForFirstTeam,
                OddsForDraw = sportEvent.OddsForDraw,
                OddsForSecondTeam = sportEvent.OddsForSecondTeam,
                EventStartDate = sportEvent.EventStartDate
            });
        }

        public IActionResult Destroy(int id) => View(id);

        public IActionResult DeletingEvent(int id)
        {
            service.DeleteEvent(id);
            return RedirectToAction("EditMode");
        }

        [HttpPost]
        public IActionResult CreateEvent(EventViewModel model)
        {
            var sportEvent = new Event
            {
                EventId = model.Id,
                EventStartDate = DateTime.Today.AddHours(23).AddMinutes(59)
            };

            service.CreateEvent(sportEvent);

            return RedirectToAction("EditMode");
        }
    }
}
