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
        private EDataStrage _dataStrage = EDataStrage.Database;
        //private string targetInfoText = @"C:\User\Projects\Practice\Education\Test\Data";
        private string _targetInfoText = "Data Source=BAMTS-ISFSERV01;Initial Catalog=BAMTS_DB;Persist Security Info=True;User ID=naitou;Password=naitou";
        public FMainMenu()
        {
            InitializeComponent();
        }
        private void btnApplicationExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("アプリケーションを終了しても宜しいですか？", "終了確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnCall_DisplayListEmployee_Click(object sender, EventArgs e)
        {
            using (var f = new FDisplayListEmployee(this._dataStrage, this._targetInfoText))
            {
                f.ShowDialog(this);
            }
        }
        private void timDisplayTime_Tick(object sender, EventArgs e)
        {
            this.Text = $"BAMTS Internal System Menu ({DateTime.Now:yyyy/MM/dd HH:mm:ss})";
        }
    }
}
