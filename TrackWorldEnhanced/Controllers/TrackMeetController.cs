using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackMeet.Models;
using TrackMeet.Views;

namespace TrackMeet.Controllers
{
    public class TrackMeetController
    {
        private List<TrackEvent> trackEvents;

        public TrackMeetController()
        {
            trackEvents = new List<TrackEvent>();
        }

        public bool AddTrackEvent(string athleteName, string time, string trackEvent, string gender)
        {
            // Here, you should implement your logic to add track events
            TrackEvent newEvent = new TrackEvent(athleteName, time, trackEvent, gender);
            trackEvents.Add(newEvent);
            return true; // Assuming the addition always succeeds for simplicity
        }

        public void ShowTrackEventGrid()
        {
            TrackEventGrid eventGrid = new TrackEventGrid(trackEvents);
            eventGrid.ShowDialog();
        }
    }
}
