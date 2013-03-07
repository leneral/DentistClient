using System.Drawing;
using Model.Patients;

namespace DentistryClient.ClinicCase
{
    public interface IClinicCaseView : IView
    {
        string CaseNo { get; set; }
        string PatientName { get; set; }
        string Type { get; set; }
        string Date { get; set; }
        string Score { get; set; }
        Image Picture { get; set; }

        int TypeSelectedIndex { get; set; }
        ClinicCasePresenter Presenter { get; set; }

        void DisplayCasesDeleg(ref DiagnosedInfo info);
        void DisplayDiagnoseInfo(DiagnosedInfo info);
        void DisplayPreliminaryInfo(PreliminaryInfo preminfo);
        void FlushHistoryListDeleg();
    }
}