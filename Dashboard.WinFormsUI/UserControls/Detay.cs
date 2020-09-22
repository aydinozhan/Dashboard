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

namespace Dashboard.WinFormsUI.UserControls
{
    public partial class Detay : UserControl
    {
        public Machine Machine { get; set; }
        public Detay()
        {
            InitializeComponent();
        }

        private void Detay_Load(object sender, EventArgs e)
        {
            Console.WriteLine("machine name : "+Machine.MachineName);
        }
    }
}
