using Prism.Mvvm;
using Prism.Regions;
using System.Collections.Generic;

namespace BAMTS.Internal
{
    public class UCEmployeeListViewModel : BindableBase, INavigationAware
    {
        public static string PARAM_KEY_NAME_DataAccessor = "DataAccessor";
        private IDataAccessor _dataAccessor;
        private IList<RecEmployeeAll> _dataList = new List<RecEmployeeAll>();
        public IList<RecEmployeeAll> EmployeeList
        {
            get { return this._dataList; }
            private set 
            {
                SetProperty(ref this._dataList, value);
            }
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
            this._dataAccessor = (IDataAccessor)navigationContext.Parameters.GetValue<IDataAccessor>(UCEmployeeListViewModel.PARAM_KEY_NAME_DataAccessor);
            this.EmployeeList = this._dataAccessor.GetEmployeeAll();
        }
    }
}
