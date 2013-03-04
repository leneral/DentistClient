using System;
using System.Windows.Forms;
using DentistryClient.Order;
using Model.Patients;

namespace DentistryClient.MyView
{
    public delegate void ShowSelectedPatientEventHandler(string caseno, string name, string mobilephone);

    public partial class OrderView : Form, IOrderView
    {
        public OrderView()
        {
            InitializeComponent();

            OrderDatetime = DateTime.Now.ToLocalTime().ToString();
            ModifyState = false;
        }

        public OrderView(OrderInfo info)
        {
            InitializeComponent();

            PatientName = info.PatientName;
            CaseNo = info.CaseNo;
            DoctorName = info.DoctorName;
            OrderDatetime = info.OrderDatetime;
            OrderContext = info.OrderContext;

            ModifyState = true;
            btnSave.Text = @"ÐÞ¸Ä";
            btnSearchPatient.Enabled = false;
        }

        public OrderPresenter Presenter { get; set; }
        public bool ModifyState { get; set; }

        public void GetSelectedPatientDeleg(string caseno, string name, string mobilephone)
        {
            CaseNo = caseno;
            PatientName = name;
            MobilePhone = mobilephone;
        }

        #region IOrderView Members

        public string PatientName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public string CaseNo
        {
            get { return lblCaseNo.Text; }
            set { lblCaseNo.Text = value; }
        }

        public string DoctorName
        {
            get { return cmbDoctor.Text; }
            set { cmbDoctor.Text = value; }
        }

        public string NDays
        {
            get { return nudDays.Value.ToString(); }
            set { }
        }

        public string OrderDatetime
        {
            get { return txtDatetime.Text; }
            set { txtDatetime.Text = value; }
        }

        public string OrderContext
        {
            get { return txtOrderContext.Text; }
            set { txtOrderContext.Text = value; }
        }

        public string MobilePhone { get; set; }

        public void Exit()
        {
            Close();
        }

        public void ShowSearchDlg()
        {
            new SearchView(GetSelectedPatientDeleg).ShowDialog();
        }

        #endregion

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            Presenter.OnSearch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Presenter.OnSave();
        }

        private void nudDays_ValueChanged(object sender, EventArgs e)
        {
            Presenter.OnValueChanged();
        }
    }
}