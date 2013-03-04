namespace DentistryClient.Order
{
    public interface IOrderView : IView
    {
        string PatientName { get; set; }
        string CaseNo { get; set; }
        string DoctorName { get; set; }
        string NDays { get; set; }
        string OrderDatetime { get; set; }
        string OrderContext { get; set; }
        string MobilePhone { get; set; }

        bool ModifyState { get; set; }

        OrderPresenter Presenter { get; set; }

        void GetSelectedPatientDeleg(string caseno, string name, string mobilephone);
    }
}