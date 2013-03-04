using System;

namespace DentistryClient.MyView
{
    partial class PreliminaryView
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbPhase = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbDegree = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbIsExcluded = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dateTimePreliminary = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbFaceWoundHistory = new System.Windows.Forms.ComboBox();
            this.cmbIsCureing = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbPhase);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.cmbDegree);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.cmbType);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.cmbIsExcluded);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.dateTimePreliminary);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cmbFaceWoundHistory);
            this.groupBox2.Controls.Add(this.cmbIsCureing);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(28, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 192);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "治疗信息";
            // 
            // cmbPhase
            // 
            this.cmbPhase.FormattingEnabled = true;
            this.cmbPhase.Items.AddRange(new object[] {
            "早期",
            "早期恒牙期",
            "晚期"});
            this.cmbPhase.Location = new System.Drawing.Point(108, 114);
            this.cmbPhase.Name = "cmbPhase";
            this.cmbPhase.Size = new System.Drawing.Size(110, 20);
            this.cmbPhase.TabIndex = 39;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(18, 117);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 14);
            this.label21.TabIndex = 38;
            this.label21.Text = "换牙期：";
            // 
            // cmbDegree
            // 
            this.cmbDegree.FormattingEnabled = true;
            this.cmbDegree.Items.AddRange(new object[] {
            "轻度",
            "中度",
            "严重"});
            this.cmbDegree.Location = new System.Drawing.Point(395, 75);
            this.cmbDegree.Name = "cmbDegree";
            this.cmbDegree.Size = new System.Drawing.Size(102, 20);
            this.cmbDegree.TabIndex = 37;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(232, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 14);
            this.label20.TabIndex = 36;
            this.label20.Text = "严重程度：";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "前牙反咬颌",
            "前牙旋转",
            "前牙间隙宽",
            "前牙拥挤",
            "深覆盖，深覆颌",
            "Ⅱ类错颌",
            "后牙反咬颌",
            "露龈笑",
            "开颌"});
            this.cmbType.Location = new System.Drawing.Point(108, 75);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(110, 20);
            this.cmbType.TabIndex = 35;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(18, 78);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 14);
            this.label19.TabIndex = 34;
            this.label19.Text = "错颌类型：";
            // 
            // cmbIsExcluded
            // 
            this.cmbIsExcluded.FormattingEnabled = true;
            this.cmbIsExcluded.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbIsExcluded.Items.AddRange(new object[] {
            "骨性Angle Ⅲ类错合",
            "严重的骨性Angle Ⅱ类错合",
            "上颚阻生牙",
            "先天遗失恒牙或过早丢失的乳牙或恒牙",
            "严重旋转的前磨牙或磨牙"});
            this.cmbIsExcluded.Location = new System.Drawing.Point(395, 114);
            this.cmbIsExcluded.Name = "cmbIsExcluded";
            this.cmbIsExcluded.Size = new System.Drawing.Size(103, 20);
            this.cmbIsExcluded.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(233, 117);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 14);
            this.label18.TabIndex = 32;
            this.label18.Text = "是否排除病历：";
            // 
            // dateTimePreliminary
            // 
            this.dateTimePreliminary.Location = new System.Drawing.Point(108, 155);
            this.dateTimePreliminary.Name = "dateTimePreliminary";
            this.dateTimePreliminary.Size = new System.Drawing.Size(110, 21);
            this.dateTimePreliminary.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(18, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 14);
            this.label13.TabIndex = 27;
            this.label13.Text = "初诊时间：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(17, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 14);
            this.label11.TabIndex = 22;
            this.label11.Text = "面部创伤史：";
            // 
            // cmbFaceWoundHistory
            // 
            this.cmbFaceWoundHistory.FormattingEnabled = true;
            this.cmbFaceWoundHistory.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cmbFaceWoundHistory.Location = new System.Drawing.Point(108, 34);
            this.cmbFaceWoundHistory.Name = "cmbFaceWoundHistory";
            this.cmbFaceWoundHistory.Size = new System.Drawing.Size(110, 20);
            this.cmbFaceWoundHistory.TabIndex = 25;
            // 
            // cmbIsCureing
            // 
            this.cmbIsCureing.FormattingEnabled = true;
            this.cmbIsCureing.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cmbIsCureing.Location = new System.Drawing.Point(395, 34);
            this.cmbIsCureing.Name = "cmbIsCureing";
            this.cmbIsCureing.Size = new System.Drawing.Size(100, 20);
            this.cmbIsCureing.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(232, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 14);
            this.label12.TabIndex = 23;
            this.label12.Text = "正在进行其他牙科治疗：";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(346, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(448, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 27);
            this.label1.TabIndex = 40;
            this.label1.Text = "请填写初诊信息:";
            // 
            // PreliminaryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(553, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "PreliminaryView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "初诊信息";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbPhase;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbDegree;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dateTimePreliminary;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbFaceWoundHistory;
        private System.Windows.Forms.ComboBox cmbIsCureing;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIsExcluded;
    }
}