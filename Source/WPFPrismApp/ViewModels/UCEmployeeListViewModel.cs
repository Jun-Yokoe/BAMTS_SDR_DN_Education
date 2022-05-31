using Prism.Mvvm;
using Prism.Regions;
using Prism.Commands;
using System.Collections.Generic;
using System;
using System.Windows;

namespace BAMTS.Internal
{
    public abstract class UCEmployeeListViewModel : BindableBase, INavigationAware, IConfirmNavigationRequest
    {
        public static string PARAM_KEY_NAME_DataAccessor = "DataAccessor";
        public DelegateCommand DisplayEmployeeList_Click { get; private set; }
        public DelegateCommand UpdateEmployeeList_Click { get; private set; }
        private IDataAccessor _dataAccessor;
        private IList<RecEmployeeAll> _dataList = new List<RecEmployeeAll>();
        private IMessageService _messageService;
        /// <summary>
        /// 実稼働用コンストラクタ
        /// </summary>
        public UCEmployeeListViewModel()
        {
            this.InitializeMe();
            this._messageService = new MessageService();
        }
        /// <summary>
        /// MOC用コンストラクタ
        /// </summary>
        /// <param name="messageService"></param>
        public UCEmployeeListViewModel(IDataAccessor dataAccessor, IMessageService messageService)
        {
            this.InitializeMe();
            this._messageService = messageService;
            this._dataAccessor = dataAccessor;
            this.EmployeeList = this._dataAccessor.GetEmployeeAll();
        }
        private void InitializeMe()
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
                this._messageService.Show($"社員リストの更新処理にて異常が発生しました。{ex.Message}/{ex.InnerException?.Message ?? ""}", "異常発生", MessageBoxButton.OK, MessageBoxImage.Exclamation);
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
        public void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback)
        {
            var ans = this._messageService.Show($"この画面を終了しても宜しいですか？", "終了確認", MessageBoxButton.OKCancel, MessageBoxImage.Question, MessageBoxResult.Cancel);
            if (ans == MessageBoxResult.OK) continuationCallback(true);
        }
    }
}
