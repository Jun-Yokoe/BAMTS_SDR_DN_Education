
namespace BAMTS.Internal
{
    partial class FMainMenu
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCall_DisplayListEmployee = new System.Windows.Forms.Button();
            this.btnApplicationExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCall_DisplayListEmployee
            // 
            this.btnCall_DisplayListEmployee.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCall_DisplayListEmployee.ForeColor = System.Drawing.Color.Blue;
            this.btnCall_DisplayListEmployee.Location = new System.Drawing.Point(43, 30);
            this.btnCall_DisplayListEmployee.Name = "btnCall_DisplayListEmployee";
            this.btnCall_DisplayListEmployee.Size = new System.Drawing.Size(716, 71);
            this.btnCall_DisplayListEmployee.TabIndex = 0;
            this.btnCall_DisplayListEmployee.Text = "Call DisplayListEmployee";
            this.btnCall_DisplayListEmployee.UseVisualStyleBackColor = true;
            this.btnCall_DisplayListEmployee.Click += new System.EventHandler(this.btnCall_DisplayListEmployee_Click);
            // 
            // btnApplicationExit
            // 
            this.btnApplicationExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplicationExit.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnApplicationExit.Location = new System.Drawing.Point(43, 347);
            this.btnApplicationExit.Name = "btnApplicationExit";
            this.btnApplicationExit.Size = new System.Drawing.Size(716, 71);
            this.btnApplicationExit.TabIndex = 1;
            this.btnApplicationExit.Text = "Exit Application";
            this.btnApplicationExit.UseVisualStyleBackColor = true;
            this.btnApplicationExit.Click += new System.EventHandler(this.btnApplicationExit_Click);
            // 
            // FMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApplicationExit);
            this.Controls.Add(this.btnCall_DisplayListEmployee);
            this.Name = "FMainMenu";
            this.Text = "BAMTS Internal System Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCall_DisplayListEmployee;
        private System.Windows.Forms.Button btnApplicationExit;
    }
}

