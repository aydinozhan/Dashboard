namespace Dashboard.WinFormsUI.UserControls
{
    partial class IsEmirleri
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.dgvWorkOrdersDetails = new System.Windows.Forms.DataGridView();
            this.panelMid = new System.Windows.Forms.Panel();
            this.lblDetay = new System.Windows.Forms.Label();
            this.dgvWorkOrderStates = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrdersDetails)).BeginInit();
            this.panelMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrderStates)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.dgvWorkOrdersDetails);
            this.panelMain.Controls.Add(this.panelMid);
            this.panelMain.Controls.Add(this.dgvWorkOrderStates);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(875, 720);
            this.panelMain.TabIndex = 0;
            // 
            // dgvWorkOrdersDetails
            // 
            this.dgvWorkOrdersDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvWorkOrdersDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkOrdersDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorkOrdersDetails.Location = new System.Drawing.Point(0, 405);
            this.dgvWorkOrdersDetails.Name = "dgvWorkOrdersDetails";
            this.dgvWorkOrdersDetails.Size = new System.Drawing.Size(875, 315);
            this.dgvWorkOrdersDetails.TabIndex = 2;
            this.dgvWorkOrdersDetails.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvWorkOrdersDetails_DataBindingComplete);
            // 
            // panelMid
            // 
            this.panelMid.Controls.Add(this.lblDetay);
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMid.Location = new System.Drawing.Point(0, 375);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(875, 30);
            this.panelMid.TabIndex = 3;
            // 
            // lblDetay
            // 
            this.lblDetay.AutoSize = true;
            this.lblDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDetay.Location = new System.Drawing.Point(0, 0);
            this.lblDetay.Name = "lblDetay";
            this.lblDetay.Size = new System.Drawing.Size(46, 17);
            this.lblDetay.TabIndex = 0;
            this.lblDetay.Text = "label1";
            this.lblDetay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvWorkOrderStates
            // 
            this.dgvWorkOrderStates.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvWorkOrderStates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkOrderStates.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvWorkOrderStates.Location = new System.Drawing.Point(0, 30);
            this.dgvWorkOrderStates.Name = "dgvWorkOrderStates";
            this.dgvWorkOrderStates.Size = new System.Drawing.Size(875, 345);
            this.dgvWorkOrderStates.TabIndex = 1;
            this.dgvWorkOrderStates.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkOrderStates_CellClick);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.textBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(875, 30);
            this.panelTop.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IsEmirleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "IsEmirleri";
            this.Size = new System.Drawing.Size(875, 720);
            this.Load += new System.EventHandler(this.IsEmirleri_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrdersDetails)).EndInit();
            this.panelMid.ResumeLayout(false);
            this.panelMid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrderStates)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dgvWorkOrderStates;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.DataGridView dgvWorkOrdersDetails;
        private System.Windows.Forms.Panel panelMid;
        private System.Windows.Forms.Label lblDetay;
        private System.Windows.Forms.TextBox textBox1;
    }
}
