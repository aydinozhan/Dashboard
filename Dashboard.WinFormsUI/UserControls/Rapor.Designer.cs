namespace Dashboard.WinFormsUI.UserControls
{
    partial class Rapor
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
            this.panelDgw = new System.Windows.Forms.Panel();
            this.dgvRapor = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pbBackButton = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            this.panelDgw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelDgw);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(875, 720);
            this.panelMain.TabIndex = 0;
            // 
            // panelDgw
            // 
            this.panelDgw.Controls.Add(this.dgvRapor);
            this.panelDgw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDgw.Location = new System.Drawing.Point(0, 30);
            this.panelDgw.Name = "panelDgw";
            this.panelDgw.Size = new System.Drawing.Size(875, 690);
            this.panelDgw.TabIndex = 1;
            // 
            // dgvRapor
            // 
            this.dgvRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRapor.Location = new System.Drawing.Point(0, 0);
            this.dgvRapor.Name = "dgvRapor";
            this.dgvRapor.Size = new System.Drawing.Size(875, 690);
            this.dgvRapor.TabIndex = 0;
            this.dgvRapor.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvRapor_DataBindingComplete);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblHeader);
            this.panelTop.Controls.Add(this.pbBackButton);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(875, 30);
            this.panelTop.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.Location = new System.Drawing.Point(50, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(76, 25);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Header";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbBackButton
            // 
            this.pbBackButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbBackButton.Image = global::Dashboard.WinFormsUI.Properties.Resources.Resim1;
            this.pbBackButton.Location = new System.Drawing.Point(0, 0);
            this.pbBackButton.Name = "pbBackButton";
            this.pbBackButton.Size = new System.Drawing.Size(50, 30);
            this.pbBackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBackButton.TabIndex = 0;
            this.pbBackButton.TabStop = false;
            this.pbBackButton.Click += new System.EventHandler(this.pbBackButton_Click);
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "Rapor";
            this.Size = new System.Drawing.Size(875, 720);
            this.Load += new System.EventHandler(this.Rapor_Load);
            this.panelMain.ResumeLayout(false);
            this.panelDgw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelDgw;
        private System.Windows.Forms.DataGridView dgvRapor;
        private System.Windows.Forms.PictureBox pbBackButton;
        private System.Windows.Forms.Label lblHeader;
    }
}
