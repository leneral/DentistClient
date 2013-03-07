using System;

namespace DentistryClient.UserCtrl
{
    partial class OrderCenterCtrl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvTodayOrder = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvOrderTomorrow = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSearchout = new System.Windows.Forms.Button();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.chkDoctor = new System.Windows.Forms.CheckBox();
            this.chkPatient = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvSearchOrder = new System.Windows.Forms.ListView();
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.btnUnOrder = new System.Windows.Forms.Button();
            this.btnModifyOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 659);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvTodayOrder);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(686, 633);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "今日预约";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvTodayOrder
            // 
            this.lvTodayOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvTodayOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader9});
            this.lvTodayOrder.FullRowSelect = true;
            this.lvTodayOrder.GridLines = true;
            this.lvTodayOrder.Location = new System.Drawing.Point(2, 47);
            this.lvTodayOrder.Name = "lvTodayOrder";
            this.lvTodayOrder.Size = new System.Drawing.Size(684, 584);
            this.lvTodayOrder.TabIndex = 1;
            this.lvTodayOrder.UseCompatibleStateImageBehavior = false;
            this.lvTodayOrder.View = System.Windows.Forms.View.Details;
            this.lvTodayOrder.SelectedIndexChanged += new System.EventHandler(this.lvTodayOrder_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "病历号";
            this.columnHeader1.Width = 79;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓名";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 68;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "预约医生";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 84;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "预约时间";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 114;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "内容";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 198;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "手机号码";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "已发短信";
            this.columnHeader8.Width = 68;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "预约状态";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "今日预约列表：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvOrderTomorrow);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(686, 633);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "明日预约";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvOrderTomorrow
            // 
            this.lvOrderTomorrow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvOrderTomorrow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.lvOrderTomorrow.Location = new System.Drawing.Point(2, 54);
            this.lvOrderTomorrow.Name = "lvOrderTomorrow";
            this.lvOrderTomorrow.Size = new System.Drawing.Size(682, 582);
            this.lvOrderTomorrow.TabIndex = 2;
            this.lvOrderTomorrow.UseCompatibleStateImageBehavior = false;
            this.lvOrderTomorrow.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "病历号";
            this.columnHeader10.Width = 79;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "姓名";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 68;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "预约时间";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 84;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "手机号码";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 114;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "内容";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 156;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "医生";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader15.Width = 49;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "制作人";
            this.columnHeader16.Width = 63;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "已发短信";
            this.columnHeader17.Width = 68;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "状态";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NSimSun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(8, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "明日预约列表：";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Controls.Add(this.lvSearchOrder);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(686, 633);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "预约查询";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSearchout);
            this.panel4.Controls.Add(this.cmbDoctor);
            this.panel4.Controls.Add(this.txtPatient);
            this.panel4.Controls.Add(this.chkDoctor);
            this.panel4.Controls.Add(this.chkPatient);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.dtpTo);
            this.panel4.Controls.Add(this.dtpFrom);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(2, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(682, 117);
            this.panel4.TabIndex = 4;
            // 
            // btnSearchout
            // 
            this.btnSearchout.Location = new System.Drawing.Point(573, 49);
            this.btnSearchout.Name = "btnSearchout";
            this.btnSearchout.Size = new System.Drawing.Size(75, 23);
            this.btnSearchout.TabIndex = 9;
            this.btnSearchout.Text = "查询";
            this.btnSearchout.UseVisualStyleBackColor = true;
            this.btnSearchout.Click += new System.EventHandler(this.btnSearchout_Click);
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.Enabled = false;
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(380, 26);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(100, 20);
            this.cmbDoctor.TabIndex = 8;
            // 
            // txtPatient
            // 
            this.txtPatient.Enabled = false;
            this.txtPatient.Location = new System.Drawing.Point(380, 69);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(100, 21);
            this.txtPatient.TabIndex = 7;
            // 
            // chkDoctor
            // 
            this.chkDoctor.AutoSize = true;
            this.chkDoctor.Location = new System.Drawing.Point(317, 31);
            this.chkDoctor.Name = "chkDoctor";
            this.chkDoctor.Size = new System.Drawing.Size(48, 16);
            this.chkDoctor.TabIndex = 6;
            this.chkDoctor.Text = "医生";
            this.chkDoctor.UseVisualStyleBackColor = true;
            this.chkDoctor.CheckedChanged += new System.EventHandler(this.chkDoctor_CheckedChanged);
            // 
            // chkPatient
            // 
            this.chkPatient.AutoSize = true;
            this.chkPatient.Location = new System.Drawing.Point(317, 74);
            this.chkPatient.Name = "chkPatient";
            this.chkPatient.Size = new System.Drawing.Size(48, 16);
            this.chkPatient.TabIndex = 5;
            this.chkPatient.Text = "患者";
            this.chkPatient.UseVisualStyleBackColor = true;
            this.chkPatient.CheckedChanged += new System.EventHandler(this.chkPatient_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "到";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(142, 71);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(132, 21);
            this.dtpTo.TabIndex = 3;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(142, 26);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(132, 21);
            this.dtpFrom.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "从";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "时间范围:";
            // 
            // lvSearchOrder
            // 
            this.lvSearchOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSearchOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader24,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader26,
            this.columnHeader27});
            this.lvSearchOrder.FullRowSelect = true;
            this.lvSearchOrder.GridLines = true;
            this.lvSearchOrder.Location = new System.Drawing.Point(2, 124);
            this.lvSearchOrder.Name = "lvSearchOrder";
            this.lvSearchOrder.Size = new System.Drawing.Size(679, 506);
            this.lvSearchOrder.TabIndex = 3;
            this.lvSearchOrder.UseCompatibleStateImageBehavior = false;
            this.lvSearchOrder.View = System.Windows.Forms.View.Details;
            this.lvSearchOrder.SelectedIndexChanged += new System.EventHandler(this.lvSearchOrder_SelectedIndexChanged);
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "病历号";
            this.columnHeader19.Width = 79;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "姓名";
            this.columnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader20.Width = 68;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "预约医生";
            this.columnHeader24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader24.Width = 75;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "预约时间";
            this.columnHeader21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader21.Width = 84;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "手机号码";
            this.columnHeader22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader22.Width = 113;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "内容";
            this.columnHeader23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader23.Width = 156;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "已发短信";
            this.columnHeader26.Width = 68;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "预约状态";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(686, 633);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "预约周历";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnOut
            // 
            this.btnOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOut.Location = new System.Drawing.Point(712, 286);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 12;
            this.btnOut.Text = "导出列表";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMsg.Location = new System.Drawing.Point(712, 234);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(75, 23);
            this.btnSendMsg.TabIndex = 11;
            this.btnSendMsg.Text = "发送短信";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            // 
            // btnUnOrder
            // 
            this.btnUnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnOrder.Location = new System.Drawing.Point(712, 182);
            this.btnUnOrder.Name = "btnUnOrder";
            this.btnUnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnUnOrder.TabIndex = 10;
            this.btnUnOrder.Text = "设成未预约";
            this.btnUnOrder.UseVisualStyleBackColor = true;
            this.btnUnOrder.Click += new System.EventHandler(this.btnUnOrder_Click);
            // 
            // btnModifyOrder
            // 
            this.btnModifyOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifyOrder.Location = new System.Drawing.Point(712, 130);
            this.btnModifyOrder.Name = "btnModifyOrder";
            this.btnModifyOrder.Size = new System.Drawing.Size(75, 23);
            this.btnModifyOrder.TabIndex = 9;
            this.btnModifyOrder.Text = "修改预约";
            this.btnModifyOrder.UseVisualStyleBackColor = true;
            this.btnModifyOrder.Click += new System.EventHandler(this.btnModifyOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteOrder.Location = new System.Drawing.Point(712, 78);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteOrder.TabIndex = 8;
            this.btnDeleteOrder.Text = "删除预约";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewOrder.Location = new System.Drawing.Point(712, 26);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(75, 23);
            this.btnNewOrder.TabIndex = 7;
            this.btnNewOrder.Text = "新建预约";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // OrderCenterCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.btnUnOrder);
            this.Controls.Add(this.btnModifyOrder);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.tabControl1);
            this.Name = "OrderCenterCtrl";
            this.Size = new System.Drawing.Size(799, 663);
            this.Load += new System.EventHandler(this.OrderCenterCtrl_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lvTodayOrder;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvOrderTomorrow;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearchout;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.CheckBox chkDoctor;
        private System.Windows.Forms.CheckBox chkPatient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvSearchOrder;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.Button btnUnOrder;
        private System.Windows.Forms.Button btnModifyOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnNewOrder;

        public void Exit()
        {
        }
    }
}
