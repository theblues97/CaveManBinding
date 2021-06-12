using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CaveManBinding.DbConnection;
using CaveManBinding.Models;

namespace CaveManBinding.ViewModel
{
    class frmMainVM: INotifyPropertyChanged
    {
        private List<KojModel> _kojData;       

        private string _kojCode;
        private string _kojRyaku;

        #region Properties
        public string KojCode
        {
            get { return _kojCode; }
            set
            {
                _kojCode = value;
                KojCodeChanged();
                //OnPropertyChanged("KojCode");
            }
        }
        public string KojRyaku
        {
            get { return _kojRyaku; }
            set
            {
                _kojRyaku = value;
                //OnPropertyChanged("KojCode"); 
            }
        }
        public List<KojModel> grdKojData
        {
            get { return _kojData; }
            set { _kojData = value; }
        }
        public List<string> cbbKojCode
        {
            get { return _kojData.Select(k => k.CODE).ToList(); }
        }
        #endregion

        public frmMainVM()
        {
            using (var ctx = new MyContext())
            {
                _kojData = ctx.KOJ.Select(k => k).ToList();
            }
        }
        public void KojCodeChanged()
        {
            var rs = _kojData.Where(k => k.CODE == _kojCode).FirstOrDefault();
            _kojRyaku = rs.RYAKU;
        }     

        public event PropertyChangedEventHandler PropertyChanged;

        //protected virtual void OnPropertyChanged(string property) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        private void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            //KojCodeChanged();
        }
    }
}
