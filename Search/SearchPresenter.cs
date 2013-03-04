using System.Data;
using Model.Patients;

namespace DentistryClient.Search
{
    public class SearchPresenter
    {
        public ISearchView View { get; set; }

        public void OnOk()
        {
            View.Ok();
        }

        public void OnClose()
        {
            View.Exit();
        }

        public void OnRadNameChanged()
        {
            View.NameRadioState = !View.NameRadioState;
        }

        public void OnRadCaseNoChanged()
        {
            View.CaseNoRadioState = !View.CaseNoRadioState;
        }

        public DataTable OnSearch()
        {
            if (View.NameRadioState)
                return PatientsService.QueryPatients("patientname", View.PatientName);
            if (View.CaseNoRadioState)
                return PatientsService.QueryPatients("caseno", View.CaseNo);

            return null;
        }
    }
}