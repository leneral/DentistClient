using System;
using System.Data;
using System.Windows.Forms;

namespace DentistryClient.MyView
{
    partial class ClinicCasesView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlBtnContainer = new System.Windows.Forms.Panel();
            this.btnFillCase = new System.Windows.Forms.Button();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxScore = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlHistoryCase = new System.Windows.Forms.Panel();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnSearchImages = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.btnImportImage = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNewCase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClinicDate = new System.Windows.Forms.Label();
            this.lblSuffererName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlHistoryCase.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlHistoryCase);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 775);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.picImage);
            this.panel4.Location = new System.Drawing.Point(904, 109);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(458, 654);
            this.panel4.TabIndex = 7;
            // 
            // picImage
            // 
            this.picImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picImage.Location = new System.Drawing.Point(31, 13);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(427, 654);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pnlBtnContainer);
            this.panel3.Controls.Add(this.btnFillCase);
            this.panel3.Controls.Add(this.cbxType);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbxScore);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(207, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(656, 654);
            this.panel3.TabIndex = 6;
            // 
            // pnlBtnContainer
            // 
            this.pnlBtnContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBtnContainer.Location = new System.Drawing.Point(16, 80);
            this.pnlBtnContainer.Name = "pnlBtnContainer";
            this.pnlBtnContainer.Size = new System.Drawing.Size(621, 516);
            this.pnlBtnContainer.TabIndex = 18;
            // 
            // btnFillCase
            // 
            this.btnFillCase.Location = new System.Drawing.Point(379, 51);
            this.btnFillCase.Name = "btnFillCase";
            this.btnFillCase.Size = new System.Drawing.Size(75, 23);
            this.btnFillCase.TabIndex = 17;
            this.btnFillCase.Text = "填写记录";
            this.btnFillCase.UseVisualStyleBackColor = true;
            this.btnFillCase.Click += new System.EventHandler(this.btnFillCase_Click);
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "安氏一类",
            "安氏二类",
            "安氏三类"});
            this.cbxType.Location = new System.Drawing.Point(189, 52);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 22);
            this.cbxType.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 14);
            this.label6.TabIndex = 15;
            this.label6.Text = "一. 选择病情范文类别";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(562, 602);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(466, 602);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(296, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "就诊记录";
            // 
            // cbxScore
            // 
            this.cbxScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxScore.FormattingEnabled = true;
            this.cbxScore.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxScore.Location = new System.Drawing.Point(357, 603);
            this.cbxScore.Name = "cbxScore";
            this.cbxScore.Size = new System.Drawing.Size(55, 22);
            this.cbxScore.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 611);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "评分：";
            // 
            // pnlHistoryCase
            // 
            this.pnlHistoryCase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlHistoryCase.BackColor = System.Drawing.Color.Lavender;
            this.pnlHistoryCase.Controls.Add(this.btn10);
            this.pnlHistoryCase.Controls.Add(this.btn9);
            this.pnlHistoryCase.Controls.Add(this.btn8);
            this.pnlHistoryCase.Controls.Add(this.btn7);
            this.pnlHistoryCase.Controls.Add(this.btn6);
            this.pnlHistoryCase.Controls.Add(this.btn5);
            this.pnlHistoryCase.Controls.Add(this.btn4);
            this.pnlHistoryCase.Controls.Add(this.btn3);
            this.pnlHistoryCase.Controls.Add(this.btn2);
            this.pnlHistoryCase.Controls.Add(this.btn1);
            this.pnlHistoryCase.Controls.Add(this.btnSearchImages);
            this.pnlHistoryCase.Location = new System.Drawing.Point(3, 109);
            this.pnlHistoryCase.Name = "pnlHistoryCase";
            this.pnlHistoryCase.Size = new System.Drawing.Size(198, 654);
            this.pnlHistoryCase.TabIndex = 5;
            // 
            // btn10
            // 
            this.btn10.FlatAppearance.BorderSize = 0;
            this.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10.Location = new System.Drawing.Point(-2, 414);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(201, 47);
            this.btn10.TabIndex = 10;
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new EventHandler(this.btnList_Click);
            // 
            // btn9
            // 
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Location = new System.Drawing.Point(-2, 368);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(201, 47);
            this.btn9.TabIndex = 9;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new EventHandler(this.btnList_Click);
            // 
            // btn8
            // 
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Location = new System.Drawing.Point(-3, 322);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(201, 47);
            this.btn8.TabIndex = 8;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new EventHandler(this.btnList_Click);
            // 
            // btn7
            // 
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Location = new System.Drawing.Point(-2, 276);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(201, 47);
            this.btn7.TabIndex = 7;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new EventHandler(this.btnList_Click);
            // 
            // btn6
            // 
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Location = new System.Drawing.Point(-2, 230);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(201, 47);
            this.btn6.TabIndex = 6;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new EventHandler(this.btnList_Click);
            // 
            // btn5
            // 
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Location = new System.Drawing.Point(-3, 184);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(201, 47);
            this.btn5.TabIndex = 5;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new EventHandler(this.btnList_Click);
            // 
            // btn4
            // 
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Location = new System.Drawing.Point(-3, 138);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(201, 47);
            this.btn4.TabIndex = 4;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new EventHandler(this.btnList_Click);
            // 
            // btn3
            // 
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(-3, 92);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(201, 47);
            this.btn3.TabIndex = 3;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new EventHandler(this.btnList_Click);
            // 
            // btn2
            // 
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(-3, 46);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(201, 47);
            this.btn2.TabIndex = 2;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new EventHandler(this.btnList_Click);
            // 
            // btn1
            // 
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(-3, 0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(201, 47);
            this.btn1.TabIndex = 1;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click+=new EventHandler(this.btnList_Click);
            // 
            // btnSearchImages
            // 
            this.btnSearchImages.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSearchImages.Location = new System.Drawing.Point(57, 604);
            this.btnSearchImages.Name = "btnSearchImages";
            this.btnSearchImages.Size = new System.Drawing.Size(75, 23);
            this.btnSearchImages.TabIndex = 0;
            this.btnSearchImages.Text = "查询照片";
            this.btnSearchImages.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnImportExcel);
            this.panel2.Controls.Add(this.btnImportImage);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAddNewCase);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblClinicDate);
            this.panel2.Controls.Add(this.lblSuffererName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1279, 100);
            this.panel2.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(917, 65);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnImportExcel.Location = new System.Drawing.Point(775, 65);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(102, 23);
            this.btnImportExcel.TabIndex = 11;
            this.btnImportExcel.Text = "导入Excel";
            this.btnImportExcel.UseVisualStyleBackColor = true;
            // 
            // btnImportImage
            // 
            this.btnImportImage.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnImportImage.Location = new System.Drawing.Point(775, 23);
            this.btnImportImage.Name = "btnImportImage";
            this.btnImportImage.Size = new System.Drawing.Size(102, 23);
            this.btnImportImage.TabIndex = 10;
            this.btnImportImage.Text = "导入相片";
            this.btnImportImage.UseVisualStyleBackColor = true;
            this.btnImportImage.Click += new System.EventHandler(this.btnImportImage_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Location = new System.Drawing.Point(917, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "删除当前";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAddNewCase
            // 
            this.btnAddNewCase.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddNewCase.Location = new System.Drawing.Point(628, 40);
            this.btnAddNewCase.Name = "btnAddNewCase";
            this.btnAddNewCase.Size = new System.Drawing.Size(102, 23);
            this.btnAddNewCase.TabIndex = 7;
            this.btnAddNewCase.Text = "填写初诊信息";
            this.btnAddNewCase.UseVisualStyleBackColor = true;
            this.btnAddNewCase.Click += new System.EventHandler(this.btnAddNewCase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(205, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "患者姓名：";
            // 
            // lblClinicDate
            // 
            this.lblClinicDate.AutoSize = true;
            this.lblClinicDate.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClinicDate.Location = new System.Drawing.Point(456, 45);
            this.lblClinicDate.Name = "lblClinicDate";
            this.lblClinicDate.Size = new System.Drawing.Size(0, 12);
            this.lblClinicDate.TabIndex = 3;
            // 
            // lblSuffererName
            // 
            this.lblSuffererName.AutoSize = true;
            this.lblSuffererName.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSuffererName.Location = new System.Drawing.Point(287, 45);
            this.lblSuffererName.Name = "lblSuffererName";
            this.lblSuffererName.Size = new System.Drawing.Size(0, 12);
            this.lblSuffererName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(382, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "就诊时间：";
            // 
            // ClinicCasesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 778);
            this.Controls.Add(this.panel1);
            this.Name = "ClinicCasesView";
            this.Text = "患者就诊记录";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ClinicCasesView_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlHistoryCase.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClinicDate;
        private System.Windows.Forms.Label lblSuffererName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlHistoryCase;
        private System.Windows.Forms.Button btnAddNewCase;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnImportImage;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearchImages;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Button btnFillCase;
        private System.Windows.Forms.Panel pnlBtnContainer;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
    }
}