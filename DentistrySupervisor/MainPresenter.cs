using System.Drawing;
using System.Windows.Forms;

namespace DentistryClient.DentistrySupervisor
{
    public class MainPresenter
    {
        private readonly ViewLoader _loader = new ViewLoader();
        public IMainView View { get; set; }

        public ViewLoader OnLoadTodayJobCtrl()
        {
            if (_loader.LastLoadedControl != null)
                _loader.LastLoadedControl.Visible = false;
            _loader.LoadTodayJobCtrl();
            SetProperties();
            return _loader;
        }

        public ViewLoader OnPatientsCenterCtrl()
        {
            if (_loader.LastLoadedControl != null)
                _loader.LastLoadedControl.Visible = false;
            _loader.LoadPatientsCenterCtrl();
            SetProperties();
            return _loader;
        }

        public ViewLoader OnOrderCenterCtrl()
        {
            if (_loader.LastLoadedControl != null)
                _loader.LastLoadedControl.Visible = false;
            _loader.LoadOrderCenterCtrl();
            SetProperties();
            return _loader;
        }

        private void SetProperties()
        {
            _loader.LastLoadedControl.Location = new Point(0, 0);
            _loader.LastLoadedControl.Visible = true;
            _loader.LastLoadedControl.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right |
                                               AnchorStyles.Top;
            _loader.LastLoadedControl.Size = View.CtrlSize;
        }
    }
}