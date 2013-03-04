namespace DentistryClient.Search
{
    public interface ISearchView : IView
    {
        string CaseNo { get; set; }
        string PatientName { get; set; }

        bool NameRadioState { get; set; }
        bool CaseNoRadioState { get; set; }
        bool NameTextState { get; set; }
        bool CaseNoTextState { get; set; }

        SearchPresenter Presenter { get; set; }

        void Ok();
    }
}