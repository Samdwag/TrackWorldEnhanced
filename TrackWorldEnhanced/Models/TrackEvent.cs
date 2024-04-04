using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackMeet.Models
{
    public class TrackEvent
    {
        public string AthleteName { get; set; }
        public string Time { get; set; }
        public string Event { get; set; }
        public string Gender { get; set; }

        public TrackEvent(string athleteName, string time, string trackEvent, string gender)
        {
            AthleteName = athleteName;
            Time = time;
            Event = trackEvent;
            Gender = gender;
        }
    }
}
