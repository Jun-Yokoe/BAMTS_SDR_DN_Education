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
            {
                Application.Exit();
            }
        }
        private void btnCall_DisplayListEmployee_Click(object sender, EventArgs e)
        {
            using (var f = new FDisplayListEmployee())
            {
                f.ShowDialog(this);
            }
        }
    }
}
