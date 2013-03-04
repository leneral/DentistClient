using Model.Message;
using Model.Patients;

namespace DentistryClient.Salary
{
    public class ChargePresenter
    {
        private ViewLoader _loader = new ViewLoader();
        public IChargeView View { get; set; }

        public void OnSave()
        {
            var info = new SalaryInfo
                {
                    CaseNo = View.CaseNo,
                    GeneralCharge = View.GeneralCharge,
                    CleanCharge = View.CleanCharge,
                    InMouthCharge = View.InMouthCharge,
                    PullToothCharge = View.PullToothCharge,
                    SurgeryCharge = View.SurgeryCharge,
                    FixRestoreCharge = View.FixRestoreCharge,
                    RestoreCharge = View.RestoreCharge,
                    OrthodonticCharge = View.OrthodonticCharge,
                    EmitCharge = View.EmitCharge,
                    DrugCharge = View.DrugCharge,
                    ForeignMedicineCharge = View.ForeignMedicineCharge,
                    PlantToothCharge = View.PlantToothCharge,
                    OtherCharge = View.OtherCharge
                };
            PatientsService.SaveSalaryInfo(info);

            MessageA.ShowMessage("保存成功！");
        }
    }
}