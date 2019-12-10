namespace qlnt.UI
{
    partial class StatisticsPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsPanel));
            this.xuiLineGraph = new XanderUI.XUILineGraph();
            this.SuspendLayout();
            // 
            // xuiLineGraph
            // 
            this.xuiLineGraph.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiLineGraph.BelowLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.xuiLineGraph.BorderColor = System.Drawing.Color.White;
            this.xuiLineGraph.ForeColor = System.Drawing.SystemColors.Control;
            this.xuiLineGraph.GraphStyle = XanderUI.XUILineGraph.Style.Material;
            this.xuiLineGraph.GraphTitle = "XUI LineGraph";
            this.xuiLineGraph.GraphTitleColor = System.Drawing.Color.Gray;
            this.xuiLineGraph.Items = ((System.Collections.Generic.List<int>)(resources.GetObject("xuiLineGraph.Items")));
            this.xuiLineGraph.LineColor = System.Drawing.Color.White;
            this.xuiLineGraph.Location = new System.Drawing.Point(0, 0);
            this.xuiLineGraph.Name = "xuiLineGraph";
            this.xuiLineGraph.PointSize = 7;
            this.xuiLineGraph.ShowBorder = false;
            this.xuiLineGraph.ShowPoints = true;
            this.xuiLineGraph.ShowTitle = false;
            this.xuiLineGraph.ShowVerticalLines = false;
            this.xuiLineGraph.Size = new System.Drawing.Size(449, 281);
            this.xuiLineGraph.TabIndex = 2;
            this.xuiLineGraph.Text = "xuiLineGraph";
            this.xuiLineGraph.TitleAlignment = System.Drawing.StringAlignment.Near;
            this.xuiLineGraph.VerticalLineColor = System.Drawing.Color.DimGray;
            // 
            // StatisticsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 280);
            this.Controls.Add(this.xuiLineGraph);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticsPanel";
            this.Text = "Statistics";
            this.ResumeLayout(false);

        }

        #endregion
        private XanderUI.XUILineGraph xuiLineGraph;
    }
}