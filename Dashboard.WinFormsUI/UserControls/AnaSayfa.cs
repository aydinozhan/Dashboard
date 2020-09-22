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
using Dashboard.Business.Concrete;
using Dashboard.DataAccess.Concrete.Mysql;
using Dashboard.Business.Abtract;
using Dashboard.Entities.Concrete;

namespace Dashboard.WinFormsUI.UserControls
{
    public partial class AnaSayfa : UserControl
    {
        int a = 0;
        public List<Machine> _machines = new List<Machine>();
        public List<Category> _categories = new List<Category>();
        public List<GroupBox> _gbs = new List<GroupBox>();
        public List<Label> _lblListAcik = new List<Label>();
        public List<Label> _lblListKapali = new List<Label>();
        public List<Label> _lblListCalismaSuresi = new List<Label>();
        public List<string> _gbName = new List<string>();
        private IMachineService _machineService;
        private ICategoryService _categoryService;
        private ILogService _logService;
        private string _serverIp="172.16.0.221";
        private string _serverDb = "Backup";

        public AnaSayfa()
        {
            InitializeComponent();
            _machineService = new MachineManager(new MysqlMachineDal());
            _categoryService = new CategoryManager(new MysqlCategoryDal());
            _logService = new LogManager(new MysqlLogDal());
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            Console.WriteLine("ana sayfa load fired");
            _categories = _categoryService.GetAll();
            cbCategories.DataSource = _categories;
            cbCategories.DisplayMember = "CategoryName";
            cbCategories.ValueMember = "CategoryId";
            cbCategories.SelectedValue = _categoryService.GetIdByName("Hepsi");
            dtp.Format = DateTimePickerFormat.Custom;
            createGb(GetAllMachines());
            fillGb(GetAllMachines());

        }
        private List<Machine> GetAllMachines()
        {
            return _machineService.GetAll();
        }
        public void createGb(List<Machine> machines)
        {
            a = 0;
            _gbs.Clear();
            _gbName.Clear();
            panelGbs.Controls.Clear();
            _lblListAcik.Clear();
            _lblListKapali.Clear();
            _lblListCalismaSuresi.Clear();
            for (int i = 0; i < machines.Count; i++)
            {
                GroupBox gb = new GroupBox();
                gb.Name = machines[i].MachineName;
                gb.Size = new Size(200, 200);
                gb.Text = machines[i].MachineName + " " + machines[i].Ip;
                gb.Font = new Font("Segoe UI", 12);
                gb.FlatStyle = FlatStyle.Popup;
                gb.BackColor = (i % 2 == 0) ? Color.FromArgb(166, 162, 229) : Color.FromArgb(149, 198, 255);
                _gbs.Add(gb);
                panelGbs.Controls.Add(gb);
                _gbName.Add(gb.Name);
            }
            for (int i = 0; i < machines.Count; i++)
            {
                int idx = _gbName.IndexOf(machines[i].MachineName);
                GroupBox gb = _gbs[idx];

                Label lblAcik = new Label();
                lblAcik.Name = "label" + machines[i].MachineName;
                lblAcik.Text = "Açık geçen zaman";
                lblAcik.Size = new Size(150, 17);
                lblAcik.Font = new Font("Arial", 10);
                lblAcik.Location = new Point(10, 60);

                gb.Controls.Add(lblAcik);
                _lblListAcik.Add(lblAcik);

                Label lblKapali = new Label();
                lblKapali.Name = "label" + machines[i].MachineName;
                lblKapali.Text = "Kapalı geçen zaman";
                lblKapali.Size = new Size(150, 17);
                lblKapali.Font = new Font("Arial", 10);
                lblKapali.Location = new Point(10, 80);

                gb.Controls.Add(lblKapali);
                _lblListKapali.Add(lblKapali);

                Label lblCalismaSuresi = new Label();
                lblCalismaSuresi.Name = "labelCalismaSuresi";
                lblCalismaSuresi.Text = "çalışma süresi";
                lblCalismaSuresi.Size = new Size(150, 24);
                lblCalismaSuresi.Font = new Font("Arial", 10);
                lblCalismaSuresi.Location = new Point(10, 120);
                gb.Controls.Add(lblCalismaSuresi);
                _lblListCalismaSuresi.Add(lblCalismaSuresi);

                Button btn1 = new Button();
                btn1.Name = i.ToString();
                btn1.Text = "Detay";
                btn1.Size = new Size(70, 30);
                btn1.Location = new Point(65, 165);
                btn1.FlatStyle = FlatStyle.Flat;
                btn1.FlatAppearance.BorderSize = 0;
                btn1.BackColor = (i % 2 == 0) ? Color.FromArgb(118, 115, 179) : Color.FromArgb(98, 150, 204);
                btn1.Click += new EventHandler(this.btn_click);
                gb.Controls.Add(btn1);
                a = a + 1;

            }
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int index = Convert.ToInt32(btn.Name.ToString());
            List<Machine> machines = new List<Machine>();
            string s = cbCategories.SelectedValue.ToString();
            int ctgId;
            if (int.TryParse(s, out ctgId))
            {
                int idForAll = _categoryService.GetIdByName("Hepsi");
                if (idForAll == ctgId)
                {
                    machines = GetAllMachines();
                }
                else
                {
                    machines = _machineService.GetByCategoryId(ctgId);
                }
            }
            else
            {
                // invalid integer
            }           
            Detay dt = new Detay
            {
                Machine = machines[index]
            };
            panelMain.Controls.Clear();
            panelMain.Controls.Add(dt);
            dt.Show();
            dt.Dock = DockStyle.Fill;
            dt.BringToFront();
        }
        public void fillGb(List<Machine> machines)
        {
            string date = dtp.Value.ToString("yyyy-MM-dd");
            for (int i = 0; i < (machines.Count); i++)
            {
                //string today = DateTime.Now.ToString("yyyy-MM-dd");
                _lblListAcik[i].Text = "acik : " +_logService.SpendTime(machines[i].Ip,"Machine" , "Logs", date, "open").ToString();
                _lblListKapali[i].Text = "kapali : " + _logService.SpendTime(machines[i].Ip, "Machine", "Logs", date, "close").ToString();
                Log lastLog = new Log();
                lastLog = _logService.GetLast(machines[i].Ip,"Machine","Logs");
                string lastState =lastLog.LastState;
                DateTime lastTime = lastLog.LastDate;
                TimeSpan gecenSure = DateTime.Now - lastTime;
                _lblListCalismaSuresi[i].Text = lastState + " " + gecenSure.ToString("h'h 'm'm 's's'");
            }
        }
        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            List<Machine> machines = new List<Machine>();
            if (Convert.ToInt32(cbCategories.SelectedValue.ToString())==_categoryService.GetIdByName("Hepsi"))
            {
                machines.Clear();
                machines = _machineService.GetAll();
            }
            else
            {
                machines.Clear();
                machines = _machineService.GetByCategoryId(Convert.ToInt32(cbCategories.SelectedValue.ToString()));
            }
            string theDate = dtp.Value.ToString("yyyy-MM-dd");
            for (int i = 0; i < machines.Count; i++)
            {
                if (DateTime.Today.ToString("yyy-MM-dd") == theDate)
                {
                    //timer1.Enabled = true;
                    _lblListAcik[i].Text = "acik : " + _logService.SpendTime(machines[i].Ip, "Machine", "Logs",theDate, "open").ToString();
                    _lblListKapali[i].Text = "kapali : " + _logService.SpendTime(machines[i].Ip, "Machine", "Logs", theDate, "close").ToString();
                }
                else
                {
                    //timer1.Enabled = false;
                    _lblListAcik[i].Text = "acik : " + _logService.SpendTime(_serverIp,_serverDb,machines[i].MachineName,theDate,"open").ToString();
                    _lblListKapali[i].Text = "kapali : " + _logService.SpendTime(_serverIp, _serverDb, machines[i].MachineName, theDate, "close").ToString();
                    _lblListCalismaSuresi[i].Text = "";
                }
            }
        }

        private void cbCategories_SelectionChangeCommitted(object sender, EventArgs e)
        {
            panelGbs.Controls.Clear();
            string s = cbCategories.SelectedValue.ToString();
            int ctgId;
            if (int.TryParse(s, out ctgId))
            {
                int idForAll = _categoryService.GetIdByName("Hepsi");
                if (idForAll == ctgId)
                {
                    List<Machine> machines = new List<Machine>();
                    machines = GetAllMachines();
                    createGb(machines);
                    fillGb(machines);
                }
                else
                {
                    List<Machine> machines = new List<Machine>();
                    machines = _machineService.GetByCategoryId(ctgId);
                    createGb(machines);
                    fillGb(machines);
                }
            }
            else
            {
                // invalid integer
            }
        }
    }
}
