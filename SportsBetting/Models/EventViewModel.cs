using System;

namespace SportsBetting.Web.Models
{
    public class EventViewModel
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public double OddsForFirstTeam { get; set; }
        public double OddsForDraw { get; set; }
        public double OddsForSecondTeam { get; set; }
        public DateTime EventStartDate { get; set; }
    }
}
