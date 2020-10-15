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
using Dashboard.Entities.Concrete;

namespace Dashboard.WinFormsUI.UserControls
{
    public partial class IsEmirleri : UserControl
    {
        public Machine Machine { get; set; }
        IWorkOrderStateService _workOrderStateService;
        ILogService _logService;
        public IsEmirleri()
        {
            InitializeComponent();
            _workOrderStateService = new WorkOrderStateManager(new MysqlWorkOrderStateDal());
            _logService = new LogManager(new MysqlLogDal());
        }

        private void IsEmirleri_Load(object sender, EventArgs e)
        {
            dgvWorkOrderStates.DataSource = _workOrderStateService.GetAllByMachine(Machine);

        }

        private void dgvWorkOrderStates_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           string workOrderNo = dgvWorkOrderStates.Rows[e.RowIndex].Cells[1].Value.ToString();
            bool isWorkOrderFinish = _workOrderStateService.IsWorkOrderFinish(Machine, workOrderNo);
            if (isWorkOrderFinish)
            {
                
                List<WorkOrderState> workOrderStates = new List<WorkOrderState>();
                workOrderStates = _workOrderStateService.GetByWorkOrderNo(Machine,workOrderNo);
                DateTime start = workOrderStates[1].Date;
                DateTime finish = workOrderStates[0].Date;
                TimeSpan duration = finish-start;
                lblDetay.Text = string.Format("{0}numaralı iş emri {1} tarihinde başladı {2} tarihinde bitti {3} zaman aldı", workOrderNo,start,finish,duration);
                int startId = workOrderStates[0].Id;
                int finishId = workOrderStates[1].Id;
                dgvWorkOrdersDetails.DataSource = _logService.GetById(Machine.Ip,"Machine","Logs",startId,finishId);
            }
            else
            {
                
                List<WorkOrderState> workOrderStates = new List<WorkOrderState>();
                workOrderStates = _workOrderStateService.GetByWorkOrderNo(Machine, workOrderNo);
                int startId = workOrderStates[0].Id;
                DateTime start = workOrderStates[0].Date;
                lblDetay.Text = string.Format("{0} tarihinde başlayan {1}  numaralı iş emri hala devam ediyor",start, workOrderNo);
                dgvWorkOrdersDetails.DataSource = _logService.GetById(Machine.Ip, "Machine", "Logs", startId, 0);
            }
        }

        private void dgvWorkOrdersDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvWorkOrdersDetails.Rows)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
