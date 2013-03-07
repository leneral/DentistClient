using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DentistryClient.ClinicCase;
using Model.Patients;

namespace DentistryClient.MyView
{
    public delegate void DisplayCasesEventHandler(ref DiagnosedInfo info);

    public delegate void FlushHistoryListEventHandler();

    public partial class ClinicCasesView : Form, IClinicCaseView
    {
        private Button[] _btnlist;
        private DiagnosedInfo _info;
        public ClinicCasePresenter Presenter { get; set; }

        public ClinicCasesView(string caseno, string patientname)
        {
            InitializeComponent();

            CaseNo = caseno;
            SufferName = patientname; /////?????
        }

        private void ClinicCasesView_Load(object sender, EventArgs e)
        {
            Presenter.Initialize();

            _btnlist = new[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10 };

            LoadDiagnoseHistoryRecords();
        }

        private void btnImportImage_Click(object sender, EventArgs e)
        {
            picImage.Image = Presenter.ReadImage();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Presenter.SaveDiagnosedInfo(_info);
            LoadDiagnoseHistoryRecords();
        }

        private void btnFillCase_Click(object sender, EventArgs e)
        {
            Presenter.OnFillCase();
        }

        private void btnAddNewCase_Click(object sender, EventArgs e)
        {
            Presenter.OnPreliminary();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Presenter.OnClose();
        }

        public void FlushHistoryListDeleg()
        {
            LoadDiagnoseHistoryRecords();
        }

        public void DisplayCasesDeleg(ref DiagnosedInfo info)
        {
            _info = info;

            DisplayDiagOrPremInfo(info.ToHashtable());
        }

        public void DisplayDiagnoseInfo(DiagnosedInfo info)
        {
            cbxType.Text = info.Type;
            cbxScore.Text = info.Score;

            DisplayDiagOrPremInfo( info.ToHashtable());
        }

        public void DisplayPreliminaryinfo(PreliminaryInfo info)
        {
            cbxType.Text = string.Empty;
            cbxScore.Text = string.Empty;

            DisplayDiagOrPremInfo(info.ToHashtable());
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            string btnText = sender.GetType().GetProperty("Text").GetValue(sender, null).ToString();
            Presenter.OnButtonClick(btnText);
        }

        private void DisplayDiagOrPremInfo(Hashtable ht)
        {
            int i = 0;
            const int x0 = 17;
            const int y0 = 30;
            const int increX = 273;
            const int increY = 40;
            pnlInfo.Controls.Clear();
            foreach (DictionaryEntry de in ht)
            {
                var lblTitle = new Label {Text = de.Key.ToString(), Location = new Point(x0, (y0 + i*increY))};
                var lblContext = new Label
                    {
                        Text = de.Value.ToString(),
                        Location = new Point((x0 + increX), (y0 + increY*i))
                    };
                pnlInfo.Controls.Add(lblTitle);
                pnlInfo.Controls.Add(lblContext);
                i++;
            }
        }

        public void LoadDiagnoseHistoryRecords()
        {
            DataTable preliminaryDt = Presenter.QueryPreliminaryInfo("caseno", CaseNo);
            DataTable diagnoseDt = Presenter.QueryDiagnoseInfo("caseno", CaseNo);
            LoadComponents(preliminaryDt, diagnoseDt);
        }

        private void LoadComponents(DataTable preliminaryDt, DataTable secDiagnoseDt)
        {
            var preliminaryCnt = preliminaryDt.Rows.Count;
            var diagCnt = secDiagnoseDt.Rows.Count;
            var count = preliminaryCnt + diagCnt;
            foreach (var btn in _btnlist)
            {
                btn.Visible = true;
            }
            for (var i = 0; i < preliminaryCnt; i++)
            {
                _btnlist[i].Text = "第" + (i + 1) + "初诊" + "\r\n" + "时间：" + preliminaryDt.Rows[i][7];
            }
            for (var i = 0; i < diagCnt; i++)
            {
                _btnlist[i + preliminaryCnt].Text = "第" + (i + 1) + "复诊" + "\r\n" + "时间：" + secDiagnoseDt.Rows[i][3];
            }
            for (var i = count; i < _btnlist.Length; i++)
            {
                _btnlist[i].Visible = false;
            }
        }

        #region IClinicCaseView Members

        public string CaseNo { get; set; }

        public string SufferName
        {
            get { return lblSuffererName.Text; }
            set { lblSuffererName.Text = value; }
        }

        public string Type
        {
            get { return cbxType.Text; }
            set { cbxType.Text = value; }
        }

        public string Date
        {
            get { return lblClinicDate.Text; }
            set { lblClinicDate.Text = value; }
        }

        public string Score
        {
            get { return cbxScore.Text; }
            set { cbxScore.Text = value; }
        }

        public Image Picture
        {
            get { return picImage.Image; }
            set { picImage.Image = value; }
        }

        public int TypeSelectedIndex
        {
            get { return cbxType.SelectedIndex; }
            set { cbxType.SelectedIndex = value; }
        }

        public void Exit()
        {
            Close();
        }

        public void ShowCase()
        {
            new CaseProcView(DisplayCasesDeleg).Show();
        }

        public void ShowPreliminary()
        {
            new PreliminaryView(CaseNo, SufferName).Show();
        }

        #endregion
    }
}