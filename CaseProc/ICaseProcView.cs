using System.Drawing;

namespace DentistryClient.CaseProc
{
    public interface ICaseProcView : IView
    {
        string PersonalContext { get; set; }
        string SickHistoryNow { get; set; }
        string SickHistoryBefore { get; set; }
        string KeyWords { get; set; }
        string CheckInfo { get; set; }
        string DiagnoseInfo { get; set; }
        string CureInfo { get; set; }

        //TODO: other properties

        Size CtrlSize { get; set; }

        CaseProcPresenter Presenter { get; set; }
    }
}