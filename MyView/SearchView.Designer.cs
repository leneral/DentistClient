using System;

namespace DentistryClient.MyView
{
    partial class SearchView
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
            this.tabEzSearch = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCaseNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rdoCaseNo = new System.Windows.Forms.RadioButton();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.tabAdvanceSearch = new System.Windows.Forms.TabPage();
            this.lvPatientsInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabEzSearch.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEzSearch
            // 
            this.tabEzSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabEzSearch.Controls.Add(this.tabPage1);
            this.tabEzSearch.Controls.Add(this.tabAdvanceSearch);
            this.tabEzSearch.Location = new System.Drawing.Point(1, 2);
            this.tabEzSearch.Name = "tabEzSearch";
            this.tabEzSearch.SelectedIndex = 0;
            this.tabEzSearch.Size = new System.Drawing.Size(715, 135);
            this.tabEzSearch.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.txtCaseNo);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.rdoCaseNo);
            this.tabPage1.Controls.Add(this.rdoName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(707, 109);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "简易查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(588, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCaseNo
            // 
            this.txtCaseNo.Enabled = false;
            this.txtCaseNo.Location = new System.Drawing.Point(312, 43);
            this.txtCaseNo.Name = "txtCaseNo";
            this.txtCaseNo.Size = new System.Drawing.Size(100, 21);
            this.txtCaseNo.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 8;
            // 
            // rdoCaseNo
            // 
            this.rdoCaseNo.AutoSize = true;
            this.rdoCaseNo.Location = new System.Drawing.Point(238, 48);
            this.rdoCaseNo.Name = "rdoCaseNo";
            this.rdoCaseNo.Size = new System.Drawing.Size(59, 16);
            this.rdoCaseNo.TabIndex = 7;
            this.rdoCaseNo.Text = "病历号";
            this.rdoCaseNo.UseVisualStyleBackColor = true;
            this.rdoCaseNo.CheckedChanged += new System.EventHandler(this.rdoCaseNo_CheckedChanged);
            // 
            // rdoName
            // 
            this.rdoName.AutoSize = true;
            this.rdoName.Checked = true;
            this.rdoName.Location = new System.Drawing.Point(43, 45);
            this.rdoName.Name = "rdoName";
            this.rdoName.Size = new System.Drawing.Size(47, 16);
            this.rdoName.TabIndex = 6;
            this.rdoName.TabStop = true;
            this.rdoName.Text = "姓名";
            this.rdoName.UseVisualStyleBackColor = true;
            this.rdoName.CheckedChanged += new System.EventHandler(this.rdoName_CheckedChanged);
            // 
            // tabAdvanceSearch
            // 
            this.tabAdvanceSearch.Location = new System.Drawing.Point(4, 22);
            this.tabAdvanceSearch.Name = "tabAdvanceSearch";
            this.tabAdvanceSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdvanceSearch.Size = new System.Drawing.Size(707, 109);
            this.tabAdvanceSearch.TabIndex = 1;
            this.tabAdvanceSearch.Text = "高级查询";
            this.tabAdvanceSearch.UseVisualStyleBackColor = true;
            // 
            // lvPatientsInfo
            // 
            this.lvPatientsInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvPatientsInfo.FullRowSelect = true;
            this.lvPatientsInfo.GridLines = true;
            this.lvPatientsInfo.Location = new System.Drawing.Point(1, 143);
            this.lvPatientsInfo.Name = "lvPatientsInfo";
            this.lvPatientsInfo.Size = new System.Drawing.Size(711, 214);
            this.lvPatientsInfo.TabIndex = 1;
            this.lvPatientsInfo.UseCompatibleStateImageBehavior = false;
            this.lvPatientsInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "病历号";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓名";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "性别";
            this.columnHeader3.Width = 69;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "年龄";
            this.columnHeader4.Width = 101;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "初诊时间";
            this.columnHeader5.Width = 103;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "手机";
            this.columnHeader6.Width = 88;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "主治医生";
            this.columnHeader7.Width = 100;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(259, 383);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(438, 383);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 428);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lvPatientsInfo);
            this.Controls.Add(this.tabEzSearch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchView";
            this.Text = "查询";
            this.tabEzSearch.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEzSearch;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabAdvanceSearch;
        private System.Windows.Forms.ListView lvPatientsInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCaseNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rdoCaseNo;
        private System.Windows.Forms.RadioButton rdoName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}