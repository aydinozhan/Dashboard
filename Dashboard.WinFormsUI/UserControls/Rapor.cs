using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dashboard.DataAccess.Concrete;
using Dashboard.Business.Abtract;
using Dashboard.Business.Concrete;
using Dashboard.DataAccess.Concrete.Mysql;

namespace Dashboard.WinFormsUI.UserControls
{
    public partial class Rapor : UserControl
    {
        public Machine Machine { get; set; }
        public string StartDay { get; set; }
        public string EndDay { get; set; }
        private string _serverIp = "172.16.0.221";
        private string _serverDb = "Backup";
        ILogService _logService;
        public Rapor()
        {
            InitializeComponent();
            _logService = new LogManager(new MysqlLogDal());
        }

        private void Rapor_Load(object sender, EventArgs e)
        {
            lblHeader.Text = string.Format("{0} Makinesi {1} ve {2} Tarihleri Arasındaki Kayıtları ",Machine.MachineName,StartDay,EndDay);
            if (DateTime.Now.ToString("yyyy-MM-dd") == EndDay)
            {
                dgvRapor.DataSource = _logService.GetByDate(Machine.Ip, "Machine", "Logs", StartDay, EndDay);
            }
            else
            {
                dgvRapor.DataSource = _logService.GetByDate(_serverIp,_serverDb,Machine.MachineName,StartDay,EndDay);
            }
            
        }

        private void dgvRapor_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvRapor.Rows)
            {
                if (row.Cells[2].Value.ToString() == "close")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(239, 83, 80);
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(102, 187, 106);
                }
            }
        }

        private void pbBackButton_Click(object sender, EventArgs e)
        {
            Detay dt = new Detay
            {
               Machine =Machine
            };
            panelMain.Controls.Clear();
            panelMain.Controls.Add(dt);
            dt.Show();
            dt.Dock = DockStyle.Fill;
            dt.BringToFront();
        }
    }
}
