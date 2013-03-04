namespace DentistryClient.Selection
{
    public interface ISelectionView
    {
        string SearchWord { get; set; }

        string SelectedCaseNo { get; set; }
        string SelectedName { get; set; }

        SelectionPresenter Presenter { get; set; }
    }
}