using System;
using Model.Message;
using Model.Patients;

namespace DentistryClient.Order
{
    public class OrderPresenter
    {
        private readonly ViewLoader _loader = new ViewLoader();
        private OrderInfo _orderInfo;
        private bool _saved;
        public IOrderView View { get; set; }

        public void OnSearch()
        {
            _loader.LoadSearchView(GetSelectedPatientDelegWrap);
            _loader.LastLoadedView.ShowDialog();
        }

        public bool OnSave()
        {
            if (View.PatientName == string.Empty)
            {
                MessageA.ShowMessage("请选择预约患者！");
                return false;
            }
            if (View.DoctorName == string.Empty)
            {
                MessageA.ShowMessage("请选择预约医生！");
                return false;
            }
            if (View.OrderDatetime == string.Empty)
            {
                MessageA.ShowMessage("请填写预约时间！");
                return false;
            }
            _orderInfo = new OrderInfo
                {
                    CaseNo = View.CaseNo,
                    PatientName = View.PatientName,
                    DoctorName = View.DoctorName,
                    NDays = View.NDays,
                    OrderDatetime = View.OrderDatetime,
                    OrderContext = View.OrderContext,
                    MobilePhone = View.MobilePhone,
                    OrderState = "已预约",
                    MsgState = "未发送"
                };

            if (View.ModifyState)
            {
                _saved = PatientsService.ModifyOrderInfo(_orderInfo);
                MessageA.ShowMessage(_saved ? "修改成功！" : "对不起，修改失败！");
            }
            else
            {
                _saved = PatientsService.SaveOrderInfo(_orderInfo);
                MessageA.ShowMessage(_saved ? "保存成功！" : "对不起，保存失败！");
            }


            View.Exit();

            return _saved;
        }

        public OrderInfo GetOrderInfo()
        {
            return _orderInfo;
        }

        public void OnValueChanged()
        {
            int ndays = Convert.ToInt16(View.NDays);
            View.OrderDatetime = DateTime.Now.ToLocalTime().AddDays(ndays).ToString();
        }

        public void GetSelectedPatientDelegWrap(string caseno, string name, string mobilephone)
        {
            View.GetSelectedPatientDeleg(caseno, name, mobilephone);
        }
    }
}