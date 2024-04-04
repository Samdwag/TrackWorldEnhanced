// TrackEventGrid.cs

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackMeet.Models;

namespace TrackMeet.Views
{
    public partial class TrackEventGrid : Form
    {
        public TrackEventGrid(List<TrackEvent> events)
        {
            InitializeComponent();
            dataGridViewTrackEvents.DataSource = events;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
