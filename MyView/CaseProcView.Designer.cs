using System;
using Model.Patients;

namespace DentistryClient.MyView
{
    partial class CaseProcView
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
            this.pnlTemplate = new System.Windows.Forms.Panel();
            this.listView5 = new System.Windows.Forms.ListView();
            this.listView4 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabTemplate = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbModelStyle = new System.Windows.Forms.ComboBox();
            this.btnModifyModel = new System.Windows.Forms.Button();
            this.tabBooking = new System.Windows.Forms.TabPage();
            this.tabRecipe = new System.Windows.Forms.TabPage();
            this.tabCure = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCure = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPlan = new System.Windows.Forms.TabPage();
            this.tabDiagnose = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDiagnose = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabX = new System.Windows.Forms.TabPage();
            this.tabCheck = new System.Windows.Forms.TabPage();
            this.btnDetete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCheckContent1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabSickHistory = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblWriter = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKeywords = new System.Windows.Forms.TextBox();
            this.txtSickHistoryBefore = new System.Windows.Forms.TextBox();
            this.txtSickHistoryNow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonalContext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCaseProcess = new System.Windows.Forms.TabControl();
            this.pnlTemplate.SuspendLayout();
            this.tabTemplate.SuspendLayout();
            this.tabCure.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabDiagnose.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabCheck.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabSickHistory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabCaseProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTemplate
            // 
            this.pnlTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTemplate.Controls.Add(this.listView5);
            this.pnlTemplate.Controls.Add(this.listView4);
            this.pnlTemplate.Controls.Add(this.listView3);
            this.pnlTemplate.Controls.Add(this.listView2);
            this.pnlTemplate.Location = new System.Drawing.Point(4, 12);
            this.pnlTemplate.Name = "pnlTemplate";
            this.pnlTemplate.Size = new System.Drawing.Size(1072, 239);
            this.pnlTemplate.TabIndex = 1;
            // 
            // listView5
            // 
            this.listView5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listView5.GridLines = true;
            this.listView5.Location = new System.Drawing.Point(801, 3);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(263, 233);
            this.listView5.TabIndex = 3;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.Details;
            this.listView5.DoubleClick += new System.EventHandler(this.listView5_DoubleClick);
            // 
            // listView4
            // 
            this.listView4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listView4.GridLines = true;
            this.listView4.Location = new System.Drawing.Point(529, 3);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(266, 233);
            this.listView4.TabIndex = 2;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            this.listView4.DoubleClick += new System.EventHandler(this.listView4_DoubleClick);
            // 
            // listView3
            // 
            this.listView3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(257, 3);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(266, 233);
            this.listView3.TabIndex = 1;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.DoubleClick += new System.EventHandler(this.listView3_DoubleClick);
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(6, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(245, 233);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.DoubleClick += new System.EventHandler(this.listView2_DoubleClick);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.Location = new System.Drawing.Point(755, 487);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(755, 548);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tabTemplate
            // 
            this.tabTemplate.CausesValidation = false;
            this.tabTemplate.Controls.Add(this.label10);
            this.tabTemplate.Controls.Add(this.cmbModelStyle);
            this.tabTemplate.Controls.Add(this.btnModifyModel);
            this.tabTemplate.Location = new System.Drawing.Point(4, 22);
            this.tabTemplate.Name = "tabTemplate";
            this.tabTemplate.Padding = new System.Windows.Forms.Padding(3);
            this.tabTemplate.Size = new System.Drawing.Size(724, 292);
            this.tabTemplate.TabIndex = 8;
            this.tabTemplate.Text = "病历模板";
            this.tabTemplate.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(102, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "选择模板类型";
            // 
            // cmbModelStyle
            // 
            this.cmbModelStyle.FormattingEnabled = true;
            this.cmbModelStyle.Items.AddRange(new object[] {
            "主诉与病史",
            "检查",
            "X光检查",
            "诊断",
            "治疗计划",
            "治疗",
            "处方",
            "医嘱预约"});
            this.cmbModelStyle.Location = new System.Drawing.Point(188, 126);
            this.cmbModelStyle.Name = "cmbModelStyle";
            this.cmbModelStyle.Size = new System.Drawing.Size(139, 20);
            this.cmbModelStyle.TabIndex = 1;
            // 
            // btnModifyModel
            // 
            this.btnModifyModel.Location = new System.Drawing.Point(403, 123);
            this.btnModifyModel.Name = "btnModifyModel";
            this.btnModifyModel.Size = new System.Drawing.Size(87, 25);
            this.btnModifyModel.TabIndex = 0;
            this.btnModifyModel.Text = "修改模板";
            this.btnModifyModel.UseVisualStyleBackColor = true;
            this.btnModifyModel.Click += new System.EventHandler(this.btnModifyModel_Click);
            // 
            // tabBooking
            // 
            this.tabBooking.Location = new System.Drawing.Point(4, 22);
            this.tabBooking.Name = "tabBooking";
            this.tabBooking.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooking.Size = new System.Drawing.Size(724, 292);
            this.tabBooking.TabIndex = 7;
            this.tabBooking.Text = "医嘱预约";
            this.tabBooking.UseVisualStyleBackColor = true;
            // 
            // tabRecipe
            // 
            this.tabRecipe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabRecipe.Location = new System.Drawing.Point(4, 22);
            this.tabRecipe.Name = "tabRecipe";
            this.tabRecipe.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecipe.Size = new System.Drawing.Size(724, 292);
            this.tabRecipe.TabIndex = 6;
            this.tabRecipe.Text = "处方";
            this.tabRecipe.UseVisualStyleBackColor = true;
            // 
            // tabCure
            // 
            this.tabCure.Controls.Add(this.button6);
            this.tabCure.Controls.Add(this.button7);
            this.tabCure.Controls.Add(this.panel4);
            this.tabCure.Location = new System.Drawing.Point(4, 22);
            this.tabCure.Name = "tabCure";
            this.tabCure.Padding = new System.Windows.Forms.Padding(3);
            this.tabCure.Size = new System.Drawing.Size(724, 292);
            this.tabCure.TabIndex = 5;
            this.tabCure.Text = "治疗";
            this.tabCure.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(584, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "删除当前行";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(499, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 5;
            this.button7.Text = "添加一行";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txtCure);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Location = new System.Drawing.Point(3, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(708, 277);
            this.panel4.TabIndex = 2;
            // 
            // txtCure
            // 
            this.txtCure.Location = new System.Drawing.Point(128, 3);
            this.txtCure.Multiline = true;
            this.txtCure.Name = "txtCure";
            this.txtCure.Size = new System.Drawing.Size(536, 56);
            this.txtCure.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button5.Location = new System.Drawing.Point(3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 56);
            this.button5.TabIndex = 0;
            this.button5.Text = "1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tabPlan
            // 
            this.tabPlan.Location = new System.Drawing.Point(4, 22);
            this.tabPlan.Name = "tabPlan";
            this.tabPlan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlan.Size = new System.Drawing.Size(724, 292);
            this.tabPlan.TabIndex = 4;
            this.tabPlan.Text = "治疗计划";
            this.tabPlan.UseVisualStyleBackColor = true;
            // 
            // tabDiagnose
            // 
            this.tabDiagnose.Controls.Add(this.button3);
            this.tabDiagnose.Controls.Add(this.button4);
            this.tabDiagnose.Controls.Add(this.panel3);
            this.tabDiagnose.Location = new System.Drawing.Point(4, 22);
            this.tabDiagnose.Name = "tabDiagnose";
            this.tabDiagnose.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiagnose.Size = new System.Drawing.Size(724, 292);
            this.tabDiagnose.TabIndex = 3;
            this.tabDiagnose.Text = "诊断";
            this.tabDiagnose.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(625, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "删除当前行";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(540, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "添加一行";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtDiagnose);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(3, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(708, 261);
            this.panel3.TabIndex = 1;
            // 
            // txtDiagnose
            // 
            this.txtDiagnose.Location = new System.Drawing.Point(128, 3);
            this.txtDiagnose.Multiline = true;
            this.txtDiagnose.Name = "txtDiagnose";
            this.txtDiagnose.Size = new System.Drawing.Size(562, 56);
            this.txtDiagnose.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 56);
            this.button2.TabIndex = 0;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabX
            // 
            this.tabX.Location = new System.Drawing.Point(4, 22);
            this.tabX.Name = "tabX";
            this.tabX.Padding = new System.Windows.Forms.Padding(3);
            this.tabX.Size = new System.Drawing.Size(724, 292);
            this.tabX.TabIndex = 2;
            this.tabX.Text = "X光检查";
            this.tabX.UseVisualStyleBackColor = true;
            // 
            // tabCheck
            // 
            this.tabCheck.Controls.Add(this.btnDetete);
            this.tabCheck.Controls.Add(this.btnAdd);
            this.tabCheck.Controls.Add(this.panel2);
            this.tabCheck.Location = new System.Drawing.Point(4, 22);
            this.tabCheck.Name = "tabCheck";
            this.tabCheck.Padding = new System.Windows.Forms.Padding(3);
            this.tabCheck.Size = new System.Drawing.Size(724, 292);
            this.tabCheck.TabIndex = 1;
            this.tabCheck.Text = "检查";
            this.tabCheck.UseVisualStyleBackColor = true;
            // 
            // btnDetete
            // 
            this.btnDetete.Location = new System.Drawing.Point(625, 6);
            this.btnDetete.Name = "btnDetete";
            this.btnDetete.Size = new System.Drawing.Size(86, 23);
            this.btnDetete.TabIndex = 2;
            this.btnDetete.Text = "删除当前行";
            this.btnDetete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(540, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加一行";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtCheckContent1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(3, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 277);
            this.panel2.TabIndex = 0;
            // 
            // txtCheckContent1
            // 
            this.txtCheckContent1.Location = new System.Drawing.Point(128, 3);
            this.txtCheckContent1.Multiline = true;
            this.txtCheckContent1.Name = "txtCheckContent1";
            this.txtCheckContent1.Size = new System.Drawing.Size(549, 56);
            this.txtCheckContent1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabSickHistory
            // 
            this.tabSickHistory.Controls.Add(this.panel1);
            this.tabSickHistory.Location = new System.Drawing.Point(4, 22);
            this.tabSickHistory.Name = "tabSickHistory";
            this.tabSickHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabSickHistory.Size = new System.Drawing.Size(724, 292);
            this.tabSickHistory.TabIndex = 0;
            this.tabSickHistory.Text = "主诉与病史";
            this.tabSickHistory.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblWriter);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtKeywords);
            this.panel1.Controls.Add(this.txtSickHistoryBefore);
            this.panel1.Controls.Add(this.txtSickHistoryNow);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPersonalContext);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 292);
            this.panel1.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(395, 259);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 12);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "填写日期";
            // 
            // lblWriter
            // 
            this.lblWriter.AutoSize = true;
            this.lblWriter.Location = new System.Drawing.Point(179, 259);
            this.lblWriter.Name = "lblWriter";
            this.lblWriter.Size = new System.Drawing.Size(41, 12);
            this.lblWriter.TabIndex = 10;
            this.lblWriter.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "本次就诊病历填写人";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "（用于后期统计分析）";
            // 
            // txtKeywords
            // 
            this.txtKeywords.Location = new System.Drawing.Point(84, 186);
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.Size = new System.Drawing.Size(230, 21);
            this.txtKeywords.TabIndex = 7;
            // 
            // txtSickHistoryBefore
            // 
            this.txtSickHistoryBefore.Location = new System.Drawing.Point(84, 143);
            this.txtSickHistoryBefore.Name = "txtSickHistoryBefore";
            this.txtSickHistoryBefore.Size = new System.Drawing.Size(470, 21);
            this.txtSickHistoryBefore.TabIndex = 6;
            // 
            // txtSickHistoryNow
            // 
            this.txtSickHistoryNow.Location = new System.Drawing.Point(84, 55);
            this.txtSickHistoryNow.Multiline = true;
            this.txtSickHistoryNow.Name = "txtSickHistoryNow";
            this.txtSickHistoryNow.Size = new System.Drawing.Size(470, 74);
            this.txtSickHistoryNow.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "病历关键字";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "既往史";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "现病史";
            // 
            // txtPersonalContext
            // 
            this.txtPersonalContext.Location = new System.Drawing.Point(84, 19);
            this.txtPersonalContext.Name = "txtPersonalContext";
            this.txtPersonalContext.Size = new System.Drawing.Size(470, 21);
            this.txtPersonalContext.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "主诉";
            // 
            // tabCaseProcess
            // 
            this.tabCaseProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabCaseProcess.Controls.Add(this.tabSickHistory);
            this.tabCaseProcess.Controls.Add(this.tabCheck);
            this.tabCaseProcess.Controls.Add(this.tabDiagnose);
            this.tabCaseProcess.Controls.Add(this.tabCure);
            this.tabCaseProcess.Controls.Add(this.tabRecipe);
            this.tabCaseProcess.Controls.Add(this.tabX);
            this.tabCaseProcess.Controls.Add(this.tabPlan);
            this.tabCaseProcess.Controls.Add(this.tabBooking);
            this.tabCaseProcess.Controls.Add(this.tabTemplate);
            this.tabCaseProcess.Location = new System.Drawing.Point(0, 257);
            this.tabCaseProcess.Name = "tabCaseProcess";
            this.tabCaseProcess.SelectedIndex = 0;
            this.tabCaseProcess.Size = new System.Drawing.Size(732, 318);
            this.tabCaseProcess.TabIndex = 0;
            this.tabCaseProcess.SelectedIndexChanged += new System.EventHandler(this.tabCaseProcess_SelectedIndexChanged);
            // 
            // CaseProcView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 577);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlTemplate);
            this.Controls.Add(this.tabCaseProcess);
            this.Controls.Add(this.btnOk);
            this.Name = "CaseProcView";
            this.Text = "患者就诊过程病历";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCaseProcess_Load);
            this.ResizeEnd += new System.EventHandler(this.CaseProcView_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.CaseProcView_SizeChanged);
            this.pnlTemplate.ResumeLayout(false);
            this.tabTemplate.ResumeLayout(false);
            this.tabTemplate.PerformLayout();
            this.tabCure.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabDiagnose.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabCheck.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabSickHistory.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabCaseProcess.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTemplate;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TabPage tabTemplate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbModelStyle;
        private System.Windows.Forms.Button btnModifyModel;
        private System.Windows.Forms.TabPage tabBooking;
        private System.Windows.Forms.TabPage tabRecipe;
        private System.Windows.Forms.TabPage tabCure;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCure;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabPage tabPlan;
        private System.Windows.Forms.TabPage tabDiagnose;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDiagnose;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabX;
        private System.Windows.Forms.TabPage tabCheck;
        private System.Windows.Forms.Button btnDetete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCheckContent1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabSickHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblWriter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKeywords;
        private System.Windows.Forms.TextBox txtSickHistoryBefore;
        private System.Windows.Forms.TextBox txtSickHistoryNow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonalContext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabCaseProcess;
    }
}