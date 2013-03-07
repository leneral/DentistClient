namespace DentistryClient.ReVisit
{
    public interface IReVisitView
    {
        ReVisitViewPresenter Presenter { get; set; }

        string Caseno { get; set; }
        string Name { get; set; }
        string Sex { get; set; }
        string Age { get; set; }
        string Doctor { get; set; }

        string Date { get; set; }
        string IsVisit { get; set; }
        string Context { get; set; }
        string Service { get; set; }
        string Quality { get; set; }
        string Remark { get; set; }
    }
}
