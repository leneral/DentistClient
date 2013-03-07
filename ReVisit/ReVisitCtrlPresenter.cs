using System.Data;
using Model.Patients;

namespace DentistryClient.ReVisit
{
    public class ReVisitCtrlPresenter
    {
        public IReVisitCtrl View { get; set; }
        private readonly ViewLoader _loader = new ViewLoader();

        public void OnInitialize()
        {
        }

        public void OnNewVisit()
        {
            _loader.LoadReVisitView(View.Caseno);
            _loader.LastLoadedView.ShowDialog();
        }

        public DataTable LoadTodayVisitor()
        {
            return PatientsService.QueryTodayVisitor();
        }
    }
}
