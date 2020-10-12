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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMonth = new System.Windows.Forms.Panel();
            this.barMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pieMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelWeek = new System.Windows.Forms.Panel();
            this.barWeek = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pieWeek = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelDay = new System.Windows.Forms.Panel();
            this.lblCloseDay = new System.Windows.Forms.Label();
            this.lblOpenDay = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.barDay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieMonth)).BeginInit();
            this.panelWeek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barWeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieWeek)).BeginInit();
            this.panelDay.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barDay)).BeginInit();
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
            // barMonth
            // 
            chartArea12.AxisX.IsLabelAutoFit = false;
            chartArea12.AxisX.LabelStyle.Angle = 90;
            chartArea12.Name = "ChartArea1";
            this.barMonth.ChartAreas.Add(chartArea12);
            this.barMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barMonth.Location = new System.Drawing.Point(300, 0);
            this.barMonth.Name = "barMonth";
            series12.ChartArea = "ChartArea1";
            series12.Name = "Series1";
            series12.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series12.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.barMonth.Series.Add(series12);
            this.barMonth.Size = new System.Drawing.Size(575, 230);
            this.barMonth.TabIndex = 3;
            this.barMonth.Text = "chart1";
            this.barMonth.Click += new System.EventHandler(this.barMonth_Click);
            // 
            // pieMonth
            // 
            chartArea13.Name = "ChartArea1";
            this.pieMonth.ChartAreas.Add(chartArea13);
            this.pieMonth.Dock = System.Windows.Forms.DockStyle.Left;
            legend5.Name = "Legend1";
            this.pieMonth.Legends.Add(legend5);
            this.pieMonth.Location = new System.Drawing.Point(0, 0);
            this.pieMonth.Name = "pieMonth";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.pieMonth.Series.Add(series13);
            this.pieMonth.Size = new System.Drawing.Size(300, 230);
            this.pieMonth.TabIndex = 2;
            this.pieMonth.Text = "chart1";
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
            // barWeek
            // 
            chartArea14.AxisX.IsLabelAutoFit = false;
            chartArea14.AxisX.LabelStyle.Angle = 90;
            chartArea14.Name = "ChartArea1";
            this.barWeek.ChartAreas.Add(chartArea14);
            this.barWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barWeek.Location = new System.Drawing.Point(300, 0);
            this.barWeek.Name = "barWeek";
            series14.ChartArea = "ChartArea1";
            series14.Name = "Series1";
            series14.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series14.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.barWeek.Series.Add(series14);
            this.barWeek.Size = new System.Drawing.Size(575, 230);
            this.barWeek.TabIndex = 0;
            this.barWeek.Text = "chart1";
            this.barWeek.Click += new System.EventHandler(this.barWeek_Click);
            // 
            // pieWeek
            // 
            chartArea15.Name = "ChartArea1";
            this.pieWeek.ChartAreas.Add(chartArea15);
            this.pieWeek.Dock = System.Windows.Forms.DockStyle.Left;
            legend6.Name = "Legend1";
            this.pieWeek.Legends.Add(legend6);
            this.pieWeek.Location = new System.Drawing.Point(0, 0);
            this.pieWeek.Name = "pieWeek";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            this.pieWeek.Series.Add(series15);
            this.pieWeek.Size = new System.Drawing.Size(300, 230);
            this.pieWeek.TabIndex = 1;
            this.pieWeek.Text = "chart1";
            // 
            // panelDay
            // 
            this.panelDay.Controls.Add(this.label3);
            this.panelDay.Controls.Add(this.label2);
            this.panelDay.Controls.Add(this.label1);
            this.panelDay.Controls.Add(this.barDay);
            this.panelDay.Controls.Add(this.lblCloseDay);
            this.panelDay.Controls.Add(this.lblOpenDay);
            this.panelDay.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDay.Location = new System.Drawing.Point(0, 30);
            this.panelDay.Name = "panelDay";
            this.panelDay.Size = new System.Drawing.Size(875, 230);
            this.panelDay.TabIndex = 1;
            // 
            // lblCloseDay
            // 
            this.lblCloseDay.AutoSize = true;
            this.lblCloseDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCloseDay.Location = new System.Drawing.Point(164, 49);
            this.lblCloseDay.Name = "lblCloseDay";
            this.lblCloseDay.Size = new System.Drawing.Size(114, 25);
            this.lblCloseDay.TabIndex = 1;
            this.lblCloseDay.Text = "Kapali Süre";
            // 
            // lblOpenDay
            // 
            this.lblOpenDay.AutoSize = true;
            this.lblOpenDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOpenDay.Location = new System.Drawing.Point(164, 112);
            this.lblOpenDay.Name = "lblOpenDay";
            this.lblOpenDay.Size = new System.Drawing.Size(97, 25);
            this.lblOpenDay.TabIndex = 0;
            this.lblOpenDay.Text = "Açık Süre";
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
            // barDay
            // 
            chartArea11.AxisX.IsLabelAutoFit = false;
            chartArea11.AxisX.LabelStyle.Angle = 90;
            chartArea11.AxisX.Title = "Saat";
            chartArea11.AxisY.Title = "Açık Geçen Dk";
            chartArea11.Name = "ChartArea1";
            this.barDay.ChartAreas.Add(chartArea11);
            this.barDay.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDay.Location = new System.Drawing.Point(300, 0);
            this.barDay.Name = "barDay";
            series11.ChartArea = "ChartArea1";
            series11.Name = "Series1";
            series11.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series11.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.barDay.Series.Add(series11);
            this.barDay.Size = new System.Drawing.Size(575, 230);
            this.barDay.TabIndex = 2;
            this.barDay.Text = "chart1";
            this.barDay.Click += new System.EventHandler(this.barDay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kapali Süre : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Açık Süre : ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(114, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Günlük Verim";
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
            this.panelMonth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieMonth)).EndInit();
            this.panelWeek.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barWeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieWeek)).EndInit();
            this.panelDay.ResumeLayout(false);
            this.panelDay.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barDay)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart barDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
