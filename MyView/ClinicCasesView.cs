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
        private Button[] _btnList;
        private DiagnosedInfo _info;
        public ClinicCasePresenter Presenter { get; set; }

        public ClinicCasesView(string caseNo, string patientName)
        {
            InitializeComponent();

            CaseNo = caseNo;
            PatientName = patientName; 
        }

        private void ClinicCasesView_Load(object sender, EventArgs e)
        {
            Presenter.Initialize();

            _btnList = new[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10 };

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

        private void btnList_Click(object sender, EventArgs e)
        {
            string btntext = sender.GetType().GetProperty("Text").GetValue(sender, null).ToString();
            Presenter.OnButtonClick(btntext);
        }

        public void DisplayDiagnoseInfo(DiagnosedInfo info)
        {
            cbxType.Text = info.Type;
            cbxScore.Text = info.Score;
            if (info.Picture.Length != 0)
            {
                byte[] photo = Convert.FromBase64String(info.Picture);
                Picture = Presenter.GetImage(photo);
            }
            else
            {
                Picture = null;
            }
            DisplayDiagOrPremInfo(info.ToHashtable());
        }

        public void DisplayPreliminaryInfo(PreliminaryInfo info)
        {
            cbxType.Text = string.Empty;
            cbxScore.Text = string.Empty;
            picImage.Image = null;

            DisplayDiagOrPremInfo(info.ToHashtable());
        }

        private void DisplayDiagOrPremInfo(Hashtable ht)
        {
            int i = 0;
            const int x0 = 17;
            const int y0 = 30;
            const int increX = 273;
            const int increY = 40;
            pnlBtnContainer.Controls.Clear();
            foreach (DictionaryEntry de in ht)
            {
                var lblTitle = new Label
                    {
                        Text = de.Key.ToString(), 
                        Location = new Point(x0, (y0 + i*increY))
                    };
                var lblContext = new Label
                    {
                        Text = de.Value.ToString(),
                        Location = new Point((x0 + increX), (y0 + increY*i))
                    };
                pnlBtnContainer.Controls.Add(lblTitle);
                pnlBtnContainer.Controls.Add(lblContext);
                i++;
            }
        }

        public void LoadComponents(DataTable preliminary, DataTable diagnose)
        {
            int preliminaryCnt = preliminary.Rows.Count;
            int diagCnt = diagnose.Rows.Count;
            int count = preliminaryCnt + diagCnt;
            foreach (var btn in _btnList)
            {
                btn.Visible = true;
            }
            for (var i = 0; i < preliminaryCnt; i++)
            {
                _btnList[i].Text = @"第" + (i + 1) + @"初诊" + "\r\n" + @"时间：" + preliminary.Rows[i][7];
            }
            for (var i = 0; i < diagCnt; i++)
            {
                _btnList[i + preliminaryCnt].Text = @"第" + (i + 1) + @"复诊" + "\r\n" + @"时间：" + diagnose.Rows[i][3];
            }
            for (var i = count; i < _btnList.Length; i++)
            {
                _btnList[i].Visible = false;
            }
        }

        public void LoadDiagnoseHistoryRecords()
        {
            DataTable preliminaryDt = Presenter.QueryPreliminaryInfo("caseno", CaseNo);
            DataTable diagnoseDt = Presenter.QueryDiagnoseInfo("caseno", CaseNo);
            LoadComponents(preliminaryDt, diagnoseDt);
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

        #region IClinicCaseView Members

        public string CaseNo { get; set; }

        public string PatientName
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
            new PreliminaryView(CaseNo, PatientName).Show();
        }

        #endregion
    }
}