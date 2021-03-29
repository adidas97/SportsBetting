using System;
using System.ComponentModel.DataAnnotations;

namespace SportsBetting.Data.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public string EventName { get; set; }
        public double OddsForFirstTeam { get; set; }
        public double OddsForDraw { get; set; }
        public double OddsForSecondTeam { get; set; }
        public DateTime EventStartDate { get; set; }
    }
}
