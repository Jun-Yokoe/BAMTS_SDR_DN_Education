using Prism.Mvvm;
using Prism.Regions;
using Prism.Commands;
using System.Collections.Generic;
using System;

namespace BAMTS.Internal
{
    public abstract class UCEmployeeListViewModel : BindableBase, INavigationAware
    {
        public static string PARAM_KEY_NAME_DataAccessor = "DataAccessor";
        public DelegateCommand DisplayEmployeeList_Click { get; }
        public DelegateCommand UpdateEmployeeList_Click { get; }
        private IDataAccessor _dataAccessor;
        private IList<RecEmployeeAll> _dataList = new List<RecEmployeeAll>();
        public UCEmployeeListViewModel() 
        {
            this.DisplayEmployeeList_Click = new DelegateCommand(this.DisplayEmployeeList_Execute);
            this.UpdateEmployeeList_Click = new DelegateCommand(this.UpdateEmployeeList_Execute);
        }
        public IList<RecEmployeeAll> EmployeeList
        {
            get { return this._dataList; }
            private set { SetProperty(ref this._dataList, value); }
        }
        private void DisplayEmployeeList_Execute()
        {
            this.EmployeeList = this._dataAccessor.GetEmployeeAll();
        }
        private void UpdateEmployeeList_Execute()
        {
            try
            {
                this._dataAccessor.UpdateEmployeeAll(this.EmployeeList as IList<RecEmployeeAll>);
            }
            catch (Exception ex)
            {
                throw;
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
