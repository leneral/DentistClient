using System;

namespace DentistryClient.UserCtrl
{
    partial class TodayJobCtrl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param nodeName="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("上午");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("下午");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("初诊患者", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("上午");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("下午");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("复诊患者", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("下周预约");
            this.pnlEveryDayWork = new System.Windows.Forms.Panel();
            this.btnOutProcess = new System.Windows.Forms.Button();
            this.btnSuffererRegistrer = new System.Windows.Forms.Button();
            this.btnCaseFill = new System.Windows.Forms.Button();
            this.tabSuffererInfo = new System.Windows.Forms.TabControl();
            this.tabTodaySufferer = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeTodayPatients = new System.Windows.Forms.TreeView();
            this.tabAllSufferers = new System.Windows.Forms.TabPage();
            this.lvPatients = new System.Windows.Forms.ListView();
            this.columnHeader35 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirstTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabBeSpeak = new System.Windows.Forms.TabPage();
            this.treeOrder = new System.Windows.Forms.TreeView();
            this.btnSalary = new System.Windows.Forms.Button();
            this.pnlEveryDayWork.SuspendLayout();
            this.tabSuffererInfo.SuspendLayout();
            this.tabTodaySufferer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabAllSufferers.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabBeSpeak.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEveryDayWork
            // 
            this.pnlEveryDayWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEveryDayWork.BackColor = System.Drawing.Color.Azure;
            this.pnlEveryDayWork.Controls.Add(this.btnSalary);
            this.pnlEveryDayWork.Controls.Add(this.btnOutProcess);
            this.pnlEveryDayWork.Controls.Add(this.btnSuffererRegistrer);
            this.pnlEveryDayWork.Controls.Add(this.btnCaseFill);
            this.pnlEveryDayWork.Controls.Add(this.tabSuffererInfo);
            this.pnlEveryDayWork.Location = new System.Drawing.Point(8, 8);
            this.pnlEveryDayWork.Name = "pnlEveryDayWork";
            this.pnlEveryDayWork.Size = new System.Drawing.Size(791, 663);
            this.pnlEveryDayWork.TabIndex = 4;
            // 
            // btnOutProcess
            // 
            this.btnOutProcess.Location = new System.Drawing.Point(414, 174);
            this.btnOutProcess.Name = "btnOutProcess";
            this.btnOutProcess.Size = new System.Drawing.Size(157, 42);
            this.btnOutProcess.TabIndex = 6;
            this.btnOutProcess.Text = "外加工管理";
            this.btnOutProcess.UseVisualStyleBackColor = true;
            this.btnOutProcess.Click += new System.EventHandler(this.btnOutProcess_Click);
            // 
            // btnSuffererRegistrer
            // 
            this.btnSuffererRegistrer.Location = new System.Drawing.Point(414, 25);
            this.btnSuffererRegistrer.Name = "btnSuffererRegistrer";
            this.btnSuffererRegistrer.Size = new System.Drawing.Size(157, 42);
            this.btnSuffererRegistrer.TabIndex = 4;
            this.btnSuffererRegistrer.Text = "新患者登记";
            this.btnSuffererRegistrer.UseVisualStyleBackColor = true;
            this.btnSuffererRegistrer.Click += new System.EventHandler(this.btnSuffererRegistrer_Click);
            // 
            // btnCaseFill
            // 
            this.btnCaseFill.Location = new System.Drawing.Point(414, 95);
            this.btnCaseFill.Name = "btnCaseFill";
            this.btnCaseFill.Size = new System.Drawing.Size(157, 42);
            this.btnCaseFill.TabIndex = 5;
            this.btnCaseFill.Text = "填写就诊病历";
            this.btnCaseFill.UseVisualStyleBackColor = true;
            this.btnCaseFill.Click += new System.EventHandler(this.btnCaseFill_Click);
            // 
            // tabSuffererInfo
            // 
            this.tabSuffererInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tabSuffererInfo.Controls.Add(this.tabTodaySufferer);
            this.tabSuffererInfo.Controls.Add(this.tabAllSufferers);
            this.tabSuffererInfo.Controls.Add(this.tabBeSpeak);
            this.tabSuffererInfo.Location = new System.Drawing.Point(0, 0);
            this.tabSuffererInfo.Name = "tabSuffererInfo";
            this.tabSuffererInfo.SelectedIndex = 0;
            this.tabSuffererInfo.Size = new System.Drawing.Size(362, 660);
            this.tabSuffererInfo.TabIndex = 0;
            this.tabSuffererInfo.SelectedIndexChanged += new System.EventHandler(this.tabSuffererInfo_SelectedIndexChanged);
            // 
            // tabTodaySufferer
            // 
            this.tabTodaySufferer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabTodaySufferer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabTodaySufferer.Controls.Add(this.panel1);
            this.tabTodaySufferer.Location = new System.Drawing.Point(4, 22);
            this.tabTodaySufferer.Name = "tabTodaySufferer";
            this.tabTodaySufferer.Padding = new System.Windows.Forms.Padding(3);
            this.tabTodaySufferer.Size = new System.Drawing.Size(354, 634);
            this.tabTodaySufferer.TabIndex = 0;
            this.tabTodaySufferer.Text = "今日患者";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.treeTodayPatients);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 641);
            this.panel1.TabIndex = 0;
            // 
            // treeTodayPatients
            // 
            this.treeTodayPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeTodayPatients.BackColor = System.Drawing.SystemColors.Info;
            this.treeTodayPatients.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeTodayPatients.Location = new System.Drawing.Point(0, 1);
            this.treeTodayPatients.Name = "treeTodayPatients";
            treeNode15.Name = "NodeFMorning";
            treeNode15.Text = "上午";
            treeNode16.Name = "NodeFAfternoon";
            treeNode16.Text = "下午";
            treeNode17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            treeNode17.ForeColor = System.Drawing.Color.Black;
            treeNode17.Name = "ndPreliminary";
            treeNode17.Text = "初诊患者";
            treeNode17.ToolTipText = "今日初诊患者列表";
            treeNode18.Name = "NodeSMorning";
            treeNode18.Text = "上午";
            treeNode19.Name = "NodeSAfternoon";
            treeNode19.Text = "下午";
            treeNode20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            treeNode20.ForeColor = System.Drawing.Color.Black;
            treeNode20.Name = "ndRetrial";
            treeNode20.Text = "复诊患者";
            treeNode20.ToolTipText = "今日复诊患者列表";
            this.treeTodayPatients.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode20});
            this.treeTodayPatients.Size = new System.Drawing.Size(357, 633);
            this.treeTodayPatients.TabIndex = 0;
            this.treeTodayPatients.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeTodayPatients_MouseClick);
            // 
            // tabAllSufferers
            // 
            this.tabAllSufferers.BackColor = System.Drawing.Color.OldLace;
            this.tabAllSufferers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabAllSufferers.Controls.Add(this.lvPatients);
            this.tabAllSufferers.Controls.Add(this.panel2);
            this.tabAllSufferers.Location = new System.Drawing.Point(4, 22);
            this.tabAllSufferers.Name = "tabAllSufferers";
            this.tabAllSufferers.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllSufferers.Size = new System.Drawing.Size(354, 634);
            this.tabAllSufferers.TabIndex = 1;
            this.tabAllSufferers.Text = "所有患者";
            // 
            // lvPatients
            // 
            this.lvPatients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lvPatients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader35,
            this.colName,
            this.colSex,
            this.colAge,
            this.colFirstTime});
            this.lvPatients.FullRowSelect = true;
            this.lvPatients.GridLines = true;
            this.lvPatients.Location = new System.Drawing.Point(1, 113);
            this.lvPatients.MultiSelect = false;
            this.lvPatients.Name = "lvPatients";
            this.lvPatients.Size = new System.Drawing.Size(348, 511);
            this.lvPatients.TabIndex = 4;
            this.lvPatients.UseCompatibleStateImageBehavior = false;
            this.lvPatients.View = System.Windows.Forms.View.Details;
            this.lvPatients.SelectedIndexChanged += new System.EventHandler(this.lvPatients_SelectedIndexChanged);
            this.lvPatients.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvPatients_MouseClick);
            // 
            // columnHeader35
            // 
            this.columnHeader35.Text = "病例号";
            this.columnHeader35.Width = 66;
            // 
            // colName
            // 
            this.colName.Text = "姓名";
            this.colName.Width = 72;
            // 
            // colSex
            // 
            this.colSex.Text = "性别";
            this.colSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSex.Width = 93;
            // 
            // colAge
            // 
            this.colAge.Text = "年龄";
            this.colAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAge.Width = 100;
            // 
            // colFirstTime
            // 
            this.colFirstTime.Text = "初诊时间";
            this.colFirstTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colFirstTime.Width = 78;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(-3, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 113);
            this.panel2.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名/拼音字头";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(244, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(24, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(192, 21);
            this.txtSearch.TabIndex = 2;
            // 
            // tabBeSpeak
            // 
            this.tabBeSpeak.Controls.Add(this.treeOrder);
            this.tabBeSpeak.Location = new System.Drawing.Point(4, 22);
            this.tabBeSpeak.Name = "tabBeSpeak";
            this.tabBeSpeak.Padding = new System.Windows.Forms.Padding(3);
            this.tabBeSpeak.Size = new System.Drawing.Size(354, 634);
            this.tabBeSpeak.TabIndex = 2;
            this.tabBeSpeak.Text = "近期预约";
            this.tabBeSpeak.UseVisualStyleBackColor = true;
            // 
            // treeOrder
            // 
            this.treeOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.treeOrder.Location = new System.Drawing.Point(6, 6);
            this.treeOrder.Name = "treeOrder";
            treeNode21.Name = "ndBeSpeak";
            treeNode21.Text = "下周预约";
            this.treeOrder.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21});
            this.treeOrder.Size = new System.Drawing.Size(348, 622);
            this.treeOrder.TabIndex = 0;
            // 
            // btnSalary
            // 
            this.btnSalary.Location = new System.Drawing.Point(414, 259);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(157, 42);
            this.btnSalary.TabIndex = 7;
            this.btnSalary.Text = "收费管理";
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // TodayJobCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlEveryDayWork);
            this.Name = "TodayJobCtrl";
            this.Size = new System.Drawing.Size(799, 663);
            this.Load += new System.EventHandler(this.TodayJobCtrl_Load);
            this.pnlEveryDayWork.ResumeLayout(false);
            this.tabSuffererInfo.ResumeLayout(false);
            this.tabTodaySufferer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabAllSufferers.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabBeSpeak.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEveryDayWork;
        private System.Windows.Forms.Button btnOutProcess;
        private System.Windows.Forms.Button btnSuffererRegistrer;
        private System.Windows.Forms.Button btnCaseFill;
        private System.Windows.Forms.TabControl tabSuffererInfo;
        private System.Windows.Forms.TabPage tabTodaySufferer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeTodayPatients;
        private System.Windows.Forms.TabPage tabAllSufferers;
        private System.Windows.Forms.ListView lvPatients;
        private System.Windows.Forms.ColumnHeader columnHeader35;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSex;
        private System.Windows.Forms.ColumnHeader colAge;
        private System.Windows.Forms.ColumnHeader colFirstTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tabBeSpeak;
        private System.Windows.Forms.TreeView treeOrder;

        public void Exit()
        {
        }

        private System.Windows.Forms.Button btnSalary;
    }
}
