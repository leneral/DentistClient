using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DentistryClient.Select
{
    interface ISelectView : IView
    {
        string PatientsName { get; set; }
        string CaseNo { get; }
        string SelectText { get; set; }

        SelectViewPresenter Presenter { get; set; }
    }
}
