
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
            this.components = new System.ComponentModel.Container();
            this.btnListEmployeeCSV = new System.Windows.Forms.Button();
            this.btnApplicationExit = new System.Windows.Forms.Button();
            this.timDisplayTime = new System.Windows.Forms.Timer(this.components);
            this.btnListEmployeeSqlDB = new System.Windows.Forms.Button();
            this.btnListEmployeeWebAPI = new System.Windows.Forms.Button();
            this.btnListEmployeeExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListEmployeeCSV
            // 
            this.btnListEmployeeCSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListEmployeeCSV.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListEmployeeCSV.ForeColor = System.Drawing.Color.Blue;
            this.btnListEmployeeCSV.Location = new System.Drawing.Point(43, 30);
            this.btnListEmployeeCSV.Name = "btnListEmployeeCSV";
            this.btnListEmployeeCSV.Size = new System.Drawing.Size(1077, 71);
            this.btnListEmployeeCSV.TabIndex = 0;
            this.btnListEmployeeCSV.Text = "DisplayListEmployee (CSV)";
            this.btnListEmployeeCSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListEmployeeCSV.UseVisualStyleBackColor = true;
            this.btnListEmployeeCSV.Click += new System.EventHandler(this.btnListEmployeeCSV_Click);
            // 
            // btnApplicationExit
            // 
            this.btnApplicationExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplicationExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplicationExit.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnApplicationExit.Location = new System.Drawing.Point(43, 400);
            this.btnApplicationExit.Name = "btnApplicationExit";
            this.btnApplicationExit.Size = new System.Drawing.Size(1077, 71);
            this.btnApplicationExit.TabIndex = 1;
            this.btnApplicationExit.Text = "Exit Application";
            this.btnApplicationExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApplicationExit.UseVisualStyleBackColor = true;
            this.btnApplicationExit.Click += new System.EventHandler(this.btnApplicationExit_Click);
            // 
            // timDisplayTime
            // 
            this.timDisplayTime.Enabled = true;
            this.timDisplayTime.Interval = 900;
            this.timDisplayTime.Tick += new System.EventHandler(this.timDisplayTime_Tick);
            // 
            // btnListEmployeeSqlDB
            // 
            this.btnListEmployeeSqlDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListEmployeeSqlDB.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListEmployeeSqlDB.ForeColor = System.Drawing.Color.Blue;
            this.btnListEmployeeSqlDB.Location = new System.Drawing.Point(43, 107);
            this.btnListEmployeeSqlDB.Name = "btnListEmployeeSqlDB";
            this.btnListEmployeeSqlDB.Size = new System.Drawing.Size(1077, 71);
            this.btnListEmployeeSqlDB.TabIndex = 2;
            this.btnListEmployeeSqlDB.Text = "DisplayListEmployee (SQLServer)";
            this.btnListEmployeeSqlDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListEmployeeSqlDB.UseVisualStyleBackColor = true;
            this.btnListEmployeeSqlDB.Click += new System.EventHandler(this.btnListEmployeeSqlDB_Click);
            // 
            // btnListEmployeeWebAPI
            // 
            this.btnListEmployeeWebAPI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListEmployeeWebAPI.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListEmployeeWebAPI.ForeColor = System.Drawing.Color.Blue;
            this.btnListEmployeeWebAPI.Location = new System.Drawing.Point(43, 184);
            this.btnListEmployeeWebAPI.Name = "btnListEmployeeWebAPI";
            this.btnListEmployeeWebAPI.Size = new System.Drawing.Size(1077, 71);
            this.btnListEmployeeWebAPI.TabIndex = 3;
            this.btnListEmployeeWebAPI.Text = "DisplayListEmployee (WebAPI)";
            this.btnListEmployeeWebAPI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListEmployeeWebAPI.UseVisualStyleBackColor = true;
            this.btnListEmployeeWebAPI.Click += new System.EventHandler(this.btnListEmployeeWebAPI_Click);
            // 
            // btnListEmployeeExcel
            // 
            this.btnListEmployeeExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListEmployeeExcel.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListEmployeeExcel.ForeColor = System.Drawing.Color.Blue;
            this.btnListEmployeeExcel.Location = new System.Drawing.Point(43, 261);
            this.btnListEmployeeExcel.Name = "btnListEmployeeExcel";
            this.btnListEmployeeExcel.Size = new System.Drawing.Size(1077, 71);
            this.btnListEmployeeExcel.TabIndex = 4;
            this.btnListEmployeeExcel.Text = "DisplayListEmployee (Excel)";
            this.btnListEmployeeExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListEmployeeExcel.UseVisualStyleBackColor = true;
            this.btnListEmployeeExcel.Click += new System.EventHandler(this.btnListEmployeeExcel_Click);
            // 
            // FMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 483);
            this.Controls.Add(this.btnListEmployeeExcel);
            this.Controls.Add(this.btnListEmployeeWebAPI);
            this.Controls.Add(this.btnListEmployeeSqlDB);
            this.Controls.Add(this.btnApplicationExit);
            this.Controls.Add(this.btnListEmployeeCSV);
            this.Name = "FMainMenu";
            this.Text = "BAMTS Internal System Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListEmployeeCSV;
        private System.Windows.Forms.Button btnApplicationExit;
        private System.Windows.Forms.Timer timDisplayTime;
        private System.Windows.Forms.Button btnListEmployeeSqlDB;
        private System.Windows.Forms.Button btnListEmployeeWebAPI;
        private System.Windows.Forms.Button btnListEmployeeExcel;
    }
}

