namespace DentistryClient.DentistrySupervisor
{
    public interface ITodayJobView : IView
    {
        string PatientName { get; set; }
        string SearchWord { get; set; }

        string SelectedCaseNo { get; set; }

        TodayJobPresenter Presenter { get; set; }

        void AddNewNodeDeleg(string nodeName);
    }
}