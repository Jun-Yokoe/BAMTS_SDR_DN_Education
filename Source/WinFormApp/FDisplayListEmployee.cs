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
    public partial class FDisplayListEmployee : Form
    {
        private IDataAccessor _dataAccessor;
        public FDisplayListEmployee(IDataAccessor dataAccessor)
        {
            InitializeComponent();
            this._dataAccessor = dataAccessor;
        }
        private void FDisplayListEmployee_Shown(object sender, EventArgs e)
        {
            this.dgvList.DataSource = this._dataAccessor.GetEmployeeAll();
        }
        private void btnFormExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this._dataAccessor.UpdateEmployeeAll(this.dgvList.DataSource as IList<RecEmployeeAll>);
                MessageBox.Show("更新が正常に完了しました。", "更新結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"更新処理にて異常が発生しました。({ex.Message})", "更新結果", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnDisplayList_Click(object sender, EventArgs e)
        {
            this.dgvList.DataSource = this._dataAccessor.GetEmployeeAll();
        }
    }
}
