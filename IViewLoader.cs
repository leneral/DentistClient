using DentistryClient.MyView;
using DentistryClient.UserCtrl;
using Model.Patients;

namespace DentistryClient
{
    public interface IViewLoader
    {
        void LoadLoginView();
        void LoadChargeView(string caseno, string name, string sex);
        void LoadCaseProcView(DisplayCasesEventHandler deleg);
        void LoadClinicCasesView(string caseno, string name);
        void LoadDentistrySupervisorView();
        void LoadOrderView();
        void LoadOrderView(OrderInfo info);
        void LoadOutProcView();
        void LoadPreliminaryView(string caseno, string name);
        void LoadPreliminaryView(string caseno, string name, FlushHistoryListEventHandler flushDeleg);
        void LoadRegisterView(AddNewNodeEventHandler deleg);
        void LoadSearchView(ShowSelectedPatientEventHandler deleg);
        void LoadSelectionView();
        void LoadTemplateOpView();

        void LoadTodayJobCtrl();
        void LoadPatientsCenterCtrl();
        void LoadOrderCenterCtrl();
        void LoadPrescriptionCtrl();
    }
}