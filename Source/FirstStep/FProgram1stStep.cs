using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstStep
{
    public partial class FProgram1stStep : Form
    {
        /// <summary>
        /// スコープ：このクラスの内部でのみアクセス可能
        /// 生存期間：このクラスのインスタンスが生存している間
        /// </summary>
        private List<EntryRecord> _entryRecs = new List<EntryRecord>();
        /// <summary>
        /// コンストラクタ
        /// このフォームのインスタンスが生成される時に実行される
        /// </summary>
        public FProgram1stStep()
        {
            this.InitializeComponent();
            this.InitializeControls();
        }
        private void InitializeControls()
        {
            this.cbbWorkingPlace.Items.Add("勝幡城");
            this.cbbWorkingPlace.Items.Add("那古野城");
            this.cbbWorkingPlace.Items.Add("安土城");
            this.cbbWorkingPlace.Items.Add("岐阜城");
            this.cbbWorkingPlace.Items.Add("清洲城");
            this.cbbWorkingPlace.Items.Add("小牧山城");
            this.cbbWorkingPlace.Items.Add("あき竹城");
            this.timDisplayTime.Interval = 900;
            this.timDisplayTime.Enabled = true;
        }
        private void timDisplayTime_Tick(object sender, EventArgs e)
        {
            try
            {
                this.timDisplayTime.Enabled = false;
                this.lblTime.Text = $"{DateTime.Now:yyyy/MM/dd HH:mm:ss}";
            }
            finally
            {
                this.timDisplayTime.Enabled = true;
            }
        }
        private void cbxAnonymous_CheckedChanged(object sender, EventArgs e)
        {
            this.txtName.Enabled = !this.cbxAnonymous.Checked;
            if (this.txtName.Enabled == false) this.txtName.Text = "";
        }
        private void btnEntry_Click(object sender, EventArgs e)
        {
            var inputText = new StringBuilder();
            inputText.Append($"{this.lblEntryDateTitle.Text}:{this.dtpEntryDate.Value:yyyy年MM月dd日}\r\n");
            inputText.Append($"{this.lblWorkingPlaceTitle.Text}:{this.cbbWorkingPlace.Text}\r\n");
            inputText.Append($"{this.lblNameTitle.Text}:{((this.cbxAnonymous.Checked) ? "匿名" : this.txtName.Text)}\r\n");
            inputText.Append($"{this.gbxColor.Text}:{this.GetHelmetText()}\r\n");
            inputText.Append($"{this.lblWeightTitle.Text}:{this.nudWeight.Value}\r\n");
            MessageBox.Show(inputText.ToString(),"入力内容", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private string GetHelmetText()
        {
            if (this.rdbBlue.Checked)
                return this.rdbBlue.Text;
            else if (this.rdbRed.Checked)
                return this.rdbRed.Text;
            else if (this.rdbYellow.Checked)
                return this.rdbYellow.Text;
            else
                return this.rdbGreen.Text;
        }
        private Color GetHelmetColor()
        {
            if (this.rdbBlue.Checked)
                return this.rdbBlue.ForeColor;
            else if (this.rdbRed.Checked)
                return this.rdbRed.ForeColor;
            else if (this.rdbYellow.Checked)
                return this.rdbYellow.ForeColor;
            else
                return this.rdbGreen.ForeColor;
        }
        private void btnHensuu_Click(object sender, EventArgs e)
        {
            this._entryRecs.Add(new EntryRecord(
                this._entryRecs.Count,
                this.dtpEntryDate.Value,
                this.cbbWorkingPlace.Text,
                this.cbxAnonymous.Checked,
                this.txtName.Text,
                this.GetHelmetColor(),
                this.nudWeight.Value
            ));
        }
    }
}
