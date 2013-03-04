namespace DentistryClient.MyView
{
    partial class SelectionView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvTodayPatients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhPatientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lvAllPatients = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhPatientsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnselect = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvTodayPatients);
            this.groupBox1.Location = new System.Drawing.Point(52, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 442);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "今日患者";
            // 
            // lvTodayPatients
            // 
            this.lvTodayPatients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.clhPatientName});
            this.lvTodayPatients.FullRowSelect = true;
            this.lvTodayPatients.GridLines = true;
            this.lvTodayPatients.Location = new System.Drawing.Point(0, 20);
            this.lvTodayPatients.MultiSelect = false;
            this.lvTodayPatients.Name = "lvTodayPatients";
            this.lvTodayPatients.Size = new System.Drawing.Size(226, 421);
            this.lvTodayPatients.TabIndex = 0;
            this.lvTodayPatients.UseCompatibleStateImageBehavior = false;
            this.lvTodayPatients.View = System.Windows.Forms.View.Details;
            this.lvTodayPatients.SelectedIndexChanged += new System.EventHandler(this.lvTodayPatients_SelectedIndexChanged);
            this.lvTodayPatients.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvTodayPatients_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "病例号";
            this.columnHeader1.Width = 90;
            // 
            // clhPatientName
            // 
            this.clhPatientName.Text = "患者姓名";
            this.clhPatientName.Width = 114;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.lvAllPatients);
            this.groupBox2.Location = new System.Drawing.Point(287, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 442);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "全部患者";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "患者姓名";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(22, 58);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(146, 21);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(199, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // lvAllPatients
            // 
            this.lvAllPatients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.clhPatientsName});
            this.lvAllPatients.FullRowSelect = true;
            this.lvAllPatients.GridLines = true;
            this.lvAllPatients.Location = new System.Drawing.Point(0, 127);
            this.lvAllPatients.Name = "lvAllPatients";
            this.lvAllPatients.Size = new System.Drawing.Size(280, 314);
            this.lvAllPatients.TabIndex = 1;
            this.lvAllPatients.UseCompatibleStateImageBehavior = false;
            this.lvAllPatients.View = System.Windows.Forms.View.Details;
            this.lvAllPatients.SelectedIndexChanged += new System.EventHandler(this.lvAllPatients_SelectedIndexChanged);
            this.lvAllPatients.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvAllPatients_MouseClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "病例号";
            this.columnHeader2.Width = 105;
            // 
            // clhPatientsName
            // 
            this.clhPatientsName.Text = "患者姓名";
            this.clhPatientsName.Width = 142;
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(382, 494);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 2;
            this.btnselect.Text = "确认";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(486, 494);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // SelectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(601, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.groupBox1);
            this.Name = "SelectionView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择患者";
            this.Load += new System.EventHandler(this.FormPatientSelect_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.ListView lvTodayPatients;
        private System.Windows.Forms.ListView lvAllPatients;
        private System.Windows.Forms.ColumnHeader clhPatientName;
        private System.Windows.Forms.ColumnHeader clhPatientsName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;

    }
}