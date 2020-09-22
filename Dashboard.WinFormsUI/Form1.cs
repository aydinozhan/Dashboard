using Dashboard.Business.Abtract;
using Dashboard.Business.Concrete;
using Dashboard.DataAccess.Concrete;
using Dashboard.DataAccess.Concrete.Mysql;
using Dashboard.Entities.Concrete;
using Dashboard.WinFormsUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.WinFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _categoryService = new CategoryManager(new MysqlCategoryDal());
            _machineService = new MachineManager(new MysqlMachineDal());
            _logService = new LogManager(new MysqlLogDal());
        }
        private ICategoryService _categoryService;
        private IMachineService _machineService;
        private ILogService _logService;
        private void Form1_Load_1(object sender, EventArgs e)
        {
            Console.WriteLine("form1 load event fired");
            AnaSayfa anaSayfa = new AnaSayfa();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(anaSayfa);
            anaSayfa.Show();
            anaSayfa.Dock = DockStyle.Fill;
            anaSayfa.BringToFront();
        }
        private void pbExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // user clicked no
            }
        }
        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(anaSayfa);
            anaSayfa.Show();
            anaSayfa.Dock = DockStyle.Fill;
            anaSayfa.BringToFront();
        }
        private void btnMakineler_Click(object sender, EventArgs e)
        {
            Makineler makineler = new Makineler();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(makineler);
            makineler.Show();
            makineler.Dock = DockStyle.Fill;
            makineler.BringToFront();
        }

     
    }
}
