using System;
using System.Windows.Forms;
using TrackMeet.Controllers;
using TrackMeet.Views;

namespace TrackWorldEnhanced
{
    internal class Program
    {
        [STAThread] // This attribute is required for WinForms applications
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create an instance of TrackMeetController if needed
            TrackMeetController controller = new TrackMeetController();

            // Pass the controller to TrackMeetForm constructor
            TrackMeetForm trackMeetForm = new TrackMeetForm(controller);

            // Show the main form
            Application.Run(trackMeetForm);
        }
    }
}
