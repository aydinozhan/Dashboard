namespace Dashboard.WinFormsUI.UserControls
{
    partial class Makineler
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelMachines = new System.Windows.Forms.Panel();
            this.panelCategories = new System.Windows.Forms.Panel();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMachineName = new System.Windows.Forms.TextBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvMachines = new System.Windows.Forms.DataGridView();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.panelMain.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelMachines.SuspendLayout();
            this.panelCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelCategories);
            this.panelMain.Controls.Add(this.panelMachines);
            this.panelMain.Controls.Add(this.panelLeft);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(875, 720);
            this.panelMain.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btnUpdate);
            this.panelLeft.Controls.Add(this.btnDelete);
            this.panelLeft.Controls.Add(this.btnAdd);
            this.panelLeft.Controls.Add(this.tbCategory);
            this.panelLeft.Controls.Add(this.tbMachineName);
            this.panelLeft.Controls.Add(this.label3);
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.tbIp);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(270, 720);
            this.panelLeft.TabIndex = 0;
            // 
            // panelMachines
            // 
            this.panelMachines.Controls.Add(this.dgvMachines);
            this.panelMachines.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMachines.Location = new System.Drawing.Point(270, 0);
            this.panelMachines.Name = "panelMachines";
            this.panelMachines.Size = new System.Drawing.Size(605, 434);
            this.panelMachines.TabIndex = 1;
            // 
            // panelCategories
            // 
            this.panelCategories.Controls.Add(this.dgvCategories);
            this.panelCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCategories.Location = new System.Drawing.Point(270, 434);
            this.panelCategories.Name = "panelCategories";
            this.panelCategories.Size = new System.Drawing.Size(605, 286);
            this.panelCategories.TabIndex = 2;
            // 
            // tbIp
            // 
            this.tbIp.Location = new System.Drawing.Point(119, 13);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(124, 20);
            this.tbIp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ip : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Makine Adı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category :";
            // 
            // tbMachineName
            // 
            this.tbMachineName.Location = new System.Drawing.Point(119, 85);
            this.tbMachineName.Name = "tbMachineName";
            this.tbMachineName.Size = new System.Drawing.Size(124, 20);
            this.tbMachineName.TabIndex = 6;
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(119, 155);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(124, 20);
            this.tbCategory.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(119, 241);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 50);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(119, 301);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 50);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Silver;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(119, 360);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 50);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvMachines
            // 
            this.dgvMachines.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMachines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMachines.Location = new System.Drawing.Point(0, 0);
            this.dgvMachines.Name = "dgvMachines";
            this.dgvMachines.Size = new System.Drawing.Size(605, 434);
            this.dgvMachines.TabIndex = 0;
            this.dgvMachines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMachines_CellClick);
            // 
            // dgvCategories
            // 
            this.dgvCategories.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategories.Location = new System.Drawing.Point(0, 0);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.Size = new System.Drawing.Size(605, 286);
            this.dgvCategories.TabIndex = 1;
            // 
            // Makineler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "Makineler";
            this.Size = new System.Drawing.Size(875, 720);
            this.Load += new System.EventHandler(this.Makineler_Load);
            this.panelMain.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelMachines.ResumeLayout(false);
            this.panelCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelCategories;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.Panel panelMachines;
        private System.Windows.Forms.DataGridView dgvMachines;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.TextBox tbMachineName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIp;
    }
}
