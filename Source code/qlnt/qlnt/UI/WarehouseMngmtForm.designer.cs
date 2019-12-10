namespace qlnt.UI
{
    partial class WarehouseMngmtForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseMngmtForm));
            this.tbtnPesticideMngmt = new Bunifu.Framework.UI.BunifuTileButton();
            this.tbtnFertilizerMngmt = new Bunifu.Framework.UI.BunifuTileButton();
            this.tbtnProductMngmt = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // tbtnPesticideMngmt
            // 
            this.tbtnPesticideMngmt.BackColor = System.Drawing.Color.SeaGreen;
            this.tbtnPesticideMngmt.color = System.Drawing.Color.SeaGreen;
            this.tbtnPesticideMngmt.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.tbtnPesticideMngmt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnPesticideMngmt.Font = new System.Drawing.Font("Arial", 13F);
            this.tbtnPesticideMngmt.ForeColor = System.Drawing.Color.White;
            this.tbtnPesticideMngmt.Image = ((System.Drawing.Image)(resources.GetObject("tbtnPesticideMngmt.Image")));
            this.tbtnPesticideMngmt.ImagePosition = 16;
            this.tbtnPesticideMngmt.ImageZoom = 60;
            this.tbtnPesticideMngmt.LabelPosition = 32;
            this.tbtnPesticideMngmt.LabelText = "Danh sách thuốc BVTV";
            this.tbtnPesticideMngmt.Location = new System.Drawing.Point(141, 217);
            this.tbtnPesticideMngmt.Margin = new System.Windows.Forms.Padding(6);
            this.tbtnPesticideMngmt.Name = "tbtnPesticideMngmt";
            this.tbtnPesticideMngmt.Size = new System.Drawing.Size(205, 211);
            this.tbtnPesticideMngmt.TabIndex = 8;
            this.tbtnPesticideMngmt.Click += new System.EventHandler(this.tbtnPesticideMngmt_Click);
            // 
            // tbtnFertilizerMngmt
            // 
            this.tbtnFertilizerMngmt.BackColor = System.Drawing.Color.SeaGreen;
            this.tbtnFertilizerMngmt.color = System.Drawing.Color.SeaGreen;
            this.tbtnFertilizerMngmt.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.tbtnFertilizerMngmt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnFertilizerMngmt.Font = new System.Drawing.Font("Arial", 15F);
            this.tbtnFertilizerMngmt.ForeColor = System.Drawing.Color.White;
            this.tbtnFertilizerMngmt.Image = ((System.Drawing.Image)(resources.GetObject("tbtnFertilizerMngmt.Image")));
            this.tbtnFertilizerMngmt.ImagePosition = 19;
            this.tbtnFertilizerMngmt.ImageZoom = 60;
            this.tbtnFertilizerMngmt.LabelPosition = 39;
            this.tbtnFertilizerMngmt.LabelText = "Danh sách phân bón";
            this.tbtnFertilizerMngmt.Location = new System.Drawing.Point(754, 217);
            this.tbtnFertilizerMngmt.Margin = new System.Windows.Forms.Padding(6);
            this.tbtnFertilizerMngmt.Name = "tbtnFertilizerMngmt";
            this.tbtnFertilizerMngmt.Size = new System.Drawing.Size(205, 211);
            this.tbtnFertilizerMngmt.TabIndex = 10;
            this.tbtnFertilizerMngmt.Click += new System.EventHandler(this.tbtnFertilizerMngmt_Click);
            // 
            // tbtnProductMngmt
            // 
            this.tbtnProductMngmt.BackColor = System.Drawing.Color.SeaGreen;
            this.tbtnProductMngmt.color = System.Drawing.Color.SeaGreen;
            this.tbtnProductMngmt.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.tbtnProductMngmt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnProductMngmt.Font = new System.Drawing.Font("Arial", 15F);
            this.tbtnProductMngmt.ForeColor = System.Drawing.Color.White;
            this.tbtnProductMngmt.Image = ((System.Drawing.Image)(resources.GetObject("tbtnProductMngmt.Image")));
            this.tbtnProductMngmt.ImagePosition = 19;
            this.tbtnProductMngmt.ImageZoom = 60;
            this.tbtnProductMngmt.LabelPosition = 39;
            this.tbtnProductMngmt.LabelText = "Danh sách nông sản";
            this.tbtnProductMngmt.Location = new System.Drawing.Point(448, 217);
            this.tbtnProductMngmt.Margin = new System.Windows.Forms.Padding(6);
            this.tbtnProductMngmt.Name = "tbtnProductMngmt";
            this.tbtnProductMngmt.Size = new System.Drawing.Size(205, 211);
            this.tbtnProductMngmt.TabIndex = 9;
            this.tbtnProductMngmt.Click += new System.EventHandler(this.tbtnProductMngmt_Click);
            // 
            // WarehouseMngmtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Controls.Add(this.tbtnPesticideMngmt);
            this.Controls.Add(this.tbtnFertilizerMngmt);
            this.Controls.Add(this.tbtnProductMngmt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WarehouseMngmtForm";
            this.Text = "WarehouseMngmtForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton tbtnPesticideMngmt;
        private Bunifu.Framework.UI.BunifuTileButton tbtnFertilizerMngmt;
        private Bunifu.Framework.UI.BunifuTileButton tbtnProductMngmt;
    }
}