namespace TrackMeet.Views
{
    partial class TrackEventGrid
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewTrackEvents = new System.Windows.Forms.DataGridView();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrackEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTrackEvents
            // 
            this.dataGridViewTrackEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrackEvents.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTrackEvents.Name = "dataGridViewTrackEvents";
            this.dataGridViewTrackEvents.Size = new System.Drawing.Size(260, 186);
            this.dataGridViewTrackEvents.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(197, 220);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // TrackEventGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridViewTrackEvents);
            this.Name = "TrackEventGrid";
            this.Text = "Track Event Grid";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrackEvents)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewTrackEvents;
        private System.Windows.Forms.Button buttonClose;
    }
}
