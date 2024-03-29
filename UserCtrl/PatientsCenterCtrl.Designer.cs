﻿using System;

namespace DentistryClient.UserCtrl
{
    partial class PatientsCenterCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ttabControl3 = new System.Windows.Forms.TabControl();
            this.tabEzSearch = new System.Windows.Forms.TabPage();
            this.cmbHospital = new System.Windows.Forms.ComboBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.chkAge = new System.Windows.Forms.CheckBox();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.chkSex = new System.Windows.Forms.CheckBox();
            this.chkCaseNo = new System.Windows.Forms.CheckBox();
            this.chkName = new System.Windows.Forms.CheckBox();
            this.btnEasySearch = new System.Windows.Forms.Button();
            this.txtCaseNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabAdvanceSearch = new System.Windows.Forms.TabPage();
            this.btnAdvanceSearch = new System.Windows.Forms.Button();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.cmbPerson = new System.Windows.Forms.ComboBox();
            this.chkCond2 = new System.Windows.Forms.CheckBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.cmbTimeCond = new System.Windows.Forms.ComboBox();
            this.chkCond1 = new System.Windows.Forms.CheckBox();
            this.tabSendMultiMsg = new System.Windows.Forms.TabPage();
            this.lvPatientsInfo = new System.Windows.Forms.ListView();
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader33 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader34 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkHospital = new System.Windows.Forms.CheckBox();
            this.ttabControl3.SuspendLayout();
            this.tabEzSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.tabAdvanceSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // ttabControl3
            // 
            this.ttabControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ttabControl3.Controls.Add(this.tabEzSearch);
            this.ttabControl3.Controls.Add(this.tabAdvanceSearch);
            this.ttabControl3.Controls.Add(this.tabSendMultiMsg);
            this.ttabControl3.Location = new System.Drawing.Point(5, 0);
            this.ttabControl3.Name = "ttabControl3";
            this.ttabControl3.SelectedIndex = 0;
            this.ttabControl3.Size = new System.Drawing.Size(790, 164);
            this.ttabControl3.TabIndex = 1;
            // 
            // tabEzSearch
            // 
            this.tabEzSearch.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabEzSearch.Controls.Add(this.chkHospital);
            this.tabEzSearch.Controls.Add(this.cmbHospital);
            this.tabEzSearch.Controls.Add(this.numAge);
            this.tabEzSearch.Controls.Add(this.chkAge);
            this.tabEzSearch.Controls.Add(this.cmbSex);
            this.tabEzSearch.Controls.Add(this.chkSex);
            this.tabEzSearch.Controls.Add(this.chkCaseNo);
            this.tabEzSearch.Controls.Add(this.chkName);
            this.tabEzSearch.Controls.Add(this.btnEasySearch);
            this.tabEzSearch.Controls.Add(this.txtCaseNo);
            this.tabEzSearch.Controls.Add(this.txtName);
            this.tabEzSearch.Location = new System.Drawing.Point(4, 22);
            this.tabEzSearch.Name = "tabEzSearch";
            this.tabEzSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabEzSearch.Size = new System.Drawing.Size(782, 138);
            this.tabEzSearch.TabIndex = 0;
            this.tabEzSearch.Text = "简易查询";
            // 
            // cmbHospital
            // 
            this.cmbHospital.Enabled = false;
            this.cmbHospital.FormattingEnabled = true;
            this.cmbHospital.Items.AddRange(new object[] {
            "医院1",
            "医院2",
            "医院3",
            "诊所1",
            "诊所2",
            "诊所3"});
            this.cmbHospital.Location = new System.Drawing.Point(527, 49);
            this.cmbHospital.Name = "cmbHospital";
            this.cmbHospital.Size = new System.Drawing.Size(102, 20);
            this.cmbHospital.TabIndex = 8;
            // 
            // numAge
            // 
            this.numAge.Enabled = false;
            this.numAge.Location = new System.Drawing.Point(323, 82);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(100, 21);
            this.numAge.TabIndex = 13;
            // 
            // chkAge
            // 
            this.chkAge.AutoSize = true;
            this.chkAge.Location = new System.Drawing.Point(257, 87);
            this.chkAge.Name = "chkAge";
            this.chkAge.Size = new System.Drawing.Size(48, 16);
            this.chkAge.TabIndex = 12;
            this.chkAge.Text = "年龄";
            this.chkAge.UseVisualStyleBackColor = true;
            this.chkAge.CheckedChanged += new System.EventHandler(this.chkAge_CheckedChanged);
            // 
            // cmbSex
            // 
            this.cmbSex.Enabled = false;
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "女",
            "男"});
            this.cmbSex.Location = new System.Drawing.Point(130, 83);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(100, 20);
            this.cmbSex.TabIndex = 11;
            // 
            // chkSex
            // 
            this.chkSex.AutoSize = true;
            this.chkSex.Location = new System.Drawing.Point(21, 85);
            this.chkSex.Name = "chkSex";
            this.chkSex.Size = new System.Drawing.Size(48, 16);
            this.chkSex.TabIndex = 10;
            this.chkSex.Text = "性别";
            this.chkSex.UseVisualStyleBackColor = true;
            this.chkSex.CheckedChanged += new System.EventHandler(this.chkSex_CheckedChanged);
            // 
            // chkCaseNo
            // 
            this.chkCaseNo.AutoSize = true;
            this.chkCaseNo.Location = new System.Drawing.Point(257, 49);
            this.chkCaseNo.Name = "chkCaseNo";
            this.chkCaseNo.Size = new System.Drawing.Size(60, 16);
            this.chkCaseNo.TabIndex = 8;
            this.chkCaseNo.Text = "病历号";
            this.chkCaseNo.UseVisualStyleBackColor = true;
            this.chkCaseNo.CheckedChanged += new System.EventHandler(this.chkCaseNo_CheckedChanged);
            // 
            // chkName
            // 
            this.chkName.AutoSize = true;
            this.chkName.Checked = true;
            this.chkName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkName.Location = new System.Drawing.Point(21, 46);
            this.chkName.Name = "chkName";
            this.chkName.Size = new System.Drawing.Size(108, 16);
            this.chkName.TabIndex = 7;
            this.chkName.Text = "姓名或拼音字头";
            this.chkName.UseVisualStyleBackColor = true;
            this.chkName.CheckedChanged += new System.EventHandler(this.chkName_CheckedChanged);
            // 
            // btnEasySearch
            // 
            this.btnEasySearch.Location = new System.Drawing.Point(688, 51);
            this.btnEasySearch.Name = "btnEasySearch";
            this.btnEasySearch.Size = new System.Drawing.Size(75, 23);
            this.btnEasySearch.TabIndex = 6;
            this.btnEasySearch.Text = "查询";
            this.btnEasySearch.UseVisualStyleBackColor = true;
            this.btnEasySearch.Click += new System.EventHandler(this.btnEasySearch_Click);
            // 
            // txtCaseNo
            // 
            this.txtCaseNo.Enabled = false;
            this.txtCaseNo.Location = new System.Drawing.Point(323, 46);
            this.txtCaseNo.Name = "txtCaseNo";
            this.txtCaseNo.Size = new System.Drawing.Size(102, 21);
            this.txtCaseNo.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(133, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(102, 21);
            this.txtName.TabIndex = 1;
            // 
            // tabAdvanceSearch
            // 
            this.tabAdvanceSearch.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabAdvanceSearch.Controls.Add(this.btnAdvanceSearch);
            this.tabAdvanceSearch.Controls.Add(this.txtPersonName);
            this.tabAdvanceSearch.Controls.Add(this.cmbPerson);
            this.tabAdvanceSearch.Controls.Add(this.chkCond2);
            this.tabAdvanceSearch.Controls.Add(this.dtpToDate);
            this.tabAdvanceSearch.Controls.Add(this.label7);
            this.tabAdvanceSearch.Controls.Add(this.dtpFromDate);
            this.tabAdvanceSearch.Controls.Add(this.cmbTimeCond);
            this.tabAdvanceSearch.Controls.Add(this.chkCond1);
            this.tabAdvanceSearch.Location = new System.Drawing.Point(4, 22);
            this.tabAdvanceSearch.Name = "tabAdvanceSearch";
            this.tabAdvanceSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdvanceSearch.Size = new System.Drawing.Size(782, 138);
            this.tabAdvanceSearch.TabIndex = 1;
            this.tabAdvanceSearch.Text = "高级查询";
            // 
            // btnAdvanceSearch
            // 
            this.btnAdvanceSearch.Location = new System.Drawing.Point(442, 60);
            this.btnAdvanceSearch.Name = "btnAdvanceSearch";
            this.btnAdvanceSearch.Size = new System.Drawing.Size(75, 23);
            this.btnAdvanceSearch.TabIndex = 9;
            this.btnAdvanceSearch.Text = "查询";
            this.btnAdvanceSearch.UseVisualStyleBackColor = true;
            this.btnAdvanceSearch.Click += new System.EventHandler(this.btnAdvanceSearch_Click);
            // 
            // txtPersonName
            // 
            this.txtPersonName.Enabled = false;
            this.txtPersonName.Location = new System.Drawing.Point(119, 83);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(107, 21);
            this.txtPersonName.TabIndex = 8;
            // 
            // cmbPerson
            // 
            this.cmbPerson.Enabled = false;
            this.cmbPerson.FormattingEnabled = true;
            this.cmbPerson.Location = new System.Drawing.Point(38, 82);
            this.cmbPerson.Name = "cmbPerson";
            this.cmbPerson.Size = new System.Drawing.Size(75, 20);
            this.cmbPerson.TabIndex = 7;
            // 
            // chkCond2
            // 
            this.chkCond2.AutoSize = true;
            this.chkCond2.Location = new System.Drawing.Point(22, 85);
            this.chkCond2.Name = "chkCond2";
            this.chkCond2.Size = new System.Drawing.Size(15, 14);
            this.chkCond2.TabIndex = 6;
            this.chkCond2.UseVisualStyleBackColor = true;
            this.chkCond2.CheckedChanged += new System.EventHandler(this.chkCond2_CheckedChanged);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(251, 21);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(107, 21);
            this.dtpToDate.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "到";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(119, 21);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(107, 21);
            this.dtpFromDate.TabIndex = 3;
            // 
            // cmbTimeCond
            // 
            this.cmbTimeCond.FormattingEnabled = true;
            this.cmbTimeCond.Items.AddRange(new object[] {
            "首诊时间",
            "就诊时间",
            "回访时间"});
            this.cmbTimeCond.Location = new System.Drawing.Point(38, 21);
            this.cmbTimeCond.Name = "cmbTimeCond";
            this.cmbTimeCond.Size = new System.Drawing.Size(75, 20);
            this.cmbTimeCond.TabIndex = 2;
            // 
            // chkCond1
            // 
            this.chkCond1.AutoSize = true;
            this.chkCond1.Checked = true;
            this.chkCond1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCond1.Location = new System.Drawing.Point(22, 25);
            this.chkCond1.Name = "chkCond1";
            this.chkCond1.Size = new System.Drawing.Size(15, 14);
            this.chkCond1.TabIndex = 0;
            this.chkCond1.UseVisualStyleBackColor = true;
            this.chkCond1.CheckedChanged += new System.EventHandler(this.chkCond1_CheckedChanged);
            // 
            // tabSendMultiMsg
            // 
            this.tabSendMultiMsg.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabSendMultiMsg.Location = new System.Drawing.Point(4, 22);
            this.tabSendMultiMsg.Name = "tabSendMultiMsg";
            this.tabSendMultiMsg.Padding = new System.Windows.Forms.Padding(3);
            this.tabSendMultiMsg.Size = new System.Drawing.Size(782, 138);
            this.tabSendMultiMsg.TabIndex = 2;
            this.tabSendMultiMsg.Text = "群发短信";
            // 
            // lvPatientsInfo
            // 
            this.lvPatientsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPatientsInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader28,
            this.columnHeader29,
            this.columnHeader30,
            this.columnHeader31,
            this.columnHeader32,
            this.columnHeader33,
            this.columnHeader34});
            this.lvPatientsInfo.GridLines = true;
            this.lvPatientsInfo.Location = new System.Drawing.Point(4, 170);
            this.lvPatientsInfo.MultiSelect = false;
            this.lvPatientsInfo.Name = "lvPatientsInfo";
            this.lvPatientsInfo.Size = new System.Drawing.Size(786, 490);
            this.lvPatientsInfo.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvPatientsInfo.TabIndex = 2;
            this.lvPatientsInfo.UseCompatibleStateImageBehavior = false;
            this.lvPatientsInfo.View = System.Windows.Forms.View.Details;
            this.lvPatientsInfo.SelectedIndexChanged += new System.EventHandler(this.lvPatientsInfo_SelectedIndexChanged);
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "病历号";
            this.columnHeader28.Width = 79;
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "姓名";
            this.columnHeader29.Width = 88;
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "性别";
            this.columnHeader30.Width = 95;
            // 
            // columnHeader31
            // 
            this.columnHeader31.Text = "年龄";
            this.columnHeader31.Width = 68;
            // 
            // columnHeader32
            // 
            this.columnHeader32.Text = "手机号码";
            this.columnHeader32.Width = 109;
            // 
            // columnHeader33
            // 
            this.columnHeader33.Text = "通讯地址";
            this.columnHeader33.Width = 158;
            // 
            // columnHeader34
            // 
            this.columnHeader34.Text = "初诊时间";
            this.columnHeader34.Width = 203;
            // 
            // chkHospital
            // 
            this.chkHospital.AutoSize = true;
            this.chkHospital.Location = new System.Drawing.Point(443, 51);
            this.chkHospital.Name = "chkHospital";
            this.chkHospital.Size = new System.Drawing.Size(84, 16);
            this.chkHospital.TabIndex = 14;
            this.chkHospital.Text = "医院或诊所";
            this.chkHospital.UseVisualStyleBackColor = true;
            this.chkHospital.CheckedChanged += new System.EventHandler(this.chkHospital_CheckedChanged);
            // 
            // PatientsCenterCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.lvPatientsInfo);
            this.Controls.Add(this.ttabControl3);
            this.Name = "PatientsCenterCtrl";
            this.Size = new System.Drawing.Size(799, 663);
            this.Load += new System.EventHandler(this.PatientsCenterCtrl_Load);
            this.ttabControl3.ResumeLayout(false);
            this.tabEzSearch.ResumeLayout(false);
            this.tabEzSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.tabAdvanceSearch.ResumeLayout(false);
            this.tabAdvanceSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ttabControl3;
        private System.Windows.Forms.TabPage tabEzSearch;
        private System.Windows.Forms.Button btnEasySearch;
        private System.Windows.Forms.TextBox txtCaseNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TabPage tabAdvanceSearch;
        private System.Windows.Forms.Button btnAdvanceSearch;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.ComboBox cmbPerson;
        private System.Windows.Forms.CheckBox chkCond2;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.ComboBox cmbTimeCond;
        private System.Windows.Forms.CheckBox chkCond1;
        private System.Windows.Forms.TabPage tabSendMultiMsg;
        private System.Windows.Forms.ListView lvPatientsInfo;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.ColumnHeader columnHeader30;
        private System.Windows.Forms.ColumnHeader columnHeader31;
        private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.ColumnHeader columnHeader33;
        private System.Windows.Forms.ColumnHeader columnHeader34;

        private System.Windows.Forms.ComboBox cmbHospital;

        private System.Windows.Forms.CheckBox chkCaseNo;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.CheckBox chkAge;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.CheckBox chkSex;
        private System.Windows.Forms.CheckBox chkName;
        private System.Windows.Forms.CheckBox chkHospital;


        public event EventHandler Closing;
        public event EventHandler Loading;
    }
}
