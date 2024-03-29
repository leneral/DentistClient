﻿using System;
using System.Data;
using System.Windows.Forms;
using DentistryClient.DentistrySupervisor;
using Model.Patients;

namespace DentistryClient.UserCtrl
{
    public partial class PatientsCenterCtrl : UserControl, IPatientsCenterView
    {
        public PatientsCenterCtrl()
        {
            InitializeComponent();
        }

        public PatientsCenterPresenter Presenter { get; set; }

        public void Exit()
        {
        }

        public void ShowPatientInfoDlg(PatientsInfo info)
        {
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

        public byte Sex
        {
            get { return (byte) cmbSex.SelectedIndex; }
            set { cmbSex.SelectedIndex = value; }
        }

        public string Hospital
        {
            get { return cmbHospital.Text; }
            set { cmbHospital.Text = value; }
        }

        public int Age
        {
            get { return (int) numAge.Value; }
            set { }
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

        public int TabSelectedIndex
        {
            get { return ttabControl3.SelectedIndex; }
            set { }
        }

        #endregion

        private void PatientsCenterCtrl_Load(object sender, EventArgs e)
        {
        }

        private void btnEasySearch_Click(object sender, EventArgs e)
        {
            DataTable dt = Presenter.Search();

            lvPatientsInfo.Items.Clear();
            lvPatientsInfo.BeginUpdate();

            foreach (DataRow r in dt.Rows)
            {
                var li = new ListViewItem();
                li.SubItems[0].Text = r[0].ToString();

                li.SubItems.Add(r[1].ToString());
                string tmp = r[2].ToString() == "1" ? "男" : "女";
                li.SubItems.Add(tmp);
                li.SubItems.Add(r[3].ToString());
                li.SubItems.Add(r[8].ToString());
                li.SubItems.Add(r[10].ToString());
                li.SubItems.Add(r[17].ToString());
                lvPatientsInfo.Items.Add(li);
            }
            lvPatientsInfo.EndUpdate();
        }

        private void btnAdvanceSearch_Click(object sender, EventArgs e)
        {
            btnEasySearch_Click(sender, e);
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
        }

        private void chkCond2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void lvPatientsInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPatientsInfo.SelectedItems.Count > 0)
                SelectedCaseNo = lvPatientsInfo.SelectedItems[0].SubItems[0].Text;
        }
    }
}