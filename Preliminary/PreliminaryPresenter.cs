using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Model.Message;
using Model.Patients;

namespace DentistryClient.Preliminary
{
    public class PreliminaryPresenter
    {
        private static bool _saved;
        public IPreliminaryView View { get; set; }

        public void OnSave()
        {
            if (View.ExludedCase == string.Empty)
            {
                MessageA.ShowMessage("请选择是否排除病历");
                return;
            }
            if (View.Extent == string.Empty)
            {
                MessageA.ShowMessage("请选择严重程度");
                return;
            }
            if (View.FaceWoundHistory == string.Empty)
            {
                MessageA.ShowMessage("请选择面部创伤史");
                return;
            }
            if (View.IsCuring == string.Empty)
            {
                MessageA.ShowMessage("请选择是否正在进行其他牙科治疗");
                return;
            }
            if (View.Periods == string.Empty)
            {
                MessageA.ShowMessage("请选择换牙期");
                return;
            }
            if (View.Type.ToString(CultureInfo.InvariantCulture) == string.Empty)
            {
                MessageA.ShowMessage("请选择错颌类型");
                return;
            }
            if (View.PreliminaryDate.ToString(CultureInfo.InvariantCulture) == string.Empty)
            {
                MessageA.ShowMessage("请选择初诊时间");
                return;
            }
            var info = new PreliminaryInfo
                {
                    CaseNo = View.CaseNo,
                    ExludedCases = View.ExludedCase,
                    Extent = View.Extent,
                    FaceWoundHistory = View.FaceWoundHistory,
                    IsCuring = View.IsCuring,
                    Periods = View.Periods,
                    Type = View.Type,
                    PreliminaryDate = View.PreliminaryDate
                };

            if (View.ToUpdate)
            {
                _saved = PatientsService.UpdatePreliminaryInfo(info);
                MessageA.ShowMessage(_saved ? "更新成功！" : "对不起，更新失败！");
            }
            else
            {
                _saved = PatientsService.SavePreliminaryInfo(info);
                MessageA.ShowMessage(_saved ? "保存成功！" : "对不起，保存失败！");
            }

            View.Exit();
        }

        public void OnClose()
        {
            if (_saved)
                View.Exit();
            if (View.CaseNo!= string.Empty)
            {
                DialogResult dlgResult = MessageBox.Show(
                    "您还没有保存数据，现在关闭将丢失数据，是否确定关闭？",
                    "提示",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                    );
                if (dlgResult == DialogResult.OK)
                    View.Exit();
            }
            else
            {
                View.Exit();
            }
        }

        public PreliminaryInfo GetPreliminaryInfo(string caseno, int index)
        {
            DataTable dt = PatientsService.QueryPreliminaryInfo("caseno", caseno);
            var preminfo = new PreliminaryInfo
                {
                    FaceWoundHistory = dt.Rows[index][2].ToString(),
                    IsCuring = dt.Rows[index][3].ToString(),
                    Type = dt.Rows[index][4].ToString(),
                    Extent = dt.Rows[index][5].ToString(),
                    Periods = dt.Rows[index][6].ToString(),
                    ExludedCases = dt.Rows[index][7].ToString(),
                };
            return preminfo;
        }
    }
}