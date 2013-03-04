using System.Drawing;

namespace DentistryClient.DentistrySupervisor
{
    public interface IMainView
    {
        MainPresenter Presenter { get; set; }

        Size CtrlSize { get; set; }
    }
}