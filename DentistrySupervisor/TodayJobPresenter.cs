using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using Model.Message;
using Model.Patients;
using Model.Util;

namespace DentistryClient.DentistrySupervisor
{
    public class TodayJobPresenter : Presenter
    {
        private readonly ViewLoader _loader = new ViewLoader();
        public ITodayJobView View { get; set; }

        public void OnLookup()
        {
            if (View.SelectedCaseNo != string.Empty)
            {
                DataTable dt = PatientsService.QueryPatients("caseno", View.SelectedCaseNo);
                _loader.ModifyRegisterView(Dt2PatientsInfo(dt));
                _loader.LastLoadedView.ShowDialog();
            }
        }

        public void OnRegister()
        {
            _loader.LoadRegisterView(AddNewNodeDelegWrap);
            _loader.LastLoadedView.ShowDialog();
        }

        public void OnFillCase()
        {
            if (string.IsNullOrEmpty(View.SelectedCaseNo))
            {
                _loader.LoadSelectionView();
                _loader.LastLoadedView.ShowDialog();
            }
            else
            {
                _loader.LoadClinicCasesView(View.SelectedCaseNo, View.PatientName);
                _loader.LastLoadedView.ShowDialog();
                View.PatientName = string.Empty;
                View.SelectedCaseNo = string.Empty;
            }
        }

        public void OnOutProduce()
        {
            //_loader.LoadOutProcView();
            //_loader.LastLoadedView.ShowDialog();
        }

        public void OnCharge()
        {
            if (string.IsNullOrEmpty(View.SelectedCaseNo))
            {
                //_loader.LoadSelectionView();
                //_loader.LastLoadedView.ShowDialog();
                MessageA.ShowMessage("请先选择患者！");
            }
            else
            {
                DataTable dt = PatientsService.QueryPatients("caseno", View.SelectedCaseNo);
                if (dt.Rows.Count > 0)
                {
                    string sex = dt.Rows[0][2].ToString() == "1" ? "男" : "女";
                    _loader.LoadChargeView(View.SelectedCaseNo, dt.Rows[0][1].ToString(), sex);
                    _loader.LastLoadedView.ShowDialog();
                }
            }
        }


        public void OnClose()
        {
            DialogResult dlgResult = MessageA.ShowMessage(
                "您是否确认要退出程序？",
                "提示",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
            if (dlgResult == DialogResult.OK)
            {
                View.Exit();
            }
        }

        public DataTable QueryTodayPatients()
        {
            return PatientsService.QueryPatients("registerDate", DateTime.Now.Date.ToShortDateString());
        }

        public DataTable QueryAllPatients()
        {
            return PatientsService.QueryPatients();
        }

        public DataTable QueryAPatient()
        {
            return PatientsService.QueryPatients("patientname", View.SearchWord);
        }

        public Hashtable QueryThisWeekOrders()
        {
            var orderHt = new Hashtable();

            DataTable dt = PatientsService.QueryOrders();
            foreach (DataRow r in dt.Rows)
            {
                string orderDate = r[4].ToString();

                int days = Util.DateDistance(orderDate);
                if (days >= 0 && days <= 7)
                {
                    orderHt[r[1].ToString()] = orderDate;
                }
            }

            return orderHt;
        }

        public DataTable Search()
        {
            DataTable dt;
            if (string.IsNullOrEmpty(View.SearchWord))
            {
                dt = QueryAPatient();
            }
            else
            {
                String searchWord = View.SearchWord;
                if (!Util.IsEnglishChars(searchWord))
                {
                    dt = QueryAllPatients();

                    for (int i = 0; i < dt.Rows.Count; )
                    {
                        DataRow dr = dt.Rows[i];
                        string py = Ch2Pinyin.ToPinyin(dr[0].ToString());
                        if (py.Length > searchWord.Length &&
                            py.Substring(0, searchWord.Length).ToLower() == searchWord.ToLower())
                        {
                            i++;
                            continue;
                        }
                        dt.Rows[i].Delete();
                        dt.AcceptChanges();
                    }
                }
                else
                {
                    dt = QueryAPatient();
                }
            }
            return dt;
        }

        public void AddNewNodeDelegWrap(string nodeName)
        {
            View.AddNewNodeDeleg(nodeName);
        }
    }
}