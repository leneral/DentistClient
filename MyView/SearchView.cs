using System;
using System.Data;
using System.Windows.Forms;
using DentistryClient.Search;

namespace DentistryClient.MyView
{
    public partial class SearchView : Form, ISearchView
    {
        private readonly ShowSelectedPatientEventHandler _eventHandler;

        public SearchView(ShowSelectedPatientEventHandler eventHandler)
        {
            InitializeComponent();

            _eventHandler = eventHandler;
        }

        public SearchPresenter Presenter { get; set; }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = Presenter.OnSearch();

            lvPatientsInfo.Items.Clear();
            lvPatientsInfo.BeginUpdate();

            foreach (DataRow r in dt.Rows)
            {
                var item = new ListViewItem();
                item.SubItems[0].Text = r[0].ToString();

                item.SubItems.Add(r[1].ToString());
                string tmp = r[2].ToString() == "1" ? "ÄÐ" : "Å®";
                item.SubItems.Add(tmp);
                item.SubItems.Add(r[3].ToString());
                item.SubItems.Add(r[17].ToString());
                item.SubItems.Add(r[8].ToString());
                item.SubItems.Add("");

                lvPatientsInfo.Items.Add(item);
            }
            lvPatientsInfo.EndUpdate();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Presenter.OnOk();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Presenter.OnClose();
        }

        private void rdoName_CheckedChanged(object sender, EventArgs e)
        {
            Presenter.OnRadNameChanged();
        }

        private void rdoCaseNo_CheckedChanged(object sender, EventArgs e)
        {
            Presenter.OnRadCaseNoChanged();
        }

        #region ISearchView Members

        public string SelectedName
        {
            get { return lvPatientsInfo.SelectedItems[0].SubItems[1].Text; }
        }

        public string SelectedCaseNo
        {
            get { return lvPatientsInfo.SelectedItems[0].SubItems[0].Text; }
        }

        public string SelectedMobilePhone
        {
            get { return lvPatientsInfo.SelectedItems[0].SubItems[5].Text; }
        }

        public string CaseNo
        {
            get { return txtCaseNo.Text; }
            set { txtCaseNo.Text = value; }
        }

        public string PatientName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public bool NameRadioState
        {
            get { return rdoName.Checked; }
            set { rdoName.Checked = value; }
        }

        public bool CaseNoRadioState
        {
            get { return rdoCaseNo.Checked; }
            set { rdoCaseNo.Checked = value; }
        }

        public bool NameTextState
        {
            get { return txtName.Enabled; }
            set { txtName.Enabled = value; }
        }

        public bool CaseNoTextState
        {
            get { return txtCaseNo.Enabled; }
            set { txtCaseNo.Enabled = value; }
        }

        public void Ok()
        {
            _eventHandler(SelectedCaseNo, SelectedName, SelectedMobilePhone);
            Close();
        }

        public void Exit()
        {
            Close();
        }

        #endregion
    }
}