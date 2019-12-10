namespace qlnt.UI
{
    partial class DashboardPanel
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
            this.pnlWeather = new System.Windows.Forms.Panel();
            this.pnlClock = new System.Windows.Forms.Panel();
            this.pnlStatistics = new System.Windows.Forms.Panel();
            this.pnlToDoList = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlWeather
            // 
            this.pnlWeather.BackColor = System.Drawing.Color.Gray;
            this.pnlWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlWeather.Location = new System.Drawing.Point(73, 33);
            this.pnlWeather.Name = "pnlWeather";
            this.pnlWeather.Size = new System.Drawing.Size(450, 280);
            this.pnlWeather.TabIndex = 6;
            // 
            // pnlClock
            // 
            this.pnlClock.BackColor = System.Drawing.Color.Gray;
            this.pnlClock.Location = new System.Drawing.Point(577, 33);
            this.pnlClock.Name = "pnlClock";
            this.pnlClock.Size = new System.Drawing.Size(450, 280);
            this.pnlClock.TabIndex = 9;
            // 
            // pnlStatistics
            // 
            this.pnlStatistics.BackColor = System.Drawing.Color.Gray;
            this.pnlStatistics.Location = new System.Drawing.Point(73, 349);
            this.pnlStatistics.Name = "pnlStatistics";
            this.pnlStatistics.Size = new System.Drawing.Size(450, 280);
            this.pnlStatistics.TabIndex = 8;
            // 
            // pnlToDoList
            // 
            this.pnlToDoList.BackColor = System.Drawing.Color.Gray;
            this.pnlToDoList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlToDoList.Location = new System.Drawing.Point(577, 349);
            this.pnlToDoList.Name = "pnlToDoList";
            this.pnlToDoList.Size = new System.Drawing.Size(450, 280);
            this.pnlToDoList.TabIndex = 7;
            // 
            // DashboardPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Controls.Add(this.pnlWeather);
            this.Controls.Add(this.pnlClock);
            this.Controls.Add(this.pnlStatistics);
            this.Controls.Add(this.pnlToDoList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardPanel";
            this.Text = "DashboardPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWeather;
        private System.Windows.Forms.Panel pnlClock;
        private System.Windows.Forms.Panel pnlStatistics;
        private System.Windows.Forms.Panel pnlToDoList;
    }
}