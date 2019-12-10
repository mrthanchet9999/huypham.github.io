namespace qlnt.UI
{
    partial class FormThongKeDoanhThuTheoNam
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKeDoanhThuTheoNam));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnLoadChart = new XanderUI.XUISuperButton();
            this.comboBoxNam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnLoadChart
            // 
            this.btnLoadChart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btnLoadChart.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnLoadChart.ButtonImage")));
            this.btnLoadChart.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnLoadChart.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnLoadChart.ButtonText = "Thống kê";
            this.btnLoadChart.CornerRadius = 5;
            this.btnLoadChart.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLoadChart.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnLoadChart.HoverTextColor = System.Drawing.Color.White;
            this.btnLoadChart.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnLoadChart.Location = new System.Drawing.Point(263, 70);
            this.btnLoadChart.Name = "btnLoadChart";
            this.btnLoadChart.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnLoadChart.SelectedTextColor = System.Drawing.Color.White;
            this.btnLoadChart.Size = new System.Drawing.Size(98, 35);
            this.btnLoadChart.SuperSelected = false;
            this.btnLoadChart.TabIndex = 37;
            this.btnLoadChart.TextColor = System.Drawing.Color.White;
            this.btnLoadChart.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLoadChart.Click += new System.EventHandler(this.btnLoadChart_Click);
            // 
            // comboBoxNam
            // 
            this.comboBoxNam.FormattingEnabled = true;
            this.comboBoxNam.Location = new System.Drawing.Point(116, 76);
            this.comboBoxNam.Name = "comboBoxNam";
            this.comboBoxNam.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNam.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 42);
            this.label1.TabIndex = 34;
            this.label1.Text = "Thống kê doanh thu theo năm";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(59, 137);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "DoanhThu";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(606, 300);
            this.chart1.TabIndex = 38;
            this.chart1.Text = "chart1";
            // 
            // FormThongKeDoanhThuTheoNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnLoadChart);
            this.Controls.Add(this.comboBoxNam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThongKeDoanhThuTheoNam";
            this.Text = "ThongKeDoanhThuTheoNam";
            this.Load += new System.EventHandler(this.ThongKeDoanhThuTheoNam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private XanderUI.XUISuperButton btnLoadChart;
        private System.Windows.Forms.ComboBox comboBoxNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}