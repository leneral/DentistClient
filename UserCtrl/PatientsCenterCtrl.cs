using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using DentistryClient.DentistrySupervisor;
using Model.Patients;

namespace DentistryClient.UserCtrl
{
    public partial class PatientsCenterCtrl : UserControl, IPatientsCenterView
    {
        public PatientsCenterPresenter Presenter { get; set; }
        public PatientsCenterCtrl()
        {
            InitializeComponent();
        }

        private void btnEasySearch_Click(object sender, EventArgs e)
        {
            DataTable dt = Presenter.Search();

            lvPatientsInfo.Items.Clear();
            lvPatientsInfo.BeginUpdate();
            foreach (DataRow r in dt.Rows)
            {
                lvPatientsInfo.Items.Add(CreatNewListViewItem(r));
            }
            lvPatientsInfo.EndUpdate();
        }

        private void btnAdvanceSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = Presenter.Search();

            lvPatientsInfo.Items.Clear();
            lvPatientsInfo.BeginUpdate();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[17].ToString() != string.Empty)
                {
                    DateTime datetime = DateTime.Parse(dr[17].ToString());
                    if (datetime >= StartDiagTime && datetime <= EndDiagTime)
                    {
                        lvPatientsInfo.Items.Add(CreatNewListViewItem(dr));
                    }
                }  
            }
            lvPatientsInfo.EndUpdate();
        }

        private ListViewItem CreatNewListViewItem(DataRow datarow)
        {
            var li = new ListViewItem();
            li.SubItems[0].Text = datarow[0].ToString();
            li.SubItems.Add(datarow[1].ToString());
            string tmp = datarow[2].ToString() == "1" ? "男" : "女";
            li.SubItems.Add(tmp);
            li.SubItems.Add(datarow[3].ToString());
            li.SubItems.Add(datarow[8].ToString());
            li.SubItems.Add(datarow[10].ToString());
            li.SubItems.Add(datarow[17].ToString());
            return li;
        }

        private void chkName_CheckedChanged(object sender, EventArgs e)
        {
            Presenter.OnPatientsCheckedChanged();
        }

        private void chkCaseNo_CheckedChanged(object sender, EventArgs e)
        {
            Presenter.OnCaseNoCheckedChanged();
        }

        private void chkSex_CheckedChanged(object sender, EventArgs e)
        {
            Presenter.OnSexCheckedChanged();
        }

        private void chkAge_CheckedChanged(object sender, EventArgs e)
        {
            Presenter.OnAgeCheckedChanged();
        }

        private void chkHospital_CheckedChanged(object sender, EventArgs e)
        {
            Presenter.OnHospitalCheckedChanged();
        }

        private void chkCond1_CheckedChanged(object sender, EventArgs e)
        {
            Presenter.OnCond1CheckedChanged();
        }

        private void lvPatientsInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPatientsInfo.SelectedItems.Count > 0)
                SelectedCaseNo = lvPatientsInfo.SelectedItems[0].SubItems[0].Text;
        }

        public void ShowPatientInfoDlg(PatientsInfo info)
        {
        }

        private void PatientsCenterCtrl_Load(object sender, EventArgs e)
        {
            cmbTimeCond.Text = cmbTimeCond.Items[0].ToString();
        }

        public string SelectedCaseNo { get; set; }

        #region IPatientsCenterView

        public string CaseNo
        {
            get { return txtCaseNo.Text; }
            set { txtCaseNo.Text = value; }
        }

        public string Patient
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string Sex
        {
            get { return  cmbSex.Text; }
            set { cmbSex.Text = value; }
        }

        public string Hospital
        {
            get { return cmbHospital.Text; }
            set { cmbHospital.Text = value; }
        }

        public DateTime StartDiagTime
        {
            get { return dtpFromDate.Value.Date; }
            set { }
        }

        public DateTime EndDiagTime
        {
            get { return dptEndDate.Value.Date; }
            set { }
        }

        public string Age
        {
            get { return  numAge.Value.ToString(CultureInfo.InvariantCulture); }
            set { numAge.Text = value; }
        }

        public bool PatientTextState
        {
            get { return txtName.Enabled; }
            set { txtName.Enabled = value; }
        }

        public bool CaseNoTextState
        {
            get { return txtCaseNo.Enabled; }
            set { txtCaseNo.Enabled = value; }
        }

        public bool ClinckRadioState
        {
            get { return cmbHospital.Enabled; }
            set { cmbHospital.Enabled = value; }
        }

        public bool SexCmbState
        {
            get { return cmbSex.Enabled; }
            set { cmbSex.Enabled = value; }
        }

        public bool AgeNumState
        {
            get { return numAge.Enabled; }
            set { numAge.Enabled = value; }
        }

        public bool HospitalCmbState
        {
            get { return cmbHospital.Enabled; }
            set { cmbHospital.Enabled = value; }
        }

        public bool CondCmbState
        {
            get { return cmbTimeCond.Enabled; }
            set { cmbTimeCond.Enabled = value; }
        }

        public bool FromDateCmbState
        {
            get { return dtpFromDate.Enabled; }
            set { dtpFromDate.Enabled = value; }
        }
        public bool EndDateCmbState
        {
            get { return dptEndDate.Enabled; }
            set { dptEndDate.Enabled = value; }
        }

        public int TabSelectedIndex
        {
            get { return ttabControl3.SelectedIndex; }
            set { }
        }

        #endregion

       
    }
}