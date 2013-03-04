using System;
using System.Drawing;
using System.Windows.Forms;
using DentistryClient.DentistrySupervisor;

namespace DentistryClient.MyView
{
    public partial class DentistrySupervisorView : Form, IMainView
    {
        public DentistrySupervisorView()
        {
            InitializeComponent();
        }

        public MainPresenter Presenter { get; set; }

        public Size CtrlSize
        {
            get { return panel1.Size; }
            set { panel1.Size = value; }
        }

        #region LeftPanel

        private void btnPatientsSuper_Click(object sender, EventArgs e)
        {
            switch (btnPatientsSuper.Dock)
            {
                case DockStyle.Top:
                    foreach (Button button in _btns)
                    {
                        button.Dock = DockStyle.Bottom;
                    }
                    break;
            }
            lstSuperCom.BringToFront();
            lstSuperCom.Controls.Clear();
            ArrangePatientsCom();
        }

        private void btnSalarySuper_Click(object sender, EventArgs e)
        {
            DockBtn(btnSalarySuper);

            lstSuperCom.BringToFront();
            lstSuperCom.Controls.Clear();

            ArrangeSalaryCom();
        }

        private void btnProductSuper_Click(object sender, EventArgs e)
        {
            DockBtn(btnProductSuper);
            lstSuperCom.BringToFront();
            lstSuperCom.Controls.Clear();
        }

        private void btnReportSuper_Click(object sender, EventArgs e)
        {
            DockBtn(btnReportSuper);
            lstSuperCom.Controls.Clear();
        }

        private void btnSystemSuper_Click(object sender, EventArgs e)
        {
            DockBtn(btnSystemSuper);
            lstSuperCom.Controls.Clear();
        }

        private void DockToBottom(Button btn)
        {
            for (int i = 0; i < _btns.Length; i++)
            {
                if (_btns[i] == btn)
                {
                    for (int j = i + 1; j < _btns.Length; j++)
                    {
                        _btns[j].Dock = DockStyle.Bottom;
                        _btns[j].SendToBack();
                    }
                    break;
                }
            }
        }

        private void DockToTop(Button btn)
        {
            int i = 0;
            do
            {
                _btns[i].Dock = DockStyle.Top;
                _btns[i].BringToFront();
            } while (i < _btns.Length - 1 && _btns[i++] != btn);
        }

        private void DockBtn(Button btn)
        {
            switch (btn.Dock)
            {
                case DockStyle.Bottom:
                    DockToTop(btn);
                    break;
                default:
                    DockToBottom(btn);
                    break;
            }
        }

        #endregion

        private void FormDentistrySupervisor_Load(object sender, EventArgs e)
        {
            InitComs();

            panel1.Controls.Add(Presenter.OnLoadTodayJobCtrl().LastLoadedControl);
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            panel1.Controls.Add(Presenter.OnLoadTodayJobCtrl().LastLoadedControl);
        }

        private void btnPatientsCenter_Click(object sender, EventArgs e)
        {
            panel1.Controls.Add(Presenter.OnPatientsCenterCtrl().LastLoadedControl);
        }

        private void btnOrderCenter_Click(object sender, EventArgs e)
        {
            panel1.Controls.Add(Presenter.OnOrderCenterCtrl().LastLoadedControl);
        }
    }
}