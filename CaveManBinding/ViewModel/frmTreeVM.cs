using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaveManBinding.DbConnection;
using CaveManBinding.Models;

namespace CaveManBinding.ViewModel
{
    public class frmTreeVM
    {
        private List<BmnUwModel> _bmnData;
        private TreeNode _treeData;

        public TreeNode TreeData
        {
            get { return _treeData; }
        }

        public frmTreeVM()
        {
            using (var ctx = new MyContext())
            {
                _bmnData = ctx.BMN_UW.Select(b => b).ToList();
            }
            _treeData = PlantingTree();
        }

        public TreeNode PlantingTree()
        {
            var node = new TreeNode();

            //foreach (var yosan in _bmnData)
            //{
            //    switch (yosan.KAISOU_KBN)
            //    {
            //        case 0:
            //            node0 = node.Nodes.Add(yosan.YOSAN_GNO, yosan.NAME);
            //            break;
            //        case 1:
            //            node1 = node0.Nodes.Add(yosan.YOSAN_GNO, yosan.NAME);
            //            break;
            //        case 2:
            //            node2 = node1.Nodes.Add(yosan.YOSAN_GNO, yosan.NAME);
            //            break;
            //        case 3:
            //            node3 = node2.Nodes.Add(yosan.YOSAN_GNO, yosan.NAME);
            //            break;
            //        case 4:
            //            node4 = node3.Nodes.Add(yosan.YOSAN_GNO, yosan.NAME);
            //            break;
            //        case 5:
            //            node4.Nodes.Add(yosan.YOSAN_GNO, yosan.NAME);
            //            break;
            //        default:
            //            break;
            //    }
            //}
            return node;
        }
    }
}
