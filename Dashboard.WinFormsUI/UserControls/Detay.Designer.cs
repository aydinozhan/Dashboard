namespace Dashboard.WinFormsUI.UserControls
{
    partial class Detay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelDay = new System.Windows.Forms.Panel();
            this.panelWeek = new System.Windows.Forms.Panel();
            this.panelMonth = new System.Windows.Forms.Panel();
            this.barWeek = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pieWeek = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pieMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.barMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.lblOpenDay = new System.Windows.Forms.Label();
            this.lblCloseDay = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelDay.SuspendLayout();
            this.panelWeek.SuspendLayout();
            this.panelMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barWeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieWeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelMonth);
            this.panelMain.Controls.Add(this.panelWeek);
            this.panelMain.Controls.Add(this.panelDay);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(875, 720);
            this.panelMain.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblMachineName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(875, 30);
            this.panelTop.TabIndex = 0;
            // 
            // panelDay
            // 
            this.panelDay.Controls.Add(this.lblCloseDay);
            this.panelDay.Controls.Add(this.lblOpenDay);
            this.panelDay.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDay.Location = new System.Drawing.Point(0, 30);
            this.panelDay.Name = "panelDay";
            this.panelDay.Size = new System.Drawing.Size(875, 230);
            this.panelDay.TabIndex = 1;
            // 
            // panelWeek
            // 
            this.panelWeek.Controls.Add(this.barWeek);
            this.panelWeek.Controls.Add(this.pieWeek);
            this.panelWeek.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWeek.Location = new System.Drawing.Point(0, 260);
            this.panelWeek.Name = "panelWeek";
            this.panelWeek.Size = new System.Drawing.Size(875, 230);
            this.panelWeek.TabIndex = 2;
            // 
            // panelMonth
            // 
            this.panelMonth.Controls.Add(this.barMonth);
            this.panelMonth.Controls.Add(this.pieMonth);
            this.panelMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMonth.Location = new System.Drawing.Point(0, 490);
            this.panelMonth.Name = "panelMonth";
            this.panelMonth.Size = new System.Drawing.Size(875, 230);
            this.panelMonth.TabIndex = 3;
            // 
            // barWeek
            // 
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Angle = 90;
            chartArea3.Name = "ChartArea1";
            this.barWeek.ChartAreas.Add(chartArea3);
            this.barWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barWeek.Location = new System.Drawing.Point(300, 0);
            this.barWeek.Name = "barWeek";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.barWeek.Series.Add(series3);
            this.barWeek.Size = new System.Drawing.Size(575, 230);
            this.barWeek.TabIndex = 0;
            this.barWeek.Text = "chart1";
            this.barWeek.Click += new System.EventHandler(this.barWeek_Click);
            // 
            // pieWeek
            // 
            chartArea4.Name = "ChartArea1";
            this.pieWeek.ChartAreas.Add(chartArea4);
            this.pieWeek.Dock = System.Windows.Forms.DockStyle.Left;
            legend2.Name = "Legend1";
            this.pieWeek.Legends.Add(legend2);
            this.pieWeek.Location = new System.Drawing.Point(0, 0);
            this.pieWeek.Name = "pieWeek";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.pieWeek.Series.Add(series4);
            this.pieWeek.Size = new System.Drawing.Size(300, 230);
            this.pieWeek.TabIndex = 1;
            this.pieWeek.Text = "chart1";
            // 
            // pieMonth
            // 
            chartArea2.Name = "ChartArea1";
            this.pieMonth.ChartAreas.Add(chartArea2);
            this.pieMonth.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            this.pieMonth.Legends.Add(legend1);
            this.pieMonth.Location = new System.Drawing.Point(0, 0);
            this.pieMonth.Name = "pieMonth";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.pieMonth.Series.Add(series2);
            this.pieMonth.Size = new System.Drawing.Size(300, 230);
            this.pieMonth.TabIndex = 2;
            this.pieMonth.Text = "chart1";
            // 
            // barMonth
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = 90;
            chartArea1.Name = "ChartArea1";
            this.barMonth.ChartAreas.Add(chartArea1);
            this.barMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barMonth.Location = new System.Drawing.Point(300, 0);
            this.barMonth.Name = "barMonth";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.barMonth.Series.Add(series1);
            this.barMonth.Size = new System.Drawing.Size(575, 230);
            this.barMonth.TabIndex = 3;
            this.barMonth.Text = "chart1";
            this.barMonth.Click += new System.EventHandler(this.barMonth_Click);
            // 
            // lblMachineName
            // 
            this.lblMachineName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMachineName.Location = new System.Drawing.Point(374, 7);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(111, 20);
            this.lblMachineName.TabIndex = 0;
            this.lblMachineName.Text = "MachineName";
            // 
            // lblOpenDay
            // 
            this.lblOpenDay.AutoSize = true;
            this.lblOpenDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOpenDay.Location = new System.Drawing.Point(375, 42);
            this.lblOpenDay.Name = "lblOpenDay";
            this.lblOpenDay.Size = new System.Drawing.Size(97, 25);
            this.lblOpenDay.TabIndex = 0;
            this.lblOpenDay.Text = "Açık Süre";
            // 
            // lblCloseDay
            // 
            this.lblCloseDay.AutoSize = true;
            this.lblCloseDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCloseDay.Location = new System.Drawing.Point(375, 91);
            this.lblCloseDay.Name = "lblCloseDay";
            this.lblCloseDay.Size = new System.Drawing.Size(114, 25);
            this.lblCloseDay.TabIndex = 1;
            this.lblCloseDay.Text = "Kapali Süre";
            // 
            // Detay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "Detay";
            this.Size = new System.Drawing.Size(875, 720);
            this.Load += new System.EventHandler(this.Detay_Load);
            this.panelMain.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelDay.ResumeLayout(false);
            this.panelDay.PerformLayout();
            this.panelWeek.ResumeLayout(false);
            this.panelMonth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barWeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieWeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barMonth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart barMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieMonth;
        private System.Windows.Forms.Panel panelWeek;
        private System.Windows.Forms.DataVisualization.Charting.Chart barWeek;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieWeek;
        private System.Windows.Forms.Panel panelDay;
        private System.Windows.Forms.Label lblCloseDay;
        private System.Windows.Forms.Label lblOpenDay;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblMachineName;
    }
}
