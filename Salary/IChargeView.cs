namespace DentistryClient.Salary
{
    public interface IChargeView
    {
        string CaseNo { get; set; }
        string PatientName { get; set; }
        string Sex { get; set; }

        string GeneralCharge { get; set; }
        string CleanCharge { get; set; }
        string InMouthCharge { get; set; }
        string PullToothCharge { get; set; }
        string SurgeryCharge { get; set; }
        string FixRestoreCharge { get; set; }
        string RestoreCharge { get; set; }
        string OrthodonticCharge { get; set; }
        string EmitCharge { get; set; }
        string DrugCharge { get; set; }
        string ForeignMedicineCharge { get; set; }
        string PlantToothCharge { get; set; }
        string OtherCharge { get; set; }


        ChargePresenter Presenter { get; set; }
    }
}