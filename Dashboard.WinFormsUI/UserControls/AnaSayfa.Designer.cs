namespace Dashboard.WinFormsUI.UserControls
{
    partial class AnaSayfa
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
            this.components = new System.ComponentModel.Container();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelGbs = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.timerDbCheck = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelGbs);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(875, 720);
            this.panelMain.TabIndex = 0;
            // 
            // panelGbs
            // 
            this.panelGbs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGbs.Location = new System.Drawing.Point(0, 25);
            this.panelGbs.Name = "panelGbs";
            this.panelGbs.Size = new System.Drawing.Size(875, 695);
            this.panelGbs.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.cbCategories);
            this.panelTop.Controls.Add(this.dtp);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(875, 25);
            this.panelTop.TabIndex = 0;
            // 
            // cbCategories
            // 
            this.cbCategories.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(200, 0);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(121, 21);
            this.cbCategories.TabIndex = 1;
            this.cbCategories.SelectionChangeCommitted += new System.EventHandler(this.cbCategories_SelectionChangeCommitted);
            // 
            // dtp
            // 
            this.dtp.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtp.Location = new System.Drawing.Point(0, 0);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 0;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // timerDbCheck
            // 
            this.timerDbCheck.Tick += new System.EventHandler(this.timerDbCheck_Tick);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "AnaSayfa";
            this.Size = new System.Drawing.Size(875, 720);
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.VisibleChanged += new System.EventHandler(this.AnaSayfa_VisibleChanged);
            this.panelMain.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.FlowLayoutPanel panelGbs;
        private System.Windows.Forms.Timer timerDbCheck;
    }
}
