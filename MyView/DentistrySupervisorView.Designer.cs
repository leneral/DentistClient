using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DentistryClient.DentistrySupervisor;

namespace DentistryClient.MyView
{
    partial class DentistrySupervisorView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        Size btnSz = new Size(80, 80);
        Size lblSz = new Size(60, 25);
        const int gap = 30;
        private Button[] _btns;

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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.���߹���ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPreliminary = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCaseFill = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.����ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLine = new System.Windows.Forms.MenuStrip();
            this.��������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ԤԼ����ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.�շѹ���ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.�������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.�շѲ�ѯToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.�������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.�ͻ�����ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.�طõǼ�ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.�طò�ѯToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextRight = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuPatientInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.�鿴���ﲡ��ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblSalarySearch = new System.Windows.Forms.Label();
            this.lblSalaryCenter = new System.Windows.Forms.Label();
            this.lblOrderCenter = new System.Windows.Forms.Label();
            this.lblPatientsCenter = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.btnSalarySearch = new System.Windows.Forms.Button();
            this.btnSalaryCenter = new System.Windows.Forms.Button();
            this.btnOrderCenter = new System.Windows.Forms.Button();
            this.btnPatientsCenter = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstSuperCom = new System.Windows.Forms.ListView();
            this.btnSystemSuper = new System.Windows.Forms.Button();
            this.btnReportSuper = new System.Windows.Forms.Button();
            this.btnSalarySuper = new System.Windows.Forms.Button();
            this.btnProductSuper = new System.Windows.Forms.Button();
            this.btnPatientsSuper = new System.Windows.Forms.Button();
            this.ilstModel = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuLine.SuspendLayout();
            this.contextRight.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 693);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1006, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ���߹���ToolStripMenuItem
            // 
            this.���߹���ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPreliminary,
            this.menuCaseFill,
            this.toolStripMenuItem1});
            this.���߹���ToolStripMenuItem.Name = "���߹���ToolStripMenuItem";
            this.���߹���ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.���߹���ToolStripMenuItem.Text = "���߹���";
            // 
            // menuPreliminary
            // 
            this.menuPreliminary.Name = "menuPreliminary";
            this.menuPreliminary.Size = new System.Drawing.Size(148, 22);
            this.menuPreliminary.Text = "�»��ߵǼ�";
            // 
            // menuCaseFill
            // 
            this.menuCaseFill.Name = "menuCaseFill";
            this.menuCaseFill.Size = new System.Drawing.Size(148, 22);
            this.menuCaseFill.Text = "��д���ﲡ��";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 6);
            // 
            // ����ToolStripMenuItem
            // 
            this.����ToolStripMenuItem.Name = "����ToolStripMenuItem";
            this.����ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.����ToolStripMenuItem.Text = "����";
            // 
            // menuLine
            // 
            this.menuLine.BackColor = System.Drawing.SystemColors.Menu;
            this.menuLine.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuLine.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.���߹���ToolStripMenuItem,
            this.��������ToolStripMenuItem,
            this.�շѹ���ToolStripMenuItem,
            this.�ͻ�����ToolStripMenuItem,
            this.����ToolStripMenuItem});
            this.menuLine.Location = new System.Drawing.Point(0, 0);
            this.menuLine.Name = "menuLine";
            this.menuLine.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuLine.Size = new System.Drawing.Size(1006, 25);
            this.menuLine.TabIndex = 0;
            this.menuLine.Text = "���˵�";
            // 
            // ��������ToolStripMenuItem
            // 
            this.��������ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ԤԼ����ToolStripMenuItem});
            this.��������ToolStripMenuItem.Name = "��������ToolStripMenuItem";
            this.��������ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.��������ToolStripMenuItem.Text = "��������";
            // 
            // ԤԼ����ToolStripMenuItem
            // 
            this.ԤԼ����ToolStripMenuItem.Name = "ԤԼ����ToolStripMenuItem";
            this.ԤԼ����ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ԤԼ����ToolStripMenuItem.Text = "ԤԼ����";
            // 
            // �շѹ���ToolStripMenuItem
            // 
            this.�շѹ���ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.�������ToolStripMenuItem,
            this.�շѲ�ѯToolStripMenuItem,
            this.toolStripMenuItem3,
            this.�������ToolStripMenuItem});
            this.�շѹ���ToolStripMenuItem.Name = "�շѹ���ToolStripMenuItem";
            this.�շѹ���ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.�շѹ���ToolStripMenuItem.Text = "���ù���";
            // 
            // �������ToolStripMenuItem
            // 
            this.�������ToolStripMenuItem.Name = "�������ToolStripMenuItem";
            this.�������ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.�������ToolStripMenuItem.Text = "�������";
            // 
            // �շѲ�ѯToolStripMenuItem
            // 
            this.�շѲ�ѯToolStripMenuItem.Name = "�շѲ�ѯToolStripMenuItem";
            this.�շѲ�ѯToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.�շѲ�ѯToolStripMenuItem.Text = "�շѲ�ѯ";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(121, 6);
            // 
            // �������ToolStripMenuItem
            // 
            this.�������ToolStripMenuItem.Name = "�������ToolStripMenuItem";
            this.�������ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.�������ToolStripMenuItem.Text = "�������";
            // 
            // �ͻ�����ToolStripMenuItem
            // 
            this.�ͻ�����ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.�طõǼ�ToolStripMenuItem,
            this.�طò�ѯToolStripMenuItem});
            this.�ͻ�����ToolStripMenuItem.Name = "�ͻ�����ToolStripMenuItem";
            this.�ͻ�����ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.�ͻ�����ToolStripMenuItem.Text = "�ͻ�����";
            // 
            // �طõǼ�ToolStripMenuItem
            // 
            this.�طõǼ�ToolStripMenuItem.Name = "�طõǼ�ToolStripMenuItem";
            this.�طõǼ�ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.�طõǼ�ToolStripMenuItem.Text = "�طõǼ�";
            // 
            // �طò�ѯToolStripMenuItem
            // 
            this.�طò�ѯToolStripMenuItem.Name = "�طò�ѯToolStripMenuItem";
            this.�طò�ѯToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.�طò�ѯToolStripMenuItem.Text = "�طò�ѯ";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(125, 150);
            // 
            // contextRight
            // 
            this.contextRight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPatientInfo,
            this.�鿴���ﲡ��ToolStripMenuItem,
            this.toolStripSeparator1,
            this.menuPayment});
            this.contextRight.Name = "contextRight";
            this.contextRight.Size = new System.Drawing.Size(149, 76);
            // 
            // menuPatientInfo
            // 
            this.menuPatientInfo.Name = "menuPatientInfo";
            this.menuPatientInfo.Size = new System.Drawing.Size(148, 22);
            this.menuPatientInfo.Text = "�鿴������Ϣ";
            // 
            // �鿴���ﲡ��ToolStripMenuItem
            // 
            this.�鿴���ﲡ��ToolStripMenuItem.Name = "�鿴���ﲡ��ToolStripMenuItem";
            this.�鿴���ﲡ��ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.�鿴���ﲡ��ToolStripMenuItem.Text = "�鿴���ﲡ��";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // menuPayment
            // 
            this.menuPayment.Name = "menuPayment";
            this.menuPayment.Size = new System.Drawing.Size(148, 22);
            this.menuPayment.Text = "�������";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.Controls.Add(this.lblSalarySearch);
            this.pnlLeft.Controls.Add(this.lblSalaryCenter);
            this.pnlLeft.Controls.Add(this.lblOrderCenter);
            this.pnlLeft.Controls.Add(this.lblPatientsCenter);
            this.pnlLeft.Controls.Add(this.lblToday);
            this.pnlLeft.Controls.Add(this.btnSalarySearch);
            this.pnlLeft.Controls.Add(this.btnSalaryCenter);
            this.pnlLeft.Controls.Add(this.btnOrderCenter);
            this.pnlLeft.Controls.Add(this.btnPatientsCenter);
            this.pnlLeft.Controls.Add(this.btnToday);
            this.pnlLeft.Controls.Add(this.panel3);
            this.pnlLeft.Controls.Add(this.lstSuperCom);
            this.pnlLeft.Controls.Add(this.btnSystemSuper);
            this.pnlLeft.Controls.Add(this.btnReportSuper);
            this.pnlLeft.Controls.Add(this.btnSalarySuper);
            this.pnlLeft.Controls.Add(this.btnProductSuper);
            this.pnlLeft.Controls.Add(this.btnPatientsSuper);
            this.pnlLeft.Location = new System.Drawing.Point(12, 30);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(180, 656);
            this.pnlLeft.TabIndex = 4;
            // 
            // lblSalarySearch
            // 
            this.lblSalarySearch.AutoSize = true;
            this.lblSalarySearch.Location = new System.Drawing.Point(51, 509);
            this.lblSalarySearch.Name = "lblSalarySearch";
            this.lblSalarySearch.Size = new System.Drawing.Size(53, 12);
            this.lblSalarySearch.TabIndex = 17;
            this.lblSalarySearch.Text = "�շѲ�ѯ";
            this.lblSalarySearch.Visible = false;
            // 
            // lblSalaryCenter
            // 
            this.lblSalaryCenter.AutoSize = true;
            this.lblSalaryCenter.Location = new System.Drawing.Point(139, 475);
            this.lblSalaryCenter.Name = "lblSalaryCenter";
            this.lblSalaryCenter.Size = new System.Drawing.Size(53, 12);
            this.lblSalaryCenter.TabIndex = 16;
            this.lblSalaryCenter.Text = "�շ�����";
            this.lblSalaryCenter.Visible = false;
            // 
            // lblOrderCenter
            // 
            this.lblOrderCenter.AutoSize = true;
            this.lblOrderCenter.Location = new System.Drawing.Point(53, 479);
            this.lblOrderCenter.Name = "lblOrderCenter";
            this.lblOrderCenter.Size = new System.Drawing.Size(53, 12);
            this.lblOrderCenter.TabIndex = 15;
            this.lblOrderCenter.Text = "ԤԼ����";
            this.lblOrderCenter.Visible = false;
            // 
            // lblPatientsCenter
            // 
            this.lblPatientsCenter.AutoSize = true;
            this.lblPatientsCenter.Location = new System.Drawing.Point(138, 450);
            this.lblPatientsCenter.Name = "lblPatientsCenter";
            this.lblPatientsCenter.Size = new System.Drawing.Size(53, 12);
            this.lblPatientsCenter.TabIndex = 14;
            this.lblPatientsCenter.Text = "��������";
            this.lblPatientsCenter.Visible = false;
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Location = new System.Drawing.Point(53, 445);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(53, 12);
            this.lblToday.TabIndex = 13;
            this.lblToday.Text = "���չ���";
            this.lblToday.Visible = false;
            // 
            // btnSalarySearch
            // 
            this.btnSalarySearch.Location = new System.Drawing.Point(3, 494);
            this.btnSalarySearch.Name = "btnSalarySearch";
            this.btnSalarySearch.Size = new System.Drawing.Size(75, 23);
            this.btnSalarySearch.TabIndex = 12;
            this.btnSalarySearch.Text = "�շѲ�ѯ";
            this.btnSalarySearch.UseVisualStyleBackColor = true;
            this.btnSalarySearch.Visible = false;
            // 
            // btnSalaryCenter
            // 
            this.btnSalaryCenter.Location = new System.Drawing.Point(100, 465);
            this.btnSalaryCenter.Name = "btnSalaryCenter";
            this.btnSalaryCenter.Size = new System.Drawing.Size(75, 23);
            this.btnSalaryCenter.TabIndex = 11;
            this.btnSalaryCenter.Text = "�շ�����";
            this.btnSalaryCenter.UseVisualStyleBackColor = true;
            this.btnSalaryCenter.Visible = false;
            // 
            // btnOrderCenter
            // 
            this.btnOrderCenter.Location = new System.Drawing.Point(3, 465);
            this.btnOrderCenter.Name = "btnOrderCenter";
            this.btnOrderCenter.Size = new System.Drawing.Size(75, 23);
            this.btnOrderCenter.TabIndex = 10;
            this.btnOrderCenter.Text = "ԤԼ����";
            this.btnOrderCenter.UseVisualStyleBackColor = true;
            this.btnOrderCenter.Visible = false;
            this.btnOrderCenter.Click += new System.EventHandler(this.btnOrderCenter_Click);
            // 
            // btnPatientsCenter
            // 
            this.btnPatientsCenter.Location = new System.Drawing.Point(100, 436);
            this.btnPatientsCenter.Name = "btnPatientsCenter";
            this.btnPatientsCenter.Size = new System.Drawing.Size(75, 23);
            this.btnPatientsCenter.TabIndex = 9;
            this.btnPatientsCenter.Text = "��������";
            this.btnPatientsCenter.UseVisualStyleBackColor = true;
            this.btnPatientsCenter.Visible = false;
            this.btnPatientsCenter.Click += new System.EventHandler(this.btnPatientsCenter_Click);
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(3, 436);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(75, 23);
            this.btnToday.TabIndex = 8;
            this.btnToday.Text = "���չ���";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Visible = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(182, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(660, 659);
            this.panel3.TabIndex = 7;
            // 
            // lstSuperCom
            // 
            this.lstSuperCom.Location = new System.Drawing.Point(-1, 271);
            this.lstSuperCom.Name = "lstSuperCom";
            this.lstSuperCom.Size = new System.Drawing.Size(177, 158);
            this.lstSuperCom.TabIndex = 5;
            this.lstSuperCom.UseCompatibleStateImageBehavior = false;
            this.lstSuperCom.View = System.Windows.Forms.View.Details;
            // 
            // btnSystemSuper
            // 
            this.btnSystemSuper.Location = new System.Drawing.Point(-1, 211);
            this.btnSystemSuper.Name = "btnSystemSuper";
            this.btnSystemSuper.Size = new System.Drawing.Size(181, 40);
            this.btnSystemSuper.TabIndex = 4;
            this.btnSystemSuper.Text = "ϵͳά��";
            this.btnSystemSuper.UseVisualStyleBackColor = true;
            this.btnSystemSuper.Click += new System.EventHandler(this.btnSystemSuper_Click);
            // 
            // btnReportSuper
            // 
            this.btnReportSuper.Location = new System.Drawing.Point(-1, 152);
            this.btnReportSuper.Name = "btnReportSuper";
            this.btnReportSuper.Size = new System.Drawing.Size(181, 40);
            this.btnReportSuper.TabIndex = 3;
            this.btnReportSuper.Text = "�������";
            this.btnReportSuper.UseVisualStyleBackColor = true;
            this.btnReportSuper.Click += new System.EventHandler(this.btnReportSuper_Click);
            // 
            // btnSalarySuper
            // 
            this.btnSalarySuper.Location = new System.Drawing.Point(-1, 45);
            this.btnSalarySuper.Name = "btnSalarySuper";
            this.btnSalarySuper.Size = new System.Drawing.Size(181, 40);
            this.btnSalarySuper.TabIndex = 2;
            this.btnSalarySuper.Text = "�շѹ���";
            this.btnSalarySuper.UseVisualStyleBackColor = true;
            this.btnSalarySuper.Click += new System.EventHandler(this.btnSalarySuper_Click);
            // 
            // btnProductSuper
            // 
            this.btnProductSuper.Location = new System.Drawing.Point(-1, 96);
            this.btnProductSuper.Name = "btnProductSuper";
            this.btnProductSuper.Size = new System.Drawing.Size(181, 40);
            this.btnProductSuper.TabIndex = 1;
            this.btnProductSuper.Text = "�ⷿ����";
            this.btnProductSuper.UseVisualStyleBackColor = true;
            this.btnProductSuper.Click += new System.EventHandler(this.btnProductSuper_Click);
            // 
            // btnPatientsSuper
            // 
            this.btnPatientsSuper.Location = new System.Drawing.Point(-1, -1);
            this.btnPatientsSuper.Name = "btnPatientsSuper";
            this.btnPatientsSuper.Size = new System.Drawing.Size(181, 40);
            this.btnPatientsSuper.TabIndex = 0;
            this.btnPatientsSuper.Text = "���߹���";
            this.btnPatientsSuper.UseVisualStyleBackColor = true;
            this.btnPatientsSuper.Click += new System.EventHandler(this.btnPatientsSuper_Click);
            // 
            // ilstModel
            // 
            this.ilstModel.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilstModel.ImageSize = new System.Drawing.Size(16, 16);
            this.ilstModel.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(199, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 652);
            this.panel1.TabIndex = 5;
            // 
            // DentistrySupervisorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1006, 715);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuLine);
            this.MainMenuStrip = this.menuLine;
            this.Name = "DentistrySupervisorView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDentistrySupervisor_Load);
            this.menuLine.ResumeLayout(false);
            this.menuLine.PerformLayout();
            this.contextRight.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem ���߹���ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPreliminary;
        private System.Windows.Forms.ToolStripMenuItem menuCaseFill;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ����ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuLine;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem �շѹ���ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem �������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem �շѲ�ѯToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem �������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem �ͻ�����ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem �طõǼ�ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem �طò�ѯToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ��������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ԤԼ����ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextRight;
        private System.Windows.Forms.ToolStripMenuItem menuPatientInfo;
        private System.Windows.Forms.ToolStripMenuItem menuPayment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem �鿴���ﲡ��ToolStripMenuItem;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnSalarySuper;
        private System.Windows.Forms.Button btnProductSuper;
        private System.Windows.Forms.Button btnPatientsSuper;
        private System.Windows.Forms.Button btnReportSuper;
        private System.Windows.Forms.Button btnSystemSuper;
        private System.Windows.Forms.ListView lstSuperCom;
        private System.Windows.Forms.ImageList ilstModel;


        private void InitComs()
        {
            //buttons
            _btns = new[]
                {
                    btnSalarySuper, btnProductSuper,
                    btnReportSuper, btnSystemSuper
                };

            btnPatientsSuper.Dock = DockStyle.Top;
            foreach (Button button in _btns)
            {
                button.SendToBack();
                button.Dock = DockStyle.Bottom;
            }
            lstSuperCom.Dock = DockStyle.Fill;
            lstSuperCom.Controls.Clear();

            ArrangePatientsCom();
        }

        private void ArrangePatientsCom()
        {
            int btnX = (pnlLeft.Size.Width >> 1) - 35;
            int lblX = (pnlLeft.Size.Width >> 1) - 30;

            var list = new List<Control>();

            btnToday.Size = btnSz;
            btnToday.Location = new Point(btnX, 0);
            btnToday.Visible = true;
            list.Add(btnToday);
            lblToday.Size = lblSz;
            lblToday.Location = new Point(lblX, btnToday.Size.Height);
            lblToday.Visible = true;
            list.Add(lblToday);

            btnPatientsCenter.Size = btnSz;
            btnPatientsCenter.Location = new Point(btnX, lblToday.Location.Y + lblToday.Size.Height + gap);
            btnPatientsCenter.Visible = true;
            list.Add(btnPatientsCenter);
            lblPatientsCenter.Size = lblSz;
            lblPatientsCenter.Location = new Point(lblX, btnPatientsCenter.Location.Y + btnPatientsCenter.Size.Height);
            lblPatientsCenter.Visible = true;
            list.Add(lblPatientsCenter);

            btnOrderCenter.Size = btnSz;
            btnOrderCenter.Location = new Point(btnX, lblPatientsCenter.Location.Y + lblPatientsCenter.Size.Height + gap);
            btnOrderCenter.Visible = true;
            list.Add(btnOrderCenter);
            lblOrderCenter.Size = lblSz;
            lblOrderCenter.Location = new Point(lblX, btnOrderCenter.Location.Y + btnOrderCenter.Size.Height);
            lblOrderCenter.Visible = true;
            list.Add(lblOrderCenter);

            AddCtrlsToList(list, lstSuperCom);

            btnSalaryCenter.Visible = false;
            lblSalaryCenter.Visible = false;
            btnSalarySearch.Visible = false;
            btnSalarySearch.Visible = false;
        }

        private void ArrangeSalaryCom()
        {
            int btnX = (pnlLeft.Size.Width >> 1) - 35;
            int lblX = (pnlLeft.Size.Width >> 1) - 30;

            var list = new List<Control>();

            btnSalaryCenter.Size = btnSz;
            btnSalaryCenter.Location = new Point(btnX, 0);
            btnSalaryCenter.Visible = true;
            list.Add(btnSalaryCenter);

            lblSalaryCenter.Size = lblSz;
            lblSalaryCenter.Location = new Point(lblX, btnSalaryCenter.Size.Height);
            lblSalaryCenter.Visible = true;
            list.Add(lblSalaryCenter);

            btnSalarySearch.Size = btnSz;
            btnSalarySearch.Location = new Point(btnX, lblSalaryCenter.Location.Y + lblSalaryCenter.Size.Height + gap);
            btnSalarySearch.Visible = true;
            list.Add(btnSalarySearch);

            lblSalarySearch.Size = lblSz;
            lblSalarySearch.Location = new Point(lblX, btnSalarySearch.Location.Y + btnSalarySearch.Size.Height);
            lblSalarySearch.Visible = true;
            list.Add(lblSalarySearch);

           AddCtrlsToList(list, lstSuperCom);
        }

        public void AddCtrlsToList(List<Control> list, ListView lv)
        {
            lv.BeginUpdate();
            lv.Controls.AddRange(list.ToArray());
            lv.EndUpdate();
        }

        private Panel panel3;
        private Button btnSalarySearch;
        private Button btnSalaryCenter;
        private Button btnOrderCenter;
        private Button btnPatientsCenter;
        private Button btnToday;
        private Label lblSalarySearch;
        private Label lblSalaryCenter;
        private Label lblOrderCenter;
        private Label lblPatientsCenter;
        private Label lblToday;
        private Panel panel1;
    }
}