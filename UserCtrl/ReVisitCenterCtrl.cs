using System;
using System.Windows.Forms;
using DentistryClient.ReVisit;

namespace DentistryClient.UserCtrl
{
    public partial class ReVisitCenterCtrl : UserControl, IReVisitCtrl
    {
        public ReVisitCtrlPresenter Presenter { get; set; }

        public ReVisitCenterCtrl()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Presenter.OnNewVisit();
        }

        public string Caseno { get; set; }
        public DateTime FromDate
        {
            get { return dtpFrom.Value; }
            set { dtpFrom.Value = value; }
        }
        public DateTime ToDate
        {
            get { return dtpTo.Value; }
            set { dtpTo.Value = value; }
        }
    }
}
