using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Model.ImageManager;
using Model.Message;
using Model.Patients;

namespace DentistryClient.ClinicCase
{
    public class ClinicCasePresenter : Presenter
    {
        private bool _saved;
        public IClinicCaseView View { get; set; }
        private readonly ViewLoader _loader = new ViewLoader();

        public void Initialize()
        {
            View.TypeSelectedIndex = 0;
            View.Date = DateTime.Now.ToLocalTime().ToString(CultureInfo.InvariantCulture);
        }

        public void OnPreliminary()
        {
            if (IsExistPreliminary())
            {
                var dt = PatientsService.QueryPreliminaryInfo("caseno", View.CaseNo);
                var info = new PreliminaryInfo
                    {
                        CaseNo = View.CaseNo,
                        FaceWoundHistory = dt.Rows[0][1].ToString(),
                        IsCuring = dt.Rows[0][2].ToString(),
                        Type = dt.Rows[0][3].ToString(),
                        Extent = dt.Rows[0][4].ToString(),
                        Periods = dt.Rows[0][5].ToString(),
                        ExludedCases = dt.Rows[0][6].ToString(),
                        PreliminaryDate = Convert.ToDateTime(dt.Rows[0][7].ToString())
                    };
                _loader.LoadPreliminaryView(info);
                _loader.LastLoadedView.ShowDialog();
            }
            else
            {
                _loader.LoadPreliminaryView(View.CaseNo, View.SufferName, FlushHistoryListDelegWrap);
                _loader.LastLoadedView.ShowDialog();
            }
           
        }

        public void OnFillCase()
        {
            bool exist = IsExistPreliminary();
            if (!exist)
            {
                MessageA.ShowMessage("请先填写初诊信息！");
                return;
            }
            if (IsRejectedCase())
            {
                MessageA.ShowMessage("此用户是排除病例，无法填写诊断信息！");
                return;
            }
            if (View.Type == string.Empty)
            {
                MessageA.ShowMessage("请先选择病情类别！");
                return;
            }
            
            _loader.LoadCaseProcView(DisplayCasesDelegWrap);
            _loader.LastLoadedView.ShowDialog();
        }

        public void OnClose()
        {
            if (_saved)
                View.Exit();
            else
            {
                DialogResult dlgResult = MessageA.ShowMessage(
                    "您还没有保存数据，现在关闭将丢失数据，是否确定关闭？",
                    "提示",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                    );
                if (dlgResult == DialogResult.OK)
                    View.Exit();
            }
        }

        public void SaveDiagnosedInfo(DiagnosedInfo info)
        {
            if (View.Type == string.Empty)
            {
                MessageA.ShowMessage("请选择患者类型！");
            }
            if (View.Score == string.Empty)
            {
                MessageA.ShowMessage("请针对患者情况进行评分！");
                return;
            }
            if (View.Picture != null)
            {
                info.Picture =  Convert.ToBase64String( ImageManager.GetBytes(View.Picture));
            }

            info.Type = View.Type;
            info.Score = View.Score;
            info.CaseNo = View.CaseNo;
            info.PatientName = View.SufferName;
            info.Filltime = View.Date;
            info.Writer = string.Empty;

            _saved = PatientsService.SaveDiagnosedInfo(info);
            MessageA.ShowMessage(_saved ? "保存成功!" : "保存失败!");
        }

        public DataTable QueryPreliminaryInfo(string item, string value)
        {
            return PatientsService.QueryPreliminaryInfo(item, value);
        }

        public DataTable QueryDiagnoseInfo(string item, string value)
        {
            return PatientsService.QueryDiagnosedInfo(item, value);
        }

        public DiagnosedInfo LoadDiagnoseInfo(int index)
        {
            var dt = QueryDiagnoseInfo("caseno", View.CaseNo);
            return new DiagnosedInfo
                {
                    Type = dt.Rows[index][4].ToString(),
                    Score = dt.Rows[index][5].ToString(),
                    DiagnoseInfo = dt.Rows[index][11].ToString(),
                    KeyWords = dt.Rows[index][9].ToString(),
                    PersonalContext = dt.Rows[index][6].ToString(),
                    CheckInfo = dt.Rows[index][10].ToString(),
                    CureInfo = dt.Rows[index][12].ToString(),
                    SickHistoryBefore = dt.Rows[index][8].ToString(),
                    SickHistoryNow = dt.Rows[index][7].ToString(),
                    Picture =  dt.Rows[index][13].ToString()
                };
        }

        public PreliminaryInfo LoadPreliminaryInfo(int index)
        {
            DataTable dt = PatientsService.QueryPreliminaryInfo("caseno", View.CaseNo);
            return new PreliminaryInfo
                {
                    FaceWoundHistory = dt.Rows[index][2].ToString(),
                    IsCuring = dt.Rows[index][3].ToString(),
                    Type = dt.Rows[index][4].ToString(),
                    Extent = dt.Rows[index][5].ToString(),
                    Periods = dt.Rows[index][6].ToString(),
                    ExludedCases = dt.Rows[index][7].ToString(),
                };
        }

        public void OnButtonClick(string btntext)
        {
            string checktype = btntext.Substring(2, 2);
            int idx = Convert.ToInt16(btntext.Substring(1, 1)) - 1;
            switch (checktype)
            {
                case "初诊":
                    PreliminaryInfo preliminaryInfo = LoadPreliminaryInfo(idx);
                    View.DisplayPreliminaryInfo(preliminaryInfo);
                    break;
                case "复诊":
                    DiagnosedInfo diagnosedInfo = LoadDiagnoseInfo(idx);
                    View.DisplayDiagnoseInfo(diagnosedInfo);
                    break;
            }
        }

        public Image GetImageManager(Byte[] photo)
        {
            return ImageManager.GetImage(photo);
        }

        private bool IsExistPreliminary()
        {
            var dt = PatientsService.QueryPreliminaryInfo("caseno", View.CaseNo);
            if (dt.Rows.Count == 0)
                return false;
            return true;
        }

        private bool IsRejectedCase()
        {
            var dt = PatientsService.QueryPreliminaryInfo("caseno", View.CaseNo);
            if (dt.Rows.Count == 0)
                return true;
            string str = dt.Rows[0][7].ToString();
            if (dt.Rows[0][6].ToString() != "否")
                return true;
            return false;
        }

        private void DisplayCasesDelegWrap(ref DiagnosedInfo info)
        {
            View.DisplayCasesDeleg(ref info);
        }

        private void FlushHistoryListDelegWrap()
        {
            View.FlushHistoryListDeleg();
        }
    }
}