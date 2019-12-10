namespace qlnt.UI
{
    partial class ClockPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xuiClock = new XanderUI.XUIClock();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // xuiClock
            // 
            this.xuiClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(100)))), ((int)(((byte)(34)))));
            this.xuiClock.CircleThickness = 6;
            this.xuiClock.DisplayFormat = XanderUI.XUIClock.HourFormat.TwentyFourHour;
            this.xuiClock.FilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(148)))), ((int)(((byte)(12)))));
            this.xuiClock.FilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock.FilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(160)))), ((int)(((byte)(106)))));
            this.xuiClock.Font = new System.Drawing.Font("Impact", 15F);
            this.xuiClock.HexagonColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(100)))), ((int)(((byte)(34)))));
            this.xuiClock.Location = new System.Drawing.Point(-2, 22);
            this.xuiClock.Name = "xuiClock";
            this.xuiClock.ShowAmPm = false;
            this.xuiClock.ShowHexagon = true;
            this.xuiClock.ShowMinutesCircle = true;
            this.xuiClock.ShowSecondsCircle = true;
            this.xuiClock.Size = new System.Drawing.Size(209, 226);
            this.xuiClock.TabIndex = 0;
            this.xuiClock.Text = "xuiClock1";
            this.xuiClock.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.xuiClock.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(212, 54);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 2;
            // 
            // ClockPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(100)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(450, 280);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.xuiClock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClockPanel";
            this.Text = "ClockPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIClock xuiClock;
        private System.Windows.Forms.MonthCalendar calendar;
    }
}