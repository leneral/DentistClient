using Model.Patients;

namespace DentistryClient.DentistrySupervisor
{
    public interface IPatientsCenterView : IView
    {
        string CaseNo { get; set; }
        string Patient { get; set; }
        byte Sex { get; set; }
        int Age { get; set; }
        string Hospital { get; }

        bool ClinckRadioState { get; set; }
        bool PatientTextState { get; set; }
        bool CaseNoTextState { get; set; }
        bool SexCmbState { get; set; }
        bool AgeNumState { get; set; }
        bool HospitalCmbState { get; set; }

        int TabSelectedIndex { get; set; }

        PatientsCenterPresenter Presenter { get; set; }

        string SelectedCaseNo { get; set; }

        void ShowPatientInfoDlg(PatientsInfo info);
    }
}