using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BAMTS.Internal;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace XamarinPrismApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private bool _updateButtonEnabled = true;
        public DelegateCommand UpdateButton_Click { get; }
        public DelegateCommand DisplayButton_Click { get; }
        private IList<RecEmployeeAll> _dataList = new List<RecEmployeeAll>();
        public bool UpdateButtonEnabled
        {
            get { return this._updateButtonEnabled; }
            set { SetProperty(ref this._updateButtonEnabled, value); }
        }
        private void UpdateButton_Execute()
        {
            try
            {
                this.UpdateButtonEnabled = false;
                if (this._dataList.Count > 0)
                {
                    var dataList = new List<RecEmployeeAll>();
                    dataList.AddRange(this._dataList);
                    dataList.RemoveAt(0);
                    this.EmployeeList = dataList;
                }
            }
            finally
            {
                this.UpdateButtonEnabled = (this._dataList.Count > 0);
            }
        }
        private async void DisplayButton_ExecuteAsync()
        {
            IList<RecEmployeeAll> dataList = null;
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("http://192.168.1.12:1486/api/DatabaseAccessController/GetEmployeeAll");
            if (response != null)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                dataList = JsonConvert.DeserializeObject<IList<RecEmployeeAll>>(json);
                this.EmployeeList = dataList;
                this.UpdateButtonEnabled = (this._dataList.Count > 0);
            }
        }
        private void DisplayButton_Execute()
        {
            IList<RecEmployeeAll> dataList = null;
            HttpClient client = new HttpClient();
            var response = client.GetAsync("http://192.168.1.12:1486/api/DatabaseAccessController/GetEmployeeAll").GetAwaiter().GetResult();
            if (response != null)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                dataList = JsonConvert.DeserializeObject<IList<RecEmployeeAll>>(json);
                this.EmployeeList = dataList;
                this.UpdateButtonEnabled = (this._dataList.Count > 0);
            }
        }
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            this.UpdateButton_Click = new DelegateCommand(this.UpdateButton_Execute);
            this.DisplayButton_Click = new DelegateCommand(this.DisplayButton_Execute);
            this._dataList.Add(new RecEmployeeAll(new List<string>() { "00001", "森谷　正史", "1966/01/01", "2000/01/01", "0", "1", "090-1111-2222", "moritani-cp@bamts.ne.jp", "moritani-pc@bamts.co.jp", "passpass", "社長" }));
            this._dataList.Add(new RecEmployeeAll(new List<string>() { "00002", "松田　将秀", "1986/01/01", "2000/01/01", "0", "1", "090-1111-2222", "matsuda-cp@bamts.ne.jp", "matsuda-pc@bamts.co.jp", "passpass", "Superアルバイト" }));
            this._dataList.Add(new RecEmployeeAll(new List<string>() { "00003", "北村　順子", "1960/02/22", "2002/01/01", "0", "1", "090-1111-2222", "kitamura-cp@bamts.ne.jp", "kitamura-pc@bamts.co.jp", "passpass", "部長" }));
            this._dataList.Add(new RecEmployeeAll(new List<string>() { "00004", "横山　真理子", "1960/02/22", "2002/01/01", "0", "1", "090-1111-2222", "kitamura-cp@bamts.ne.jp", "kitamura-pc@bamts.co.jp", "passpass", "部長" }));
            this._dataList.Add(new RecEmployeeAll(new List<string>() { "00005", "西田　文彦", "1960/02/22", "2002/01/01", "0", "1", "090-1111-2222", "kitamura-cp@bamts.ne.jp", "kitamura-pc@bamts.co.jp", "passpass", "部長" }));
            this._dataList.Add(new RecEmployeeAll(new List<string>() { "00006", "内藤　光治", "1960/02/22", "2002/01/01", "0", "1", "090-1111-2222", "kitamura-cp@bamts.ne.jp", "kitamura-pc@bamts.co.jp", "passpass", "部長" }));
            this._dataList.Add(new RecEmployeeAll(new List<string>() { "00007", "横江　純", "1960/02/22", "1972/08/13", "0", "1", "090-1111-2222", "kitamura-cp@bamts.ne.jp", "kitamura-pc@bamts.co.jp", "passpass", "部長" }));
            this.EmployeeList = this._dataList;
        }
        public IList<RecEmployeeAll> EmployeeList
        {
            get { return this._dataList; }
            private set { SetProperty(ref this._dataList, value); }
        }
    }
}
