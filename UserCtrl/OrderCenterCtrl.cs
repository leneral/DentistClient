using System;
using System.Data;
using System.Windows.Forms;
using DentistryClient.DentistrySupervisor;
using Model.Message;
using Model.Patients;
using Model.Util;

namespace DentistryClient.UserCtrl
{
    public partial class OrderCenterCtrl : UserControl, IOrderView
    {
        private OrderInfo _selectedOrder = new OrderInfo();

        public OrderCenterCtrl()
        {
            InitializeComponent();

            tabPage2.Parent = null;
            tabPage4.Parent = null;
        }

        public OrderPresenter Presenter { get; set; }

        public OrderInfo Info
        {
            get { return _selectedOrder; }
            set { _selectedOrder = value; }
        }

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

        public string Doctor
        {
            get { return cmbDoctor.Text; }
            set { cmbDoctor.Text = value; }
        }

        public string Patient
        {
            get { return txtPatient.Text; }
            set { txtPatient.Text = value; }
        }

        public bool DoctorCheckedState
        {
            get { return chkDoctor.Checked; }
            set { chkDoctor.Checked = value; }
        }

        public bool PatientCheckedState
        {
            get { return chkPatient.Checked; }
            set { chkPatient.Checked = value; }
        }

        private void OrderCenterCtrl_Load(object sender, EventArgs e)
        {
            LoadTodayOrders();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            Presenter.OnNewOrder();
            LoadTodayOrders();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (lvTodayOrder.SelectedItems.Count > 0 || lvSearchOrder.SelectedItems.Count > 0)
            {
                Presenter.OnDeleteOrder();
                LoadTodayOrders();
            }
            else
            {
                MessageA.ShowMessage("请选择您要删除的预约！");
            }
        }

        private void btnModifyOrder_Click(object sender, EventArgs e)
        {
            if (lvTodayOrder.SelectedItems.Count > 0 || lvSearchOrder.SelectedItems.Count > 0)
            {
                Presenter.OnModifyOrder();
                LoadTodayOrders();
            }
            else
            {
                MessageA.ShowMessage("请选择您要修改的预约！");
            }
        }

        private void btnUnOrder_Click(object sender, EventArgs e)
        {
            if (lvTodayOrder.SelectedItems.Count > 0 || lvSearchOrder.SelectedItems.Count > 0)
            {
                Presenter.OnUnOrder();
                LoadTodayOrders();

                btnUnOrder.Text = btnUnOrder.Text == "设成未预约" ? "设成预约" : "设成未预约";
            }
            else
            {
                MessageA.ShowMessage("请选择您要修改的预约！");
            }
        }

        private void lvTodayOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTodayOrder.SelectedItems.Count > 0)
            {
                _selectedOrder.CaseNo = lvTodayOrder.SelectedItems[0].SubItems[0].Text;
                _selectedOrder.PatientName = lvTodayOrder.SelectedItems[0].SubItems[1].Text;
                _selectedOrder.DoctorName = lvTodayOrder.SelectedItems[0].SubItems[2].Text;
                _selectedOrder.OrderDatetime = lvTodayOrder.SelectedItems[0].SubItems[3].Text;
                _selectedOrder.OrderContext = lvTodayOrder.SelectedItems[0].SubItems[4].Text;
                _selectedOrder.MobilePhone = lvTodayOrder.SelectedItems[0].SubItems[5].Text;
                _selectedOrder.MsgState = lvTodayOrder.SelectedItems[0].SubItems[6].Text;
                _selectedOrder.OrderState = lvTodayOrder.SelectedItems[0].SubItems[7].Text;

                btnUnOrder.Text = _selectedOrder.OrderState == "未预约" ? "设成预约" : "设成未预约";
            }
        }

        private void lvSearchOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSearchOrder.SelectedItems.Count > 0)
            {
                _selectedOrder.CaseNo = lvSearchOrder.SelectedItems[0].SubItems[0].Text;
                _selectedOrder.PatientName = lvSearchOrder.SelectedItems[0].SubItems[1].Text;
                _selectedOrder.DoctorName = lvSearchOrder.SelectedItems[0].SubItems[2].Text;
                _selectedOrder.OrderDatetime = lvSearchOrder.SelectedItems[0].SubItems[3].Text;
                _selectedOrder.OrderContext = lvSearchOrder.SelectedItems[0].SubItems[4].Text;
                _selectedOrder.MobilePhone = lvSearchOrder.SelectedItems[0].SubItems[5].Text;
                _selectedOrder.MsgState = lvSearchOrder.SelectedItems[0].SubItems[6].Text;
                _selectedOrder.OrderState = lvSearchOrder.SelectedItems[0].SubItems[7].Text;

                btnUnOrder.Text = _selectedOrder.OrderState == "未预约" ? "设成预约" : "设成未预约";
            }
        }

        private void LoadTodayOrders()
        {
            DataTable dt = Presenter.QueryTodayOrders();

            lvTodayOrder.Items.Clear();
            lvTodayOrder.BeginUpdate();
            foreach (DataRow r in dt.Rows)
            {
                var li = new ListViewItem();
                li.SubItems[0].Text = r[0].ToString();
                li.SubItems.Add(r[1].ToString());
                li.SubItems.Add(r[2].ToString());
                li.SubItems.Add(r[4].ToString());
                li.SubItems.Add(r[5].ToString());
                li.SubItems.Add(r[6].ToString());
                li.SubItems.Add(r[7].ToString());
                li.SubItems.Add(r[8].ToString());

                lvTodayOrder.Items.Add(li);
            }
            lvTodayOrder.EndUpdate();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog {DefaultExt = "xls", Filter = "Excel文件(*.xls)|*.xls"};
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 1:
                        Util.ExportToExcel(lvTodayOrder, dlg.FileName);
                        break;

                    case 3:
                        Util.ExportToExcel(lvSearchOrder, dlg.FileName);
                        break;
                }
            }
        }

        private void btnSearchout_Click(object sender, EventArgs e)
        {
            DataTable dt = Presenter.QueryOrders();

            lvSearchOrder.Items.Clear();
            lvSearchOrder.BeginUpdate();
            foreach (DataRow r in dt.Rows)
            {
                var li = new ListViewItem();
                li.SubItems[0].Text = r[0].ToString();
                li.SubItems.Add(r[1].ToString());
                li.SubItems.Add(r[2].ToString());
                li.SubItems.Add(r[4].ToString());
                li.SubItems.Add(r[5].ToString());
                li.SubItems.Add(r[6].ToString());
                li.SubItems.Add(r[7].ToString());
                li.SubItems.Add(r[8].ToString());

                lvSearchOrder.Items.Add(li);
            }
            lvSearchOrder.EndUpdate();
        }

        private void chkDoctor_CheckedChanged(object sender, EventArgs e)
        {
            cmbDoctor.Enabled = !cmbDoctor.Enabled;
        }

        private void chkPatient_CheckedChanged(object sender, EventArgs e)
        {
            txtPatient.Enabled = !txtPatient.Enabled;
        }
    }
}