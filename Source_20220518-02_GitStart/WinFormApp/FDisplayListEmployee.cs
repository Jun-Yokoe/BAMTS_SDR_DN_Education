﻿using System;
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
    public partial class FDisplayListEmployee : Form
    {
        //private IDataAccessor _dataAccess = new TextFileAccessor(@"C:\User\Projects\Practice\Education\Test\Data");
        private IDataAccessor _dataAccess = new SQLServerAccessor("Data Source=BAMTS-ISFSERV01;Initial Catalog=BAMTS_DB;Persist Security Info=True;User ID=naitou;Password=naitou");

        public FDisplayListEmployee()
        {
            InitializeComponent();
        }

        private void FDisplayListEmployee_Shown(object sender, EventArgs e)
        {
            this.dgvList.DataSource = this._dataAccess.GetEmployeeAll();
        }

        private void btnFormExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this._dataAccess.UpdateEmployeeAll(this.dgvList.DataSource as IList<RecEmployeeAll>);
                MessageBox.Show("更新が正常に完了しました。", "更新結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"更新処理にて異常が発生しました。({ex.Message})", "更新結果", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}