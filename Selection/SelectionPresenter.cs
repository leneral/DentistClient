using System;
using System.Data;
using Model.Message;
using Model.Patients;
using Model.Util;

namespace DentistryClient.Selection
{
    public class SelectionPresenter
    {
        private readonly ViewLoader _loader = new ViewLoader();
        public ISelectionView View { get; set; }

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

        public DataTable Search()
        {
            if (string.IsNullOrEmpty(View.SearchWord)) return null;

            String searchWord = View.SearchWord;

            DataTable dt;
            if (!Util.IsEnglishChars(searchWord))
            {
                dt = QueryAllPatients();

                for (int i = 0; i < dt.Rows.Count;)
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

            return dt;
        }

        public void OnSelect()
        {
            if (View.SelectedCaseNo == string.Empty)
            {
                MessageA.ShowMessage("请选择一名患者！");
            }
            else
            {
                _loader.LoadClinicCasesView(View.SelectedCaseNo, View.SelectedName);
                _loader.LastLoadedView.ShowDialog();
            }
        }
    }
}