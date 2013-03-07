using System.Windows.Forms;
using DentistryClient.ReVisit;

namespace DentistryClient.MyView
{
    public partial class ReVisitView : Form, IReVisitView
    {
        public ReVisitViewPresenter Presenter { get; set; }

        public ReVisitView(string caseno)
        {
            InitializeComponent();

            Caseno = caseno;
        }

        private void ReVisitView_Load(object sender, System.EventArgs e)
        {
            Presenter.SearchVisitorInfo();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            Presenter.OnSave();
        }

        #region IReVisitView Members

        public string Caseno
        {
            get { return lblCaseno.Text; }
            set { lblCaseno.Text = value; }
        }
        public string Sex
        {
            get { return lblSex.Text; }
            set { lblSex.Text = value; }
        }
        public string Age
        {
            get { return lblAge.Text; }
            set { lblAge.Text = value; }
        }
        public string Doctor
        {
            get { return lblDoctor.Text; }
            set { lblDoctor.Text = value; }
        }

        public string Date
        {
            get { return lblDate.Text; }
            set { lblDate.Text = value; }
        }

        public string IsVisit
        {
            get { return cmbIsVisit.Text; }
            set { cmbIsVisit.Text = value; }
        }
        public string Context
        {
            get { return cmbContext.Text; }
            set { cmbContext.Text = value; }
        }
        public string Service
        {
            get { return cmbService.Text; }
            set { cmbService.Text = value; }
        }
        public string Quality
        {
            get { return cmbQuality.Text; }
            set { cmbQuality.Text = value; }
        }
        public string Remark
        {
            get { return cmbRemark.Text; }
            set { cmbRemark.Text = value; }
        }
        #endregion

    }
}
