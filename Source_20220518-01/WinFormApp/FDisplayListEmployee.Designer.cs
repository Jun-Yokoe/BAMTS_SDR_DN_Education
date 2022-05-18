
namespace BAMTS.Internal
{
    partial class FDisplayListEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnFormExit = new System.Windows.Forms.Button();
            this.btnDisplayList = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.eMPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIRTHDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOINEDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSEDPAIDHOLIDAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cELLPHONENODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cELLPHONEMAILADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCMAILADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCMAILPASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recEmployeeAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recEmployeeAllBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFormExit
            // 
            this.btnFormExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormExit.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnFormExit.Location = new System.Drawing.Point(664, 391);
            this.btnFormExit.Name = "btnFormExit";
            this.btnFormExit.Size = new System.Drawing.Size(124, 47);
            this.btnFormExit.TabIndex = 2;
            this.btnFormExit.Text = "Exit";
            this.btnFormExit.UseVisualStyleBackColor = true;
            this.btnFormExit.Click += new System.EventHandler(this.btnFormExit_Click);
            // 
            // btnDisplayList
            // 
            this.btnDisplayList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplayList.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayList.ForeColor = System.Drawing.Color.Blue;
            this.btnDisplayList.Location = new System.Drawing.Point(664, 12);
            this.btnDisplayList.Name = "btnDisplayList";
            this.btnDisplayList.Size = new System.Drawing.Size(124, 47);
            this.btnDisplayList.TabIndex = 3;
            this.btnDisplayList.Text = "表示";
            this.btnDisplayList.UseVisualStyleBackColor = true;
            // 
            // dgvList
            // 
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPIDDataGridViewTextBoxColumn,
            this.eMPNAMEDataGridViewTextBoxColumn,
            this.bIRTHDATEDataGridViewTextBoxColumn,
            this.jOINEDDATEDataGridViewTextBoxColumn,
            this.uSEDPAIDHOLIDAYDataGridViewTextBoxColumn,
            this.gENDERDataGridViewTextBoxColumn,
            this.cELLPHONENODataGridViewTextBoxColumn,
            this.cELLPHONEMAILADDRESSDataGridViewTextBoxColumn,
            this.pCMAILADDRESSDataGridViewTextBoxColumn,
            this.pCMAILPASSWORDDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.recEmployeeAllBindingSource;
            this.dgvList.Location = new System.Drawing.Point(12, 65);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 21;
            this.dgvList.Size = new System.Drawing.Size(776, 320);
            this.dgvList.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.Location = new System.Drawing.Point(12, 391);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 47);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // eMPIDDataGridViewTextBoxColumn
            // 
            this.eMPIDDataGridViewTextBoxColumn.DataPropertyName = "EMP_ID";
            this.eMPIDDataGridViewTextBoxColumn.HeaderText = "社員ID";
            this.eMPIDDataGridViewTextBoxColumn.Name = "eMPIDDataGridViewTextBoxColumn";
            // 
            // eMPNAMEDataGridViewTextBoxColumn
            // 
            this.eMPNAMEDataGridViewTextBoxColumn.DataPropertyName = "EMP_NAME";
            this.eMPNAMEDataGridViewTextBoxColumn.HeaderText = "社員名";
            this.eMPNAMEDataGridViewTextBoxColumn.Name = "eMPNAMEDataGridViewTextBoxColumn";
            // 
            // bIRTHDATEDataGridViewTextBoxColumn
            // 
            this.bIRTHDATEDataGridViewTextBoxColumn.DataPropertyName = "BIRTH_DATE";
            this.bIRTHDATEDataGridViewTextBoxColumn.HeaderText = "生年月日";
            this.bIRTHDATEDataGridViewTextBoxColumn.Name = "bIRTHDATEDataGridViewTextBoxColumn";
            // 
            // jOINEDDATEDataGridViewTextBoxColumn
            // 
            this.jOINEDDATEDataGridViewTextBoxColumn.DataPropertyName = "JOINED_DATE";
            this.jOINEDDATEDataGridViewTextBoxColumn.HeaderText = "入社年月日";
            this.jOINEDDATEDataGridViewTextBoxColumn.Name = "jOINEDDATEDataGridViewTextBoxColumn";
            // 
            // uSEDPAIDHOLIDAYDataGridViewTextBoxColumn
            // 
            this.uSEDPAIDHOLIDAYDataGridViewTextBoxColumn.DataPropertyName = "USED_PAID_HOLIDAY";
            this.uSEDPAIDHOLIDAYDataGridViewTextBoxColumn.HeaderText = "有給消費日数";
            this.uSEDPAIDHOLIDAYDataGridViewTextBoxColumn.Name = "uSEDPAIDHOLIDAYDataGridViewTextBoxColumn";
            // 
            // gENDERDataGridViewTextBoxColumn
            // 
            this.gENDERDataGridViewTextBoxColumn.DataPropertyName = "GENDER";
            this.gENDERDataGridViewTextBoxColumn.HeaderText = "性別";
            this.gENDERDataGridViewTextBoxColumn.Name = "gENDERDataGridViewTextBoxColumn";
            // 
            // cELLPHONENODataGridViewTextBoxColumn
            // 
            this.cELLPHONENODataGridViewTextBoxColumn.DataPropertyName = "CELLPHONE_NO";
            this.cELLPHONENODataGridViewTextBoxColumn.HeaderText = "携帯電話番号";
            this.cELLPHONENODataGridViewTextBoxColumn.Name = "cELLPHONENODataGridViewTextBoxColumn";
            // 
            // cELLPHONEMAILADDRESSDataGridViewTextBoxColumn
            // 
            this.cELLPHONEMAILADDRESSDataGridViewTextBoxColumn.DataPropertyName = "CELLPHONE_MAIL_ADDRESS";
            this.cELLPHONEMAILADDRESSDataGridViewTextBoxColumn.HeaderText = "携帯電話メールアドレス";
            this.cELLPHONEMAILADDRESSDataGridViewTextBoxColumn.Name = "cELLPHONEMAILADDRESSDataGridViewTextBoxColumn";
            // 
            // pCMAILADDRESSDataGridViewTextBoxColumn
            // 
            this.pCMAILADDRESSDataGridViewTextBoxColumn.DataPropertyName = "PC_MAIL_ADDRESS";
            this.pCMAILADDRESSDataGridViewTextBoxColumn.HeaderText = "PCメールアドレス";
            this.pCMAILADDRESSDataGridViewTextBoxColumn.Name = "pCMAILADDRESSDataGridViewTextBoxColumn";
            // 
            // pCMAILPASSWORDDataGridViewTextBoxColumn
            // 
            this.pCMAILPASSWORDDataGridViewTextBoxColumn.DataPropertyName = "PC_MAIL_PASSWORD";
            this.pCMAILPASSWORDDataGridViewTextBoxColumn.HeaderText = "PCメールパスワード";
            this.pCMAILPASSWORDDataGridViewTextBoxColumn.Name = "pCMAILPASSWORDDataGridViewTextBoxColumn";
            // 
            // nOTEDataGridViewTextBoxColumn
            // 
            this.nOTEDataGridViewTextBoxColumn.DataPropertyName = "NOTE";
            this.nOTEDataGridViewTextBoxColumn.HeaderText = "備考";
            this.nOTEDataGridViewTextBoxColumn.Name = "nOTEDataGridViewTextBoxColumn";
            // 
            // recEmployeeAllBindingSource
            // 
            this.recEmployeeAllBindingSource.DataSource = typeof(BAMTS.Internal.RecEmployeeAll);
            // 
            // FDisplayListEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btnDisplayList);
            this.Controls.Add(this.btnFormExit);
            this.Name = "FDisplayListEmployee";
            this.Text = "BAMTS Internal System (Display List of Employee)";
            this.Shown += new System.EventHandler(this.FDisplayListEmployee_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recEmployeeAllBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormExit;
        private System.Windows.Forms.Button btnDisplayList;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIRTHDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOINEDDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSEDPAIDHOLIDAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gENDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cELLPHONENODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cELLPHONEMAILADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCMAILADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCMAILPASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource recEmployeeAllBindingSource;
        private System.Windows.Forms.Button btnUpdate;
    }
}