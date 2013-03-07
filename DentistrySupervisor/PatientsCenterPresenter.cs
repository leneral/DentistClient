using System.Data;
using Model.Patients;

namespace DentistryClient.DentistrySupervisor
{
    public class PatientsCenterPresenter : Presenter
    {
        public IPatientsCenterView View { get; set; }

        public void OnPatientsCheckedChanged()
        {
            View.PatientTextState = !View.PatientTextState;
            if (!View.PatientTextState)
            {
                View.Patient = string.Empty;
            }
        }

        public void OnCaseNoCheckedChanged()
        {
            View.CaseNoTextState = !View.CaseNoTextState;
            if (!View.CaseNoTextState)
            {
                View.CaseNo = string.Empty;
            }
        }

        public void OnSexCheckedChanged()
        {
            View.SexCmbState = !View.SexCmbState;
            if (!View.SexCmbState)
            {
                View.Sex = string.Empty;
            }
        }

        public void OnAgeCheckedChanged()
        {
            View.AgeNumState = !View.AgeNumState;
            if (!View.AgeNumState)
            {
                View.Age = string.Empty;
            }
        }

        public void OnHospitalCheckedChanged()
        {
            View.HospitalCmbState = !View.HospitalCmbState;
            if (!View.HospitalCmbState)
            {
                 View.Hospital = string.Empty;
            }
        }

        public void OnCond1CheckedChanged()
        {
            View.CondCmbState = !View.CondCmbState;
            View.FromDateCmbState = View.CondCmbState;
            View.EndDateCmbState = View.CondCmbState;
        }

        public void OnLookup()
        {
            if (View.SelectedCaseNo != string.Empty)
            {
                DataTable dt = PatientsService.QueryPatients("caseno", View.SelectedCaseNo);
                View.ShowPatientInfoDlg(Dt2PatientsInfo(dt));
            }
        }

        public DataTable Search()
        {
            switch (View.TabSelectedIndex)
            {
                case 0:
                    return GetEasyQueryCmd();
                case 1:
                    return GetAdvanceQueryCmd();
            }
            return null;
        }

        private DataTable GetEasyQueryCmd()
        {
            return PatientsService.EasyQueryPatients(View.Patient, View.CaseNo, View.Sex, View.Age, View.Hospital);
        }

        private DataTable GetAdvanceQueryCmd()
        {
            return PatientsService.QueryPatients();
        }
    }
}