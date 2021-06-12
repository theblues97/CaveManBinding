using System;
using System.Windows.Forms;
using CaveManBinding.ViewModel;

namespace CaveManBinding
{
    public partial class frmMain : Form
    {
        private frmMainVM vm;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            vm = new frmMainVM();
            
            cbbKojCode.DataBindings.Add("Text", vm, "KojCode", true, DataSourceUpdateMode.OnPropertyChanged);
            txtRyaku.DataBindings.Add("Text", vm, "KojRyaku");

            cbbKojCode.DataSource = vm.cbbKojCode;
            dgvKojData.DataSource = vm.grdKojData;
        }
    }
}
