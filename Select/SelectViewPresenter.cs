using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Patients;
using DentistryClient;
using Model.Message;
namespace DentistryClient.Select
{
    class SelectViewPresenter
    {
        private ViewLoader _loader = new ViewLoader();
        private ISelectView View { get; set; }

        public void OnSelect()
        {
            if (View.CaseNo == string.Empty)
            {
                _loader.LoadClinicCasesView(View.CaseNo,View.PatientsName);
                _loader.LastLoadedView.ShowDialog();
            }
            else
            {
                MessageA.ShowMessage("请选择一名患者！");
            }
        }

    }
}
