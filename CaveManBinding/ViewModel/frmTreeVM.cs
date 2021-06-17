using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaveManBinding.DbConnection;
using CaveManBinding.Models;

namespace CaveManBinding.ViewModel
{
    public class frmTreeVM : INotifyPropertyChanged
    {
        private List<BmnUwModel> _bmnData;    
        private TreeNode _treeData;
        private string _curentNodeKey;
        private List<KojModel> _kojData;
        private List<KojModel> _grdKoj;
        private string _bmnCode;
        private string _bmnRyaku;

        public event PropertyChangedEventHandler PropertyChanged;

        public string BmnCode
        {
            get { return _bmnCode; }
            set { _bmnCode = value; }
        }

        public string BmnRyaku
        {
            get { return _bmnRyaku; }
            set { _bmnRyaku = value; }
        }

        public TreeNode TreeData
        {
            get { return _treeData; }
        }

        public List<KojModel> GrdKoj
        {
            get { return _grdKoj; }
        }

        public string CurrentNode
        {
            get { return _curentNodeKey; }
            set 
            {
                _curentNodeKey = value;
                
                TreeNodeChanged();
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("CurrentNode"));
            }
        }

        public frmTreeVM()
        {
            using (var ctx = new MyContext())
            {
                _bmnData = ctx.BMN_UW.Select(b => b)
                    .OrderBy(b => b.KAISOU)
                    .ThenBy(b => b.CODE)
                    .ToList();

                _kojData = ctx.KOJ.Select(k => k)
                    .ToList();
            }
            _treeData = PlantingTree();
        }

        public TreeNode PlantingTree()
        {
            var node = new TreeNode();          

            foreach (var bmn in _bmnData)
            {
                var parentKey = bmn.S_BMN_UW;

                var parentNode = node.Nodes.Find(parentKey, true).FirstOrDefault();

                if (parentNode != null) //exists parent's node 
                {
                    //add to parent node
                    parentNode.Nodes.Add(bmn.CODE, bmn.CODE + " " + bmn.RYAKU);
                }
                else
                {
                    //add root node
                    node.Nodes.Add(bmn.CODE, bmn.CODE + " " + bmn.RYAKU);
                }
            }
            return node.FirstNode;
        }

        private void TreeNodeChanged()
        {
            //get Bmn following selected node
            var currentBmn = _bmnData.Where(b => b.CODE == _curentNodeKey).FirstOrDefault();     

            _bmnCode = currentBmn.CODE;
            _bmnRyaku = currentBmn.RYAKU;
            _grdKoj = _kojData.Where(k => k.BMN_UW == _curentNodeKey).ToList();
        }
    }
}
