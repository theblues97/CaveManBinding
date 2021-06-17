﻿using System;
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

            tvwMenu.DataBindings.Add("SelectedNode", vm, "CurrentNode", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBmnCode.DataBindings.Add("Text", vm, "BmnCode");
            txtBmnRyaku.DataBindings.Add("Text", vm, "BmnRyaku");
            dgvKoj.DataBindings.Add(nameof(dgvKoj.DataSource), vm, nameof(vm.GrdKoj));

            tvwMenu.Nodes.Add(vm.TreeData);
            vm.CurrentNode = vm.TreeData;
        }

        private void tvwMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //txtBmnRyaku.DataBindings.Clear();
            //dgvKoj.DataBindings.Clear();
            //txtBmnRyaku.DataBindings.Add("Text", vm, "BmnRyaku");
            //dgvKoj.DataBindings.Add(nameof(dgvKoj.DataSource), vm, nameof(vm.GrdKoj));
            vm.CurrentNode = tvwMenu.SelectedNode;
            
        }
    }
}
