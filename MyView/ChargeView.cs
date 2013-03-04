using System;
using System.Windows.Forms;
using DentistryClient.Salary;

namespace DentistryClient.MyView
{
    public partial class ChargeView : Form, IChargeView
    {
        public ChargeView()
        {
            InitializeComponent();
        }

        public ChargeView(string caseno, string name, string sex)
        {
            InitializeComponent();

            CaseNo = caseno;
            PatientName = name;
            Sex = sex;
        }

        public ChargePresenter Presenter { get; set; }

        public string CaseNo { get; set; }

        public string PatientName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public string Sex
        {
            get { return lblSex.Text; }
            set { lblSex.Text = value; }
        }

        public string GeneralCharge
        {
            get { return txtGeneralCharge.Text; }
            set { txtGeneralCharge.Text = value; }
        }

        public string CleanCharge
        {
            get { return txtCleanCharge.Text; }
            set { txtCleanCharge.Text = value; }
        }

        public string InMouthCharge
        {
            get { return txtInMouthCharge.Text; }
            set { txtInMouthCharge.Text = value; }
        }

        public string PullToothCharge
        {
            get { return txtPullToothCharge.Text; }
            set { txtPullToothCharge.Text = value; }
        }

        public string SurgeryCharge
        {
            get { return txtSurgeryCharge.Text; }
            set { txtSurgeryCharge.Text = value; }
        }

        public string FixRestoreCharge
        {
            get { return txtFixRestoreCharge.Text; }
            set { txtFixRestoreCharge.Text = value; }
        }

        public string RestoreCharge
        {
            get { return txtRestoreCharge.Text; }
            set { txtRestoreCharge.Text = value; }
        }

        public string OrthodonticCharge
        {
            get { return txtOrthodonticCharge.Text; }
            set { txtOrthodonticCharge.Text = value; }
        }

        public string EmitCharge
        {
            get { return txtEmitCharge.Text; }
            set { txtEmitCharge.Text = value; }
        }

        public string DrugCharge
        {
            get { return txtDrugCharge.Text; }
            set { txtDrugCharge.Text = value; }
        }

        public string ForeignMedicineCharge
        {
            get { return txtForeignMedicineCharge.Text; }
            set { txtForeignMedicineCharge.Text = value; }
        }

        public string PlantToothCharge
        {
            get { return txtPlantToothCharge.Text; }
            set { txtPlantToothCharge.Text = value; }
        }

        public string OtherCharge
        {
            get { return txtOtherCharge.Text; }
            set { txtOtherCharge.Text = value; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Presenter.OnSave();
        }
    }
}