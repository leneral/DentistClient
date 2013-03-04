using System;
using System.Windows.Forms;
using DentistryClient.Preliminary;

namespace DentistryClient.MyView
{
    public partial class PreliminaryView : Form, IPreliminaryView
    {
        private readonly FlushHistoryListEventHandler _flushDeleg;

        public PreliminaryView(string caseNo, string patientName, FlushHistoryListEventHandler flushDeleg = null)
        {
            InitializeComponent();

            PatientName = patientName;
            _flushDeleg = flushDeleg;
            CaseNo = caseNo;
        }

        public PreliminaryPresenter Presenter { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Presenter.OnSave();

            if (_flushDeleg != null)
            {
                _flushDeleg();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Presenter.OnClose();
        }

        #region IPreliminaryView Members

        public string PatientName { get; set; }

        public string CaseNo { get; private set; }

        public string ExludedCase
        {
            get { return cmbIsExcluded.Text; }
            set { cmbIsExcluded.Text = value; }
        }

        public string Extent
        {
            get { return cmbDegree.Text; }
            set { cmbDegree.Text = value; }
        }

        public string FaceWoundHistory
        {
            get { return cmbFaceWoundHistory.Text; }
            set { cmbFaceWoundHistory.Text = value; }
        }

        public string IsCuring
        {
            get { return cmbIsCureing.Text; }
            set { cmbIsCureing.Text = value; }
        }

        public string Periods
        {
            get { return cmbPhase.Text; }
            set { cmbPhase.Text = value; }
        }

        public DateTime PreliminaryDate
        {
            get { return dateTimePreliminary.Value; }
            set { dateTimePreliminary.Value = value; }
        }

        public string Type
        {
            get { return cmbType.Text; }
            set { cmbType.Text = value; }
        }


        public void Exit()
        {
            Close();
        }

        #endregion
    }
}