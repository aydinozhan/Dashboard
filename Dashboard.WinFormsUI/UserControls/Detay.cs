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
    public partial class Detay : UserControl
    {
        public Machine Machine { get; set; }
        private ILogService _logService;
        private string _raspiDb = "Machine";
        private string _raspiTable = "Logs";
        private string _serverIp = "172.16.0.221";
        private string _serverDb = "Backup";
        TimeSpan acikZaman = new TimeSpan(0, 0, 0);
        TimeSpan kapaliZaman = new TimeSpan(0, 0, 0);
        public Detay()
        {
            InitializeComponent();
            _logService = new LogManager(new MysqlLogDal());
            barMonth.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            barWeek.ChartAreas["ChartArea1"].AxisX.Interval = 1;
        }

        private void Detay_Load(object sender, EventArgs e)
        {
            lblMachineName.Text=Machine.MachineName;
            Console.WriteLine("Detay Load fired");
            string bugun = DateTime.Now.ToString("yyyy-MM-dd");
            string today = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");
            string birAyOnce = DateTime.Now.AddMonths(-1).ToString("yyyy-MM-dd");
            string birHaftaOnce = DateTime.Now.AddDays(-8).ToString("yyyy-MM-dd");

            double openHours1 = _logService.SpendTime(Machine.Ip, _raspiDb, _raspiTable,bugun, "open").TotalHours;
            double closeHours1 = _logService.SpendTime(Machine.Ip, _raspiDb, _raspiTable, bugun, "close").TotalHours;

            lblOpenDay.Text = _logService.SpendTime(Machine.Ip, _raspiDb, _raspiTable, bugun, "open").ToString();
            lblCloseDay.Text = _logService.SpendTime(Machine.Ip, _raspiDb, _raspiTable, bugun, "close").ToString();

            DateTime dt = DateTime.Now;
            dt = dt.AddDays(-8);
            while (today != birHaftaOnce)
            {

                dt = dt.AddDays(+1);
                birHaftaOnce = dt.ToString("yyyy-MM-dd");
                //TimeSpan zamanAcik = _machineDal.GecenSure(birHaftaOnce, "172.16.0.221", machineName, "Backup","open");
                //TimeSpan zamanKapali = _machineDal.GecenSure(birHaftaOnce, "172.16.0.221", machineName, "Backup","close");
                TimeSpan zamanAcik = _logService.GetSpendTimes(_serverIp,_serverDb,"OpenTimes",Machine.Ip,birHaftaOnce);
                TimeSpan zamanKapali = _logService.GetSpendTimes(_serverIp, _serverDb, "CloseTimes", Machine.Ip, birHaftaOnce);
                acikZaman = acikZaman + zamanAcik;
                kapaliZaman = kapaliZaman + zamanKapali;

                barWeek.Series["Series1"].Points.AddXY(birHaftaOnce, zamanAcik.TotalHours);
            }
            double totalOpenTimeByWeek = acikZaman.TotalHours;
            double totalCloseTimeByWeek = kapaliZaman.TotalHours;

            acikZaman = new TimeSpan(0, 0, 0);
            kapaliZaman = new TimeSpan(0, 0, 0);

            dt = DateTime.Now;
            dt = dt.AddMonths(-1);
            while (today != birAyOnce)
            {

                dt = dt.AddDays(+1);
                birAyOnce = dt.ToString("yyyy-MM-dd");
                //TimeSpan zamanAcik = _machineDal.GecenSure(birAyOnce, "172.16.0.221", machineName, "Backup","open");
                //TimeSpan zamanKapali = _machineDal.GecenSure(birAyOnce, "172.16.0.221", machineName, "Backup","close");
                TimeSpan zamanAcik = _logService.GetSpendTimes(_serverIp, _serverDb, "OpenTimes", Machine.Ip, birAyOnce);
                TimeSpan zamanKapali = _logService.GetSpendTimes(_serverIp, _serverDb, "CloseTimes", Machine.Ip, birAyOnce);
                acikZaman = acikZaman + zamanAcik;
                kapaliZaman = kapaliZaman + zamanKapali;
                barMonth.Series["Series1"].Points.AddXY(birAyOnce, zamanAcik.TotalHours);

            }

            double totalOpenTimeByMonth = acikZaman.TotalHours;
            double totalCloseTimeByMonth = kapaliZaman.TotalHours;
            acikZaman = new TimeSpan(0, 0, 0);
            kapaliZaman = new TimeSpan(0, 0, 0);


            double oDay = (openHours1 / (openHours1 + closeHours1)) * 100;
            double cDay = (closeHours1 / (openHours1 + closeHours1)) * 100;
            oDay = (double)System.Math.Round(oDay, 2);
            cDay = (double)System.Math.Round(cDay, 2);

            //pieDay.Titles.Add("Günlük Verim");
            //pieDay.Series["Series1"].Points.AddXY("open %" + oDay.ToString(), oDay);
            //pieDay.Series["Series1"].Points.AddXY("close %" + cDay.ToString(), cDay);
            //////////////////////////////////////////
            //gaugeDay.Value = Convert.ToSingle(oDay);


            double oWeek = (totalOpenTimeByWeek / (totalOpenTimeByWeek + totalCloseTimeByWeek)) * 100;
            double cWeek = (totalCloseTimeByWeek / (totalOpenTimeByWeek + totalCloseTimeByWeek)) * 100;
            oWeek = (double)System.Math.Round(oWeek, 2);
            cWeek = (double)System.Math.Round(cWeek, 2);

            pieWeek.Titles.Add("Haftalık Verim");
            pieWeek.Series["Series1"].Points.AddXY("open %" + oWeek.ToString(), oWeek);
            pieWeek.Series["Series1"].Points.AddXY("close %" + cWeek.ToString(), cWeek);


            double oMonth = (totalOpenTimeByMonth / (totalOpenTimeByMonth + totalCloseTimeByMonth)) * 100;
            double cMonth = (totalCloseTimeByMonth / (totalOpenTimeByMonth + totalCloseTimeByMonth)) * 100;
            oMonth = (double)System.Math.Round(oMonth, 2);
            cMonth = (double)System.Math.Round(cMonth, 2);

            pieMonth.Titles.Add("Aylık Verim");
            pieMonth.Series["Series1"].Points.AddXY("open %" + oMonth.ToString(), oMonth);
            pieMonth.Series["Series1"].Points.AddXY("close %" + cMonth.ToString(), cMonth);
        }

        private void barWeek_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            DateTime sDay = dt.AddDays(-8);
            string startDay = sDay.ToString("yyyy-MM-dd");
            DateTime eDay = dt.AddDays(-1);
            string endDay = eDay.ToString("yyy-MM-dd");
            Rapor rapor = new Rapor
            {
                Machine = Machine,
                StartDay = startDay,
                EndDay = endDay
            };
            panelMain.Controls.Clear();
            panelMain.Controls.Add(rapor);
            rapor.Show();
            rapor.Dock = DockStyle.Fill;
            rapor.BringToFront();
        }

        private void barMonth_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            DateTime eDay = dt.AddDays(-1);
            string endDay = eDay.ToString("yyy-MM-dd");
            DateTime sDay = eDay.AddMonths(-1);
            string startDay = sDay.ToString("yyyy-MM-dd");
            Rapor rapor = new Rapor
            {
                Machine = Machine,
                StartDay = startDay,
                EndDay = endDay
            };
            panelMain.Controls.Clear();
            panelMain.Controls.Add(rapor);
            rapor.Show();
            rapor.Dock = DockStyle.Fill;
            rapor.BringToFront();
        }
    }
}
