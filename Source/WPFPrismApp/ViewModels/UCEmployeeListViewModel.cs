using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BAMTS.Internal
{
    public class UCEmployeeListViewModel : BindableBase
    {
        private IDataAccessor _dataAccess;
        private string _targetInfoText = "Data Source=BAMTS-ISFSERV01;Initial Catalog=BAMTS_DB;Persist Security Info=True;User ID=naitou;Password=naitou";
        public UCEmployeeListViewModel()
        {
            this._dataAccess = new SQLServerAccessor(this._targetInfoText);
        }
        public IList<RecEmployeeAll> EmployeeList
        {
            get { return this._dataAccess.GetEmployeeAll(); }
        }
    }
}
