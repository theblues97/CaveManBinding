using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaveManBinding.ViewModel;

namespace CaveManBinding
{
    public partial class frmTree : Form
    {
        private frmTreeVM vm;
        public frmTree()
        {
            InitializeComponent();
        }

        private void frmTree_Load(object sender, EventArgs e)
        {
            vm = new frmTreeVM();
            tvwMenu.Nodes.Add(vm.TreeData);
        }
    }
}
