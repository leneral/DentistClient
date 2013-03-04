using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Model.Patients;
using Model.Template;

namespace DentistryClient.CaseProc
{
    public class CaseProcPresenter
    {
        private readonly ViewLoader _loader = new ViewLoader();
        public ICaseProcView View { get; set; }

        public void OnClose()
        {
            View.Exit();
        }

        public DataTable SelectTemplate(int id)
        {
            return new TemplateService().SelectTemplate(id);
        }

        public DiagnosedInfo GetDiagnoseInfo()
        {
            return new DiagnosedInfo
                {
                    PersonalContext = View.PersonalContext,
                    SickHistoryNow = View.SickHistoryNow,
                    SickHistoryBefore = View.SickHistoryBefore,
                    KeyWords = View.KeyWords,
                    CheckInfo = View.CheckInfo,
                    DiagnoseInfo = View.DiagnoseInfo,
                    CureInfo = View.CureInfo
                };
        }

        public ViewLoader OnLoadPrescriptionCtrl()
        {
            if (_loader.LastLoadedControl != null)
                _loader.LastLoadedControl.Visible = false;
            _loader.LoadPrescriptionCtrl();

            SetProperties();

            return _loader;
        }

        private void SetProperties()
        {
            _loader.LastLoadedControl.Location = new Point(0, 0);
            _loader.LastLoadedControl.Visible = true;
            _loader.LastLoadedControl.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right |
            AnchorStyles.Top;

            _loader.LastLoadedControl.Size = new Size(_loader.LastLoadedControl.Width, View.CtrlSize.Height);
        }
    }
}