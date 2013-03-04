using System;
using Model.Patients;

namespace DentistryClient.DentistrySupervisor
{
    public interface IOrderView : IView
    {
        DateTime FromDate { get; set; }
        DateTime ToDate { get; set; }
        string Doctor { get; set; }
        string Patient { get; set; }

        bool DoctorCheckedState { get; set; }
        bool PatientCheckedState { get; set; }

        OrderInfo Info { get; set; }

        OrderPresenter Presenter { get; set; }
    }
}