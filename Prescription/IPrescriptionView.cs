namespace DentistryClient.Prescription
{
    public interface IPrescriptionView : IView
    {
        PrescriptionPresenter Presenter { get; set; }
    }
}