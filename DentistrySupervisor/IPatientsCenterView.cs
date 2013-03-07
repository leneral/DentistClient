using System;
using Model.Patients;

namespace DentistryClient.DentistrySupervisor
{
    public interface IPatientsCenterView : IView
    {
        string CaseNo { get; set; }
        string Patient { get; set; }
        string Sex { get; set; }
        string Age { get; set; }
        string Hospital { get; set; }
        DateTime StartDiagTime { get; set; }
        DateTime EndDiagTime { get; set; }

        bool ClinckRadioState { get; set; }
        bool PatientTextState { get; set; }
        bool CaseNoTextState { get; set; }
        bool SexCmbState { get; set; }
        bool AgeNumState { get; set; }
        bool HospitalCmbState { get; set; }
        bool CondCmbState { get; set; }
        bool FromDateCmbState { get; set; }
        bool EndDateCmbState { get; set; }

        int TabSelectedIndex { get; set; }

        PatientsCenterPresenter Presenter { get; set; }

        string SelectedCaseNo { get; set; }

        void ShowPatientInfoDlg(PatientsInfo info);
    }
}