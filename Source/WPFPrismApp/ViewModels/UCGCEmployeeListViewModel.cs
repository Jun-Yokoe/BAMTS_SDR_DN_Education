using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Regions;

namespace BAMTS.Internal
{
    public class UCGCEmployeeListViewModel : BindableBase, INavigationAware
    {
        private IDataAccessor _dataAccess;
        private string _targetInfoText = "Data Source=BAMTS-ISFSERV01;Initial Catalog=BAMTS_DB;Persist Security Info=True;User ID=naitou;Password=naitou";
        public UCGCEmployeeListViewModel()
        {
            this._dataAccess = new SQLServerAccessor(this._targetInfoText);
        }
        public IList<RecEmployeeAll> EmployeeList
        {
            get { return this._dataAccess.GetEmployeeAll(); }
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return false;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
        }
    }
}
