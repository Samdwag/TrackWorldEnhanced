namespace TrackMeet.Views
{
    partial class TrackMeetForm
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
            this.labelAthleteName = new System.Windows.Forms.Label();
            this.txtAthleteName = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.labelEvent = new System.Windows.Forms.Label();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonShowTrackEvents = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAthleteName
            // 
            this.labelAthleteName.AutoSize = true;
            this.labelAthleteName.Location = new System.Drawing.Point(24, 28);
            this.labelAthleteName.Name = "labelAthleteName";
            this.labelAthleteName.Size = new System.Drawing.Size(74, 13);
            this.labelAthleteName.Text = "Athlete Name";
            this.labelAthleteName.TabIndex = 0;
            // 
            // textBoxAthleteName
            // 
            this.txtAthleteName.Location = new System.Drawing.Point(123, 25);
            this.txtAthleteName.Name = "textBoxAthleteName";
            this.txtAthleteName.Size = new System.Drawing.Size(100, 20);
            this.txtAthleteName.TabIndex = 1;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(24, 67);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(30, 13);
            this.labelTime.Text = "Time";
            this.labelTime.TabIndex = 2;
            // 
            // textBoxTime
            // 
            this.txtTime.Location = new System.Drawing.Point(123, 64);
            this.txtTime.Name = "textBoxTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 3;
            // 
            // labelEvent
            // 
            this.labelEvent.AutoSize = true;
            this.labelEvent.Location = new System.Drawing.Point(24, 106);
            this.labelEvent.Name = "labelEvent";
            this.labelEvent.Size = new System.Drawing.Size(33, 13);
            this.labelEvent.Text = "Event";
            this.labelEvent.TabIndex = 4;
            // 
            // textBoxEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(123, 103);
            this.txtEvent.Name = "textBoxEvent";
            this.txtEvent.Size = new System.Drawing.Size(100, 20);
            this.txtEvent.TabIndex = 5;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(24, 145);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(42, 13);
            this.labelGender.Text = "Gender";
            this.labelGender.TabIndex = 6;
            // 
            // comboBoxGender
            // 
            this.cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxGender.Location = new System.Drawing.Point(123, 142);
            this.cbxGender.Name = "comboBoxGender";
            this.cbxGender.Size = new System.Drawing.Size(100, 21);
            this.cbxGender.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(27, 197);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonShowTrackEvents
            // 
            this.buttonShowTrackEvents.Location = new System.Drawing.Point(127, 197);
            this.buttonShowTrackEvents.Name = "buttonShowTrackEvents";
            this.buttonShowTrackEvents.Size = new System.Drawing.Size(143, 23);
            this.buttonShowTrackEvents.Text = "Show Track Events";
            this.buttonShowTrackEvents.UseVisualStyleBackColor = true;
            this.buttonShowTrackEvents.Click += new System.EventHandler(this.buttonShowTrackEvents_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(27, 239);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // TrackMeetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonShowTrackEvents);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.labelEvent);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.txtAthleteName);
            this.Controls.Add(this.labelAthleteName);
            this.Name = "TrackMeetForm";
            this.Text = "Track Meet";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelAthleteName;
        private System.Windows.Forms.TextBox txtAthleteName;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label labelEvent;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonShowTrackEvents;
        private System.Windows.Forms.Button buttonExit;
    }
}