using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Regions;
using Prism.Services.Dialogs;
using System.Windows;
using System.Timers;

namespace BAMTS.Internal
{
    public class MainWindowViewModel : BindableBase
    {
        public DelegateCommand ShowInformation_Click { get; }
        public DelegateCommand ApplicationExitButton_Click { get; }
        public DelegateCommand DisplayEmployeeGCCsvList_Click { get; }
        public DelegateCommand DisplayEmployeeGCSqlList_Click { get; }
        public DelegateCommand DisplayEmployeeGCWebAPIList_Click { get; }
        public DelegateCommand DisplayEmployeeGCExcelList_Click { get; }
        public DelegateCommand DisplayEmployeeMSCsvList_Click { get; }
        public DelegateCommand DisplayEmployeeMSSqlList_Click { get; }
        public DelegateCommand DisplayEmployeeMSWebAPIList_Click { get; }
        public DelegateCommand DisplayEmployeeMSExcelList_Click { get; }
        public DelegateCommand DisplayMSExcelSheet_Click { get; }
        public int TimerInterval { get; private set; }
        private Timer _timer;
        private DateTime _currentTime = DateTime.Now;
        private readonly IRegionManager _regionManager;
        private readonly IDialogService _dialogService;
        private string _title = "Prism Application";
        private string _displayComment = "";
        private string _regionName = "ContentRegion";
        public string Title
        {
            get { return this._title; }
            set { SetProperty(ref this._title, value); }
        }
        public string DisplayComment
        {
            get { return this._displayComment; }
            set { SetProperty(ref this._displayComment, value); }
        }
        public MainWindowViewModel(IRegionManager regionManager, IDialogService dialogService)
        {
            this.TimerInterval = 1000;
            this._regionManager = regionManager;
            this._dialogService = dialogService;
            this.ShowInformation_Click = new DelegateCommand(this.ShowInformation_Execute);
            this.DisplayEmployeeGCCsvList_Click = new DelegateCommand(this.DisplayEmployeeGCCsvList_Execute);
            this.DisplayEmployeeGCSqlList_Click = new DelegateCommand(this.DisplayEmployeeGCSqlList_Execute);
            this.DisplayEmployeeGCWebAPIList_Click = new DelegateCommand(this.DisplayEmployeeGCWebAPIList_Execute);
            this.DisplayEmployeeGCExcelList_Click = new DelegateCommand(this.DisplayEmployeeGCExcelList_Execute);
            this.DisplayEmployeeMSCsvList_Click = new DelegateCommand(this.DisplayEmployeeMSCsvList_Execute);
            this.DisplayEmployeeMSSqlList_Click = new DelegateCommand(this.DisplayEmployeeMSSqlList_Execute);
            this.DisplayEmployeeMSWebAPIList_Click = new DelegateCommand(this.DisplayEmployeeMSWebAPIList_Execute);
            this.DisplayEmployeeMSExcelList_Click = new DelegateCommand(this.DisplayEmployeeMSExcelList_Execute);
            this.DisplayMSExcelSheet_Click = new DelegateCommand(this.DisplayMSExcelSheet_Execute);
            this.ApplicationExitButton_Click = new DelegateCommand(this.ShutdownApplication_Execute);
        }
        private void ShowInformation_Execute()
        {
            var p = new DialogParameters();
            p.Add(nameof(UCDisplayInfomationViewModel.TextInput), "初期テキスト値");
            this._dialogService.ShowDialog(nameof(UCDisplayInfomation), p, this.Information_Close);
        }
        private void Information_Close(IDialogResult dialogResult)
        {
            if (dialogResult.Result == ButtonResult.OK)
            {
                this.DisplayComment = dialogResult.Parameters.GetValue<string>(nameof(UCDisplayInfomationViewModel.TextInput));
            }
        }
        public DateTime CurrentTime
        {
            get
            {
                if (this._timer == null)
                {
                    this._timer = new Timer(this.TimerInterval);
                    this._timer.Elapsed += (_, __) => { this.CurrentTime = DateTime.Now; };
                    this._timer.Start();
                }
                return this._currentTime;
            }
            private set { SetProperty(ref this._currentTime, value); }
        }
        private void DisplayEmployeeGCCsvList_Execute()
        {
            var param = new NavigationParameters();
            param.Add(UCEmployeeListViewModel.PARAM_KEY_NAME_DataAccessor, new CSVFileAccessor(Common.TARGET_CSV_FILE_PATH));
            this._regionManager.RequestNavigate(this._regionName, nameof(UCGCEmployeeList), param);
        }
        private void DisplayEmployeeGCSqlList_Execute()
        {
            var param = new NavigationParameters();
            param.Add(UCEmployeeListViewModel.PARAM_KEY_NAME_DataAccessor, new SQLServerAccessor(Common.TARGET_DATABASE_CONNECTION_SETTINGS));
            this._regionManager.RequestNavigate(this._regionName, nameof(UCGCEmployeeList), param);
        }
        private void DisplayEmployeeGCWebAPIList_Execute()
        {
            var param = new NavigationParameters();
            param.Add(UCEmployeeListViewModel.PARAM_KEY_NAME_DataAccessor, new WebAPIClientAccessor(Common.TARGET_WEBAPI_HOST, Common.TARGET_WEBAPI_PORTNO, Common.TARGET_WEBAPI_CONTROLLER));
            this._regionManager.RequestNavigate(this._regionName, nameof(UCGCEmployeeList), param);
        }
        private void DisplayEmployeeGCExcelList_Execute()
        {
            var param = new NavigationParameters();
            param.Add(UCEmployeeListViewModel.PARAM_KEY_NAME_DataAccessor, new ExcelFileAccessor(Common.TARGET_EXCEL_FILE_PATH, Common.TARGET_EXCEL_FILE_SHEET));
            this._regionManager.RequestNavigate(this._regionName, nameof(UCGCEmployeeList), param);
        }
        private void DisplayEmployeeMSCsvList_Execute()
        {
            var param = new NavigationParameters();
            param.Add(UCEmployeeListViewModel.PARAM_KEY_NAME_DataAccessor, new CSVFileAccessor(Common.TARGET_CSV_FILE_PATH));
            this._regionManager.RequestNavigate(this._regionName, nameof(UCMSEmployeeList), param);
        }
        private void DisplayEmployeeMSSqlList_Execute()
        {
            var param = new NavigationParameters();
            param.Add(UCEmployeeListViewModel.PARAM_KEY_NAME_DataAccessor, new SQLServerAccessor(Common.TARGET_DATABASE_CONNECTION_SETTINGS));
            this._regionManager.RequestNavigate(this._regionName, nameof(UCMSEmployeeList), param);
        }
        private void DisplayEmployeeMSWebAPIList_Execute()
        {
            var param = new NavigationParameters();
            param.Add(UCEmployeeListViewModel.PARAM_KEY_NAME_DataAccessor, new WebAPIClientAccessor(Common.TARGET_WEBAPI_HOST, Common.TARGET_WEBAPI_PORTNO, Common.TARGET_WEBAPI_CONTROLLER));
            this._regionManager.RequestNavigate(this._regionName, nameof(UCMSEmployeeList), param);
        }
        private void DisplayEmployeeMSExcelList_Execute()
        {
            var param = new NavigationParameters();
            param.Add(UCEmployeeListViewModel.PARAM_KEY_NAME_DataAccessor, new ExcelFileAccessor(Common.TARGET_EXCEL_FILE_PATH, Common.TARGET_EXCEL_FILE_SHEET));
            this._regionManager.RequestNavigate(this._regionName, nameof(UCMSEmployeeList), param);
        }
        private void DisplayMSExcelSheet_Execute()
        {
            this._regionManager.RequestNavigate(this._regionName, nameof(DisplayMSExcelSheet));
        }
        private void ShutdownApplication_Execute()
        {
            Application.Current.Shutdown();
        }
    }
}
