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
        private IDataAccessor _dataAccess = new TextFileAccessor(@"C:\User\Projects\Practice\Education\Test\Data");

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
            this._dataAccess.UpdateEmployeeAll(this.dgvList.DataSource as IList<RecEmployeeAll>);
        }
    }
}
