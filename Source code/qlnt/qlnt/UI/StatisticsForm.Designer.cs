namespace qlnt.UI
{
    partial class StatisticsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsForm));
            this.tbtnWarehouseStatistics = new Bunifu.Framework.UI.BunifuTileButton();
            this.tbtnFinancialStatistics = new Bunifu.Framework.UI.BunifuTileButton();
            this.tbtnSellingStatistics = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // tbtnWarehouseStatistics
            // 
            this.tbtnWarehouseStatistics.BackColor = System.Drawing.Color.SeaGreen;
            this.tbtnWarehouseStatistics.color = System.Drawing.Color.SeaGreen;
            this.tbtnWarehouseStatistics.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.tbtnWarehouseStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnWarehouseStatistics.Font = new System.Drawing.Font("Arial", 15F);
            this.tbtnWarehouseStatistics.ForeColor = System.Drawing.Color.White;
            this.tbtnWarehouseStatistics.Image = ((System.Drawing.Image)(resources.GetObject("tbtnWarehouseStatistics.Image")));
            this.tbtnWarehouseStatistics.ImagePosition = 19;
            this.tbtnWarehouseStatistics.ImageZoom = 50;
            this.tbtnWarehouseStatistics.LabelPosition = 39;
            this.tbtnWarehouseStatistics.LabelText = "Thống kê mặt hàng";
            this.tbtnWarehouseStatistics.Location = new System.Drawing.Point(141, 225);
            this.tbtnWarehouseStatistics.Margin = new System.Windows.Forms.Padding(6);
            this.tbtnWarehouseStatistics.Name = "tbtnWarehouseStatistics";
            this.tbtnWarehouseStatistics.Size = new System.Drawing.Size(205, 211);
            this.tbtnWarehouseStatistics.TabIndex = 11;
            this.tbtnWarehouseStatistics.Click += new System.EventHandler(this.tbtnWarehouseStatistics_Click);
            // 
            // tbtnFinancialStatistics
            // 
            this.tbtnFinancialStatistics.BackColor = System.Drawing.Color.SeaGreen;
            this.tbtnFinancialStatistics.color = System.Drawing.Color.SeaGreen;
            this.tbtnFinancialStatistics.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.tbtnFinancialStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnFinancialStatistics.Font = new System.Drawing.Font("Arial", 15F);
            this.tbtnFinancialStatistics.ForeColor = System.Drawing.Color.White;
            this.tbtnFinancialStatistics.Image = ((System.Drawing.Image)(resources.GetObject("tbtnFinancialStatistics.Image")));
            this.tbtnFinancialStatistics.ImagePosition = 19;
            this.tbtnFinancialStatistics.ImageZoom = 50;
            this.tbtnFinancialStatistics.LabelPosition = 39;
            this.tbtnFinancialStatistics.LabelText = "Thống kê doanh thu";
            this.tbtnFinancialStatistics.Location = new System.Drawing.Point(754, 225);
            this.tbtnFinancialStatistics.Margin = new System.Windows.Forms.Padding(6);
            this.tbtnFinancialStatistics.Name = "tbtnFinancialStatistics";
            this.tbtnFinancialStatistics.Size = new System.Drawing.Size(205, 211);
            this.tbtnFinancialStatistics.TabIndex = 13;
            this.tbtnFinancialStatistics.Click += new System.EventHandler(this.tbtnFinancialStatistics_Click);
            // 
            // tbtnSellingStatistics
            // 
            this.tbtnSellingStatistics.BackColor = System.Drawing.Color.SeaGreen;
            this.tbtnSellingStatistics.color = System.Drawing.Color.SeaGreen;
            this.tbtnSellingStatistics.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.tbtnSellingStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnSellingStatistics.Font = new System.Drawing.Font("Arial", 15F);
            this.tbtnSellingStatistics.ForeColor = System.Drawing.Color.White;
            this.tbtnSellingStatistics.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSellingStatistics.Image")));
            this.tbtnSellingStatistics.ImagePosition = 19;
            this.tbtnSellingStatistics.ImageZoom = 50;
            this.tbtnSellingStatistics.LabelPosition = 39;
            this.tbtnSellingStatistics.LabelText = "Thống kê sản lượng";
            this.tbtnSellingStatistics.Location = new System.Drawing.Point(448, 225);
            this.tbtnSellingStatistics.Margin = new System.Windows.Forms.Padding(6);
            this.tbtnSellingStatistics.Name = "tbtnSellingStatistics";
            this.tbtnSellingStatistics.Size = new System.Drawing.Size(205, 211);
            this.tbtnSellingStatistics.TabIndex = 12;
            this.tbtnSellingStatistics.Click += new System.EventHandler(this.tbtnSellingStatistics_Click);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Controls.Add(this.tbtnWarehouseStatistics);
            this.Controls.Add(this.tbtnFinancialStatistics);
            this.Controls.Add(this.tbtnSellingStatistics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton tbtnWarehouseStatistics;
        private Bunifu.Framework.UI.BunifuTileButton tbtnFinancialStatistics;
        private Bunifu.Framework.UI.BunifuTileButton tbtnSellingStatistics;
    }
}