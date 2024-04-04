using System;
using System.Windows.Forms;
using TrackMeet.Controllers;
using TrackMeet.Models;

namespace TrackMeet.Views
{
    public partial class TrackMeetForm : Form
    {
        private TrackMeetController controller;

        public TrackMeetForm(TrackMeetController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void ExitApplication()
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void ClearEntries()
        {
            txtAthleteName.Text = string.Empty;
            txtTime.Text = string.Empty;
            txtEvent.Text = string.Empty;
            cbxGender.SelectedIndex = -1;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = txtAthleteName.Text;
            string time = txtTime.Text;
            string trackEvent = txtEvent.Text;
            string gender = cbxGender.SelectedItem?.ToString();

            if (!ValidateEntries(name, time, trackEvent, gender))
            {
                MessageBox.Show("Please fill in all details.");
                return;
            }

            if (controller.AddTrackEvent(name, time, trackEvent, gender))
            {
                MessageBox.Show("Track event added successfully.");
                ClearEntries();
            }
            else
            {
                MessageBox.Show("Failed to add track event.");
            }
        }

        private bool ValidateEntries(string name, string time, string trackEvent, string gender)
        {
            return !string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(time) &&
                   !string.IsNullOrWhiteSpace(trackEvent) && !string.IsNullOrWhiteSpace(gender);
        }

        private void buttonShowTrackEvents_Click(object sender, EventArgs e)
        {
            controller.ShowTrackEventGrid();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}