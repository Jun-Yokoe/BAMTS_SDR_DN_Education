using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAMTS.Internal
{
    public partial class FMainMenu : Form
    {
        public FMainMenu()
        {
            InitializeComponent();
        }
        private void btnApplicationExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("アプリケーションを終了しても宜しいですか？", "終了確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Application.Exit();
        }
        private void ShowEmployeeList(IDataAccessor dataAccessor)
        {
            using (var f = new FDisplayListEmployee(dataAccessor)){ f.ShowDialog(this); }
        }
        private void timDisplayTime_Tick(object sender, EventArgs e) => this.Text = $"BAMTS Internal System Menu ({DateTime.Now:yyyy/MM/dd HH:mm:ss})";
        private void btnListEmployeeCSV_Click(object sender, EventArgs e) => this.ShowEmployeeList(new CSVFileAccessor(Common.TARGET_CSV_FILE_PATH));
        private void btnListEmployeeSqlDB_Click(object sender, EventArgs e) => this.ShowEmployeeList(new SQLServerAccessor(Common.TARGET_DATABASE_CONNECTION_SETTINGS));
        private void btnListEmployeeWebAPI_Click(object sender, EventArgs e) => this.ShowEmployeeList(new WebAPIClientAccessor(Common.TARGET_WEBAPI_HOST, Common.TARGET_WEBAPI_PORTNO, Common.TARGET_WEBAPI_CONTROLLER));
        private void btnListEmployeeExcel_Click(object sender, EventArgs e) => this.ShowEmployeeList(new ExcelFileAccessor(Common.TARGET_EXCEL_FILE_PATH, Common.TARGET_EXCEL_FILE_SHEET));
    }
}
