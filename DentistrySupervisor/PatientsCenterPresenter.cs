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
        }

        public void OnCaseNoCheckedChanged()
        {
            View.CaseNoTextState = !View.CaseNoTextState;
        }

        public void OnSexCheckedChanged()
        {
            View.SexCmbState = !View.SexCmbState;
        }

        public void OnAgeCheckedChanged()
        {
            View.AgeNumState = !View.AgeNumState;
        }

        public void OnHospitalCheckedChanged()
        {
            View.HospitalCmbState = !View.HospitalCmbState;
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
            return null;
        }
    }
}