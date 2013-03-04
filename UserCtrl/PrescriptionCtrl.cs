using System;
using System.Data;
using System.Windows.Forms;
using DentistryClient.Prescription;

namespace DentistryClient.UserCtrl
{
    public partial class PrescriptionCtrl : UserControl, IPrescriptionView
    {
        public PrescriptionPresenter Presenter { get; set; }
        public PrescriptionCtrl()
        {
            InitializeComponent();
        }

        private void PrescriptionCtrl_Load(object sender, EventArgs e)
        {
            DataTable dt = Presenter.QueryPrescription();
            dgvPrescription.DataSource = dt;

            dgvPrescription.Columns["medicname"].HeaderText = "药品名称";
            dgvPrescription.Columns["standard"].HeaderText = "规格";
            dgvPrescription.Columns["unit"].HeaderText = "单位";
            dgvPrescription.Columns["mount"].HeaderText = "数量";
            dgvPrescription.Columns["usage"].HeaderText = "用法";
            dgvPrescription.Columns["price"].HeaderText = "价格";
            dgvPrescription.Columns["grossamount"].HeaderText = "?";
            dgvPrescription.Columns["doctor"].HeaderText = "医生";
        }
    }
}