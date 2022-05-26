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
        public DelegateCommand ApplicationExitButton_Click { get; }
        public DelegateCommand DisplayEmployeeList_Click { get; }
        private Timer _timer;
        private DateTime _currentTime = DateTime.Now;
        public int TimerInterval { get; private set; }
        private readonly IRegionManager _regionManager;
        private string _title = "Prism Application";
        private void DisplayEmployeeListExecute()
        {
            this._regionManager.RequestNavigate("ContentRegion", nameof(UCEmployeeListViewModel));
        }
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public MainWindowViewModel(IRegionManager regionManager)
        {
            this.TimerInterval = 1000;
            this._regionManager = regionManager;
            this.DisplayEmployeeList_Click = new DelegateCommand(this.DisplayEmployeeListExecute);
            this.ApplicationExitButton_Click = new DelegateCommand(this.ShutdownApplication);
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
        private void ShutdownApplication()
        {
            Application.Current.Shutdown();
        }
    }
}
