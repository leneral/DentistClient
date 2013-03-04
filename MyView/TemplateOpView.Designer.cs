namespace DentistryClient.MyView
{
    partial class TemplateOpView
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
            this.btnCertain = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbContext = new System.Windows.Forms.ComboBox();
            this.dgwDisplay = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCertain
            // 
            this.btnCertain.Location = new System.Drawing.Point(229, 519);
            this.btnCertain.Name = "btnCertain";
            this.btnCertain.Size = new System.Drawing.Size(82, 20);
            this.btnCertain.TabIndex = 8;
            this.btnCertain.Text = "确定";
            this.btnCertain.UseVisualStyleBackColor = true;
            this.btnCertain.Click += new System.EventHandler(this.btnCertain_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(365, 519);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 20);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbContext);
            this.groupBox1.Controls.Add(this.dgwDisplay);
            this.groupBox1.Location = new System.Drawing.Point(15, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 492);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改和添加条目，单击确定保存";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "选择要修改的条目：";
            // 
            // cmbContext
            // 
            this.cmbContext.FormattingEnabled = true;
            this.cmbContext.Items.AddRange(new object[] {
            "主诉",
            "既往病史",
            "现病史",
            "病历关键字"});
            this.cmbContext.Location = new System.Drawing.Point(333, 53);
            this.cmbContext.Name = "cmbContext";
            this.cmbContext.Size = new System.Drawing.Size(128, 20);
            this.cmbContext.TabIndex = 2;
            this.cmbContext.SelectedIndexChanged += new System.EventHandler(this.cmbContext_SelectedIndexChanged);
            // 
            // dgwDisplay
            // 
            this.dgwDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDisplay.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDisplay.ColumnHeadersVisible = false;
            this.dgwDisplay.Location = new System.Drawing.Point(18, 125);
            this.dgwDisplay.MultiSelect = false;
            this.dgwDisplay.Name = "dgwDisplay";
            this.dgwDisplay.RowHeadersVisible = false;
            this.dgwDisplay.RowHeadersWidth = 587;
            this.dgwDisplay.RowTemplate.Height = 23;
            this.dgwDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDisplay.Size = new System.Drawing.Size(587, 337);
            this.dgwDisplay.TabIndex = 0;
            // 
            // TemplateOpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(677, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCertain);
            this.Name = "TemplateOpView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主诉和病历模板";
            this.Load += new System.EventHandler(this.FormChiefCaseHistory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCertain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgwDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbContext;
    }
}