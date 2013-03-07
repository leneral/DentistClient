using System;

namespace DentistryClient.Preliminary
{
    public interface IPreliminaryView : IView
    {
        string CaseNo { get; }
        string ExludedCase { get; set; }
        string Extent { get; set; }
        string FaceWoundHistory { get; set; }
        string IsCuring { get; set; }
        string Periods { get; set; }
        DateTime PreliminaryDate { get; set; }
        string Type { get; set; }

        bool ToUpdate { get; set; }

        PreliminaryPresenter Presenter { get; set; }
    }
}