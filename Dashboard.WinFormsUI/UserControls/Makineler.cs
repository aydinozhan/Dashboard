using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dashboard.Business.Abtract;
using Dashboard.Business.Concrete;
using Dashboard.DataAccess.Concrete.Mysql;
using Dashboard.DataAccess.Concrete;

namespace Dashboard.WinFormsUI.UserControls
{
    public partial class Makineler : UserControl
    {
        IMachineService _machineService;
        ICategoryService _categoryService;
        public Makineler()
        {
            InitializeComponent();
            _machineService = new MachineManager(new MysqlMachineDal());
            _categoryService = new CategoryManager(new MysqlCategoryDal());
        }

        private void Makineler_Load(object sender, EventArgs e)
        {
            dgvMachines.DataSource = _machineService.GetAll();
            dgvCategories.DataSource = _categoryService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Machine machine = new Machine
            {
                Ip = tbIp.Text.ToString(),
                MachineName = tbMachineName.Text.ToString(),
                CategoryId = Int16.Parse(tbCategory.Text.ToString())
            };
            _machineService.Add(machine);
            MessageBox.Show("Kayıt Eklendi");
            tbIp.Text = "";
            tbMachineName.Text = "";
            tbCategory.Text = "";
            dgvMachines.DataSource = _machineService.GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dgvMachines.Rows[dgvMachines.CurrentCell.RowIndex].Cells[0].Value.ToString());
            _machineService.Delete(id);
            dgvMachines.DataSource = _machineService.GetAll();
            tbIp.Text = "";
            tbMachineName.Text = "";
            tbCategory.Text = "";
            MessageBox.Show("Kayıt Silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbIp.Text) || string.IsNullOrWhiteSpace(tbMachineName.Text))
            {

            }
            else
            {
                int id = Int32.Parse(dgvMachines.Rows[dgvMachines.CurrentCell.RowIndex].Cells[0].Value.ToString());
                Machine machine = new Machine
                {
                    Id=id,
                    Ip = tbIp.Text.ToString(),
                    MachineName = tbMachineName.Text.ToString(),
                    CategoryId = Int16.Parse(tbCategory.Text.ToString())
                };
                _machineService.Update(machine);
                tbIp.Text = "";
                tbMachineName.Text = "";
                tbCategory.Text = "";
                MessageBox.Show("Kayıt Güncellendi");
            }
            dgvMachines.DataSource = _machineService.GetAll();
        }
        private void dgvMachines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIp.Text = dgvMachines.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbMachineName.Text = dgvMachines.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbCategory.Text = dgvMachines.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ctgId = dgvCategories.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (ctgId != _categoryService.GetIdByName("Hepsi").ToString())
            {
                tbCategory.Text = ctgId;
            }    
        }
    }
}
