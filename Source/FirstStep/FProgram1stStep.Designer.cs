
namespace FirstStep
{
    partial class FProgram1stStep
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
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.timDisplayTime = new System.Windows.Forms.Timer(this.components);
            this.rdbBlue = new System.Windows.Forms.RadioButton();
            this.cbxAnonymous = new System.Windows.Forms.CheckBox();
            this.cbbWorkingPlace = new System.Windows.Forms.ComboBox();
            this.gbxColor = new System.Windows.Forms.GroupBox();
            this.rdbGreen = new System.Windows.Forms.RadioButton();
            this.rdbYellow = new System.Windows.Forms.RadioButton();
            this.rdbRed = new System.Windows.Forms.RadioButton();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.lblEntryDateTitle = new System.Windows.Forms.Label();
            this.lblWorkingPlaceTitle = new System.Windows.Forms.Label();
            this.gpbFormCntorols = new System.Windows.Forms.GroupBox();
            this.lblWeightUnit = new System.Windows.Forms.Label();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.lblWeightTitle = new System.Windows.Forms.Label();
            this.btnEntry = new System.Windows.Forms.Button();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.gpbHensuu = new System.Windows.Forms.GroupBox();
            this.btnHensuu = new System.Windows.Forms.Button();
            this.gbxColor.SuspendLayout();
            this.gpbFormCntorols.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.gpbHensuu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.BackColor = System.Drawing.Color.OliveDrab;
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFormTitle.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblFormTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFormTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(1452, 136);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "プログラミング　First Step";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtName.Location = new System.Drawing.Point(198, 262);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(332, 43);
            this.txtName.TabIndex = 2;
            // 
            // timDisplayTime
            // 
            this.timDisplayTime.Tick += new System.EventHandler(this.timDisplayTime_Tick);
            // 
            // rdbBlue
            // 
            this.rdbBlue.AutoSize = true;
            this.rdbBlue.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbBlue.ForeColor = System.Drawing.Color.Blue;
            this.rdbBlue.Location = new System.Drawing.Point(31, 62);
            this.rdbBlue.Margin = new System.Windows.Forms.Padding(5);
            this.rdbBlue.Name = "rdbBlue";
            this.rdbBlue.Size = new System.Drawing.Size(112, 40);
            this.rdbBlue.TabIndex = 3;
            this.rdbBlue.TabStop = true;
            this.rdbBlue.Text = "Blue";
            this.rdbBlue.UseVisualStyleBackColor = true;
            // 
            // cbxAnonymous
            // 
            this.cbxAnonymous.AutoSize = true;
            this.cbxAnonymous.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbxAnonymous.Location = new System.Drawing.Point(32, 201);
            this.cbxAnonymous.Margin = new System.Windows.Forms.Padding(5);
            this.cbxAnonymous.Name = "cbxAnonymous";
            this.cbxAnonymous.Size = new System.Drawing.Size(185, 40);
            this.cbxAnonymous.TabIndex = 4;
            this.cbxAnonymous.Text = "匿名希望";
            this.cbxAnonymous.UseVisualStyleBackColor = true;
            this.cbxAnonymous.CheckedChanged += new System.EventHandler(this.cbxAnonymous_CheckedChanged);
            // 
            // cbbWorkingPlace
            // 
            this.cbbWorkingPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWorkingPlace.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbbWorkingPlace.FormattingEnabled = true;
            this.cbbWorkingPlace.Location = new System.Drawing.Point(198, 121);
            this.cbbWorkingPlace.Margin = new System.Windows.Forms.Padding(5);
            this.cbbWorkingPlace.Name = "cbbWorkingPlace";
            this.cbbWorkingPlace.Size = new System.Drawing.Size(332, 44);
            this.cbbWorkingPlace.TabIndex = 5;
            // 
            // gbxColor
            // 
            this.gbxColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbxColor.Controls.Add(this.rdbGreen);
            this.gbxColor.Controls.Add(this.rdbYellow);
            this.gbxColor.Controls.Add(this.rdbRed);
            this.gbxColor.Controls.Add(this.rdbBlue);
            this.gbxColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxColor.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gbxColor.Location = new System.Drawing.Point(855, 42);
            this.gbxColor.Name = "gbxColor";
            this.gbxColor.Size = new System.Drawing.Size(570, 140);
            this.gbxColor.TabIndex = 6;
            this.gbxColor.TabStop = false;
            this.gbxColor.Text = "希望のヘルメット";
            // 
            // rdbGreen
            // 
            this.rdbGreen.AutoSize = true;
            this.rdbGreen.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbGreen.ForeColor = System.Drawing.Color.Lime;
            this.rdbGreen.Location = new System.Drawing.Point(415, 62);
            this.rdbGreen.Margin = new System.Windows.Forms.Padding(5);
            this.rdbGreen.Name = "rdbGreen";
            this.rdbGreen.Size = new System.Drawing.Size(130, 40);
            this.rdbGreen.TabIndex = 6;
            this.rdbGreen.TabStop = true;
            this.rdbGreen.Text = "Green";
            this.rdbGreen.UseVisualStyleBackColor = true;
            // 
            // rdbYellow
            // 
            this.rdbYellow.AutoSize = true;
            this.rdbYellow.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbYellow.ForeColor = System.Drawing.Color.Yellow;
            this.rdbYellow.Location = new System.Drawing.Point(257, 62);
            this.rdbYellow.Margin = new System.Windows.Forms.Padding(5);
            this.rdbYellow.Name = "rdbYellow";
            this.rdbYellow.Size = new System.Drawing.Size(148, 40);
            this.rdbYellow.TabIndex = 5;
            this.rdbYellow.TabStop = true;
            this.rdbYellow.Text = "Yellow";
            this.rdbYellow.UseVisualStyleBackColor = true;
            // 
            // rdbRed
            // 
            this.rdbRed.AutoSize = true;
            this.rdbRed.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdbRed.ForeColor = System.Drawing.Color.Red;
            this.rdbRed.Location = new System.Drawing.Point(153, 62);
            this.rdbRed.Margin = new System.Windows.Forms.Padding(5);
            this.rdbRed.Name = "rdbRed";
            this.rdbRed.Size = new System.Drawing.Size(94, 40);
            this.rdbRed.TabIndex = 4;
            this.rdbRed.TabStop = true;
            this.rdbRed.Text = "Red";
            this.rdbRed.UseVisualStyleBackColor = true;
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.CalendarFont = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpEntryDate.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpEntryDate.Location = new System.Drawing.Point(198, 60);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(332, 43);
            this.dtpEntryDate.TabIndex = 7;
            // 
            // lblEntryDateTitle
            // 
            this.lblEntryDateTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblEntryDateTitle.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryDateTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEntryDateTitle.Location = new System.Drawing.Point(25, 58);
            this.lblEntryDateTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEntryDateTitle.Name = "lblEntryDateTitle";
            this.lblEntryDateTitle.Size = new System.Drawing.Size(155, 50);
            this.lblEntryDateTitle.TabIndex = 8;
            this.lblEntryDateTitle.Text = "登録日";
            this.lblEntryDateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWorkingPlaceTitle
            // 
            this.lblWorkingPlaceTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblWorkingPlaceTitle.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingPlaceTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblWorkingPlaceTitle.Location = new System.Drawing.Point(25, 117);
            this.lblWorkingPlaceTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWorkingPlaceTitle.Name = "lblWorkingPlaceTitle";
            this.lblWorkingPlaceTitle.Size = new System.Drawing.Size(166, 50);
            this.lblWorkingPlaceTitle.TabIndex = 9;
            this.lblWorkingPlaceTitle.Text = "勤務地";
            this.lblWorkingPlaceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gpbFormCntorols
            // 
            this.gpbFormCntorols.Controls.Add(this.lblWeightUnit);
            this.gpbFormCntorols.Controls.Add(this.nudWeight);
            this.gpbFormCntorols.Controls.Add(this.lblWeightTitle);
            this.gpbFormCntorols.Controls.Add(this.btnEntry);
            this.gpbFormCntorols.Controls.Add(this.lblNameTitle);
            this.gpbFormCntorols.Controls.Add(this.lblEntryDateTitle);
            this.gpbFormCntorols.Controls.Add(this.gbxColor);
            this.gpbFormCntorols.Controls.Add(this.lblWorkingPlaceTitle);
            this.gpbFormCntorols.Controls.Add(this.cbxAnonymous);
            this.gpbFormCntorols.Controls.Add(this.txtName);
            this.gpbFormCntorols.Controls.Add(this.cbbWorkingPlace);
            this.gpbFormCntorols.Controls.Add(this.dtpEntryDate);
            this.gpbFormCntorols.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbFormCntorols.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gpbFormCntorols.Location = new System.Drawing.Point(0, 136);
            this.gpbFormCntorols.Name = "gpbFormCntorols";
            this.gpbFormCntorols.Size = new System.Drawing.Size(1452, 328);
            this.gpbFormCntorols.TabIndex = 10;
            this.gpbFormCntorols.TabStop = false;
            this.gpbFormCntorols.Text = "画面の要素";
            // 
            // lblWeightUnit
            // 
            this.lblWeightUnit.BackColor = System.Drawing.SystemColors.Control;
            this.lblWeightUnit.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightUnit.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblWeightUnit.Location = new System.Drawing.Point(879, 258);
            this.lblWeightUnit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWeightUnit.Name = "lblWeightUnit";
            this.lblWeightUnit.Size = new System.Drawing.Size(59, 50);
            this.lblWeightUnit.TabIndex = 14;
            this.lblWeightUnit.Text = "Kg";
            this.lblWeightUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudWeight
            // 
            this.nudWeight.DecimalPlaces = 2;
            this.nudWeight.Location = new System.Drawing.Point(693, 263);
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(180, 43);
            this.nudWeight.TabIndex = 13;
            this.nudWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblWeightTitle
            // 
            this.lblWeightTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblWeightTitle.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblWeightTitle.Location = new System.Drawing.Point(594, 258);
            this.lblWeightTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWeightTitle.Name = "lblWeightTitle";
            this.lblWeightTitle.Size = new System.Drawing.Size(91, 50);
            this.lblWeightTitle.TabIndex = 12;
            this.lblWeightTitle.Text = "体重";
            this.lblWeightTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEntry
            // 
            this.btnEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntry.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEntry.Font = new System.Drawing.Font("ＭＳ ゴシック", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnEntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEntry.Location = new System.Drawing.Point(1151, 225);
            this.btnEntry.Margin = new System.Windows.Forms.Padding(5);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(274, 83);
            this.btnEntry.TabIndex = 11;
            this.btnEntry.Text = "登録！";
            this.btnEntry.UseVisualStyleBackColor = false;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblNameTitle.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNameTitle.Location = new System.Drawing.Point(25, 258);
            this.lblNameTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(114, 50);
            this.lblNameTitle.TabIndex = 10;
            this.lblNameTitle.Text = "氏名";
            this.lblNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.SystemColors.Control;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTime.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTime.Location = new System.Drawing.Point(0, 1155);
            this.lblTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(1452, 50);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "yyyy/MM/dd HH:mm:ss";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gpbHensuu
            // 
            this.gpbHensuu.Controls.Add(this.btnHensuu);
            this.gpbHensuu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbHensuu.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gpbHensuu.Location = new System.Drawing.Point(0, 464);
            this.gpbHensuu.Name = "gpbHensuu";
            this.gpbHensuu.Size = new System.Drawing.Size(1452, 173);
            this.gpbHensuu.TabIndex = 12;
            this.gpbHensuu.TabStop = false;
            this.gpbHensuu.Text = "変数";
            // 
            // btnHensuu
            // 
            this.btnHensuu.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnHensuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHensuu.Font = new System.Drawing.Font("ＭＳ ゴシック", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnHensuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHensuu.Location = new System.Drawing.Point(3, 39);
            this.btnHensuu.Margin = new System.Windows.Forms.Padding(5);
            this.btnHensuu.Name = "btnHensuu";
            this.btnHensuu.Size = new System.Drawing.Size(1446, 131);
            this.btnHensuu.TabIndex = 11;
            this.btnHensuu.Text = "変数について";
            this.btnHensuu.UseVisualStyleBackColor = false;
            this.btnHensuu.Click += new System.EventHandler(this.btnHensuu_Click);
            // 
            // FProgram1stStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 1205);
            this.Controls.Add(this.gpbHensuu);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.gpbFormCntorols);
            this.Controls.Add(this.lblFormTitle);
            this.Font = new System.Drawing.Font("ＭＳ ゴシック", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FProgram1stStep";
            this.Text = "Form1";
            this.gbxColor.ResumeLayout(false);
            this.gbxColor.PerformLayout();
            this.gpbFormCntorols.ResumeLayout(false);
            this.gpbFormCntorols.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.gpbHensuu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Timer timDisplayTime;
        private System.Windows.Forms.RadioButton rdbBlue;
        private System.Windows.Forms.CheckBox cbxAnonymous;
        private System.Windows.Forms.ComboBox cbbWorkingPlace;
        private System.Windows.Forms.GroupBox gbxColor;
        private System.Windows.Forms.RadioButton rdbGreen;
        private System.Windows.Forms.RadioButton rdbYellow;
        private System.Windows.Forms.RadioButton rdbRed;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.Label lblEntryDateTitle;
        private System.Windows.Forms.Label lblWorkingPlaceTitle;
        private System.Windows.Forms.GroupBox gpbFormCntorols;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox gpbHensuu;
        private System.Windows.Forms.Button btnHensuu;
        private System.Windows.Forms.Label lblWeightUnit;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.Label lblWeightTitle;
    }
}

