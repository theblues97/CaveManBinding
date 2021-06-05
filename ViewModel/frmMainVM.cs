using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbConnection;
using Models;

namespace ViewModel
{
    public class frmMainVM
    {
        public frmMainVM()
        {
            var ctx = new MyContext();
            var koj = ctx.M_KOJ;
            var result = koj.Select(k => k);
        }
    }
}
