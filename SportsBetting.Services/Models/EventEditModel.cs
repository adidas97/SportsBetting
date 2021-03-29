using System;
using System.Collections.Generic;
using System.Text;

namespace SportsBetting.Services.Models
{
   public class EventEditModel
    {
        public string EventName { get; set; }
        public double OddsForFirstTeam { get; set; }
        public double OddsForDraw { get; set; }
        public double OddsForSecondTeam { get; set; }
        public DateTime EventStartDate { get; set; }
    }
}
