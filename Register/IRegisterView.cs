using System;
using System.Drawing;

namespace DentistryClient.Register
{
    public interface IRegisterView : IView
    {
        string CaseNo { get; set; }
        string PatientsName { get; set; }
        byte Sex { get; set; }
        int Age { get; set; }
        string From { get; set; }
        DateTime BirthTime { get; set; }
        string Folk { get; set; }
        string School { get; set; }
        string Phone { get; set; }
        string Mobilephone { get; set; }
        string Email { get; set; }
        string Address { get; set; }
        string FavorMatter { get; set; }
        string DislikeMatter { get; set; }
        string Cooperation { get; set; }
        string SelfControl { get; set; }
        string Other { get; set; }
        Image Picture { get; set; }

        bool ToUpdate { get; set; }

        RegisterPresenter Presenter { get; set; }

        void ShowDlg();
        void RegisterCallback();
    }
}