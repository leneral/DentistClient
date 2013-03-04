using System.Data;
using Model.Patients;

namespace DentistryClient.Prescription
{
    public class PrescriptionPresenter
    {
        public IPrescriptionView View { get; set; }

        public DataTable QueryPrescription()
        {
            return PatientsService.QueryPrescriptions();
        }
    }
}