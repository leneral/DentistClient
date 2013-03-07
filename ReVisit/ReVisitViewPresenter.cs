using Model.Patients;

namespace DentistryClient.ReVisit
{
    public class ReVisitViewPresenter
    {
        public IReVisitView View { get; set; }

        public void OnSave()
        {
            var info = new ReVisitInfo
                {
                    Caseno = View.Caseno,
                    Date = View.Date,
                    IsVisit = View.IsVisit,
                    Context = View.Context,
                    Service = View.Service,
                    Quality = View.Quality,
                    Remark = View.Remark
                };

            PatientsService.SaveReVisitInfo(info);
        }

        public void SearchVisitorInfo()
        {
            var dt = PatientsService.QueryPatients();

            if (dt.Rows.Count != 0)
            {
                View.Name = (string) dt.Rows[0][1];
                View.Sex = dt.Rows[0][2] == (object) '1' ? "男" : "女";
                View.Age = (string) dt.Rows[0][3];
                //TODO
                View.Doctor = "";
            }
        }
    }
}
