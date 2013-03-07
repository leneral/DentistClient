using System;

namespace DentistryClient.ReVisit
{
    public interface IReVisitCtrl
    {
        ReVisitCtrlPresenter Presenter { get; set; }

        string Caseno { get; set; }
        DateTime FromDate { get; set; }
        DateTime ToDate { get; set; }
    }
}
