using System.Windows.Forms;
using DentistryClient.CaseProc;
using DentistryClient.ClinicCase;
using DentistryClient.DentistrySupervisor;
using DentistryClient.Login;
using DentistryClient.MyView;
using DentistryClient.Preliminary;
using DentistryClient.Prescription;
using DentistryClient.ReVisit;
using DentistryClient.Register;
using DentistryClient.Salary;
using DentistryClient.Search;
using DentistryClient.Selection;
using DentistryClient.UserCtrl;
using Model.Patients;
using OrderPresenter = DentistryClient.Order.OrderPresenter;

namespace DentistryClient
{
    public class ViewLoader : IViewLoader
    {
        public Form LastLoadedView { get; set; }
        public UserControl LastLoadedControl { get; set; }

        public void LoadLoginView()
        {
            var view = new LoginView();
            var presenter = new LoginPresenter();

            view.Presenter = presenter;
            presenter.View = view;

            LoadView(view);
        }

        public void LoadChargeView(string caseno, string name, string sex)
        {
            var view = new ChargeView(caseno, name, sex);
            var presenter = new ChargePresenter();

            view.Presenter = presenter;
            presenter.View = view;

            LoadView(view);
        }

        public void LoadCaseProcView(DisplayCasesEventHandler deleg)
        {
            var view = new CaseProcView(deleg);
            var presenter = new CaseProcPresenter();

            view.Presenter = presenter;
            presenter.View = view;

            LoadView(view);
        }

        public void LoadClinicCasesView(string caseno, string name)
        {
            var view = new ClinicCasesView(caseno, name);
            var presenter = new ClinicCasePresenter();

            view.Presenter = presenter;
            presenter.View = view;

            LoadView(view);
        }

        public void LoadDentistrySupervisorView()
        {
            var view = new DentistrySupervisorView();
            var presenter = new MainPresenter();

            view.Presenter = presenter;
            presenter.View = view;

            LoadView(view);
        }

        public void LoadOrderView()
        {
            var view = new OrderView();
            var presenter = new OrderPresenter();

            view.Presenter = presenter;
            presenter.View = view;

            LoadView(view);
        }

        public void LoadOrderView(OrderInfo info)
        {
            var view = new OrderView(info);
            var presenter = new OrderPresenter();

            view.Presenter = presenter;
            presenter.View = view;

            LoadView(view);
        }

        public void LoadOutProcView()
        {
        }

        public void LoadPreliminaryView(PreliminaryInfo info)
        {
            var view = new PreliminaryView(info);
            var presenter = new PreliminaryPresenter();

            view.Presenter = presenter;
            presenter.View = view;

            LoadView(view);
        }

        public void LoadPreliminaryView(string caseno, string name, FlushHistoryListEventHandler flushDeleg)
        {
            var view = new PreliminaryView(caseno, name, flushDeleg);
            var presenter = new PreliminaryPresenter();

            view.Presenter = presenter;
            presenter.View = view;

            LoadView(view);
        }

        public void LoadRegisterView(AddNewNodeEventHandler deleg)
        {
            var view = new RegisterView(deleg);
            var presenter = new RegisterPresenter();

            view.Presenter = presenter;
            presenter.View = view;

            LoadView(view);
        }

        public void LoadSearchView(ShowSelectedPatientEventHandler deleg)
        {
            var view = new SearchView(deleg);
            var presenter = new SearchPresenter();

            view.Presenter = presenter;
            presenter.View = view;

            LoadView(view);
        }

        public void LoadSelectionView()
        {
            var view = new SelectionView();
            var presenter = new SelectionPresenter();

            view.Presenter = presenter;
            presenter.View = view;

            LoadView(view);
        }

        public void LoadTemplateOpView()
        {
        }

        public void LoadReVisitView(string caseno)
        {
            var view = new ReVisitView(caseno);
            var presenter = new ReVisitViewPresenter();

            view.Presenter = presenter;
            presenter.View = view;

            LoadView(view);
        }

        public void LoadTodayJobCtrl()
        {
            var view = new TodayJobCtrl();
            var presenter = new TodayJobPresenter();

            view.Presenter = presenter;
            presenter.View = view;

            LoadControl(view);
        }

        public void LoadPatientsCenterCtrl()
        {
            var view = new PatientsCenterCtrl();
            var presenter = new PatientsCenterPresenter();

            view.Presenter = presenter;
            presenter.View = view;

            LoadControl(view);
        }

        public void LoadOrderCenterCtrl()
        {
            var view = new OrderCenterCtrl();
            var presenter = new DentistrySupervisor.OrderPresenter();

            view.Presenter = presenter;
            presenter.View = view;

            LoadControl(view);
        }

        public void LoadPrescriptionCtrl()
        {
            var view = new PrescriptionCtrl();
            var presenter = new PrescriptionPresenter();

            view.Presenter = presenter;
            presenter.View = view;

            LoadControl(view);
        }

        public void LoadReVisitCenterCtrl()
        {
            var view = new ReVisitCenterCtrl();
            var presenter = new ReVisitCtrlPresenter();

            view.Presenter = presenter;
            presenter.View = view;

            LoadControl(view);
        }

        public void ModifyRegisterView(PatientsInfo info)
        {
            var view = new RegisterView(info);
            var presenter = new RegisterPresenter();

            view.Presenter = presenter;
            presenter.View = view;

            LoadView(view);
        }

        private void LoadView(Form view)
        {
            //view.Show();

            LastLoadedView = view;
        }

        private void LoadControl(UserControl ctrl)
        {
            LastLoadedControl = ctrl;
        }
    }
}