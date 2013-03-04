using System;
using System.Data;
using System.Windows.Forms;
using Model.Message;
using Model.Patients;

namespace DentistryClient.DentistrySupervisor
{
    public class OrderPresenter
    {
        private readonly ViewLoader _loader = new ViewLoader();
        public IOrderView View { get; set; }

        public void OnNewOrder()
        {
            _loader.LoadOrderView();
            _loader.LastLoadedView.ShowDialog();
        }

        public void OnDeleteOrder()
        {
            DialogResult dr = MessageA.ShowMessage("您确定要删除此条预约信息？");
            if (dr == DialogResult.OK)
            {
                PatientsService.DeleteOrder(View.Info.CaseNo);
            }
        }

        public void OnModifyOrder()
        {
            _loader.LoadOrderView(View.Info);
            _loader.LastLoadedView.ShowDialog();
        }

        public void OnUnOrder()
        {
            if (View.Info.OrderState == "已预约")
                View.Info.OrderState = "未预约";
            else
                View.Info.OrderState = "已预约";

            PatientsService.ModifyOrderState(View.Info.CaseNo, View.Info.OrderState);
        }

        public DataTable QueryTodayOrders()
        {
            return PatientsService.QueryOrders("orderdatetime", DateTime.Now.Date.ToShortDateString());
        }

        public DataTable QueryOrders()
        {
            return PatientsService.QuerOrders(View.FromDate, View.ToDate, View.Doctor, View.Patient);
        }
    }
}