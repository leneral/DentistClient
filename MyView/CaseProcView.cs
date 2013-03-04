using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DentistryClient.CaseProc;
using Model.Patients;

namespace DentistryClient.MyView
{
    public partial class CaseProcView : Form, ICaseProcView
    {
        public CaseProcPresenter Presenter { get; set; }
        private readonly DisplayCasesEventHandler _sci;
        private ListView[] _list;
        private UserControl _ctrl;

        public CaseProcView(DisplayCasesEventHandler sci)
        {
            InitializeComponent();

            _sci = sci;

            lblWriter.Text = LoginView._name;
            lblDate.Text = DateTime.Now.ToLocalTime().ToString();
        }

        public Size CtrlSize
        {
            get { return pnlTemplate.Size; }
            set{}
        }
        

        private void FormCaseProcess_Load(object sender, EventArgs e)
        {
            _list = new[] {listView2, listView3, listView4, listView5};

            LoadTemplates(0);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DiagnosedInfo diagnosedInfo = Presenter.GetDiagnoseInfo();
            _sci(ref diagnosedInfo);

            Presenter.OnClose();
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            switch (tabCaseProcess.SelectedIndex)
            {
                case 0:
                    txtPersonalContext.Text +=
                        listView2.SelectedItems[0].SubItems[0].Text.ToString(CultureInfo.InvariantCulture);
                    break;
                case 1:
                    txtCheckContent1.Text +=
                        listView2.SelectedItems[0].SubItems[0].Text.ToString(CultureInfo.InvariantCulture);
                    break;
                case 2:
                    txtDiagnose.Text += listView2.SelectedItems[0].SubItems[0].Text.ToString(CultureInfo.InvariantCulture);
                    break;
                case 3:
                    txtCure.Text += listView2.SelectedItems[0].SubItems[0].Text.ToString(CultureInfo.InvariantCulture);
                    break;
            }
        }

        private void listView3_DoubleClick(object sender, EventArgs e)
        {
            switch (tabCaseProcess.SelectedIndex)
            {
                case 0:
                    txtSickHistoryNow.Text +=
                        listView3.SelectedItems[0].SubItems[0].Text.ToString(CultureInfo.InvariantCulture);
                    break;
                case 1:
                    txtCheckContent1.Text +=
                        listView3.SelectedItems[0].SubItems[0].Text.ToString(CultureInfo.InvariantCulture);
                    break;
                case 2:
                    txtDiagnose.Text +=
                        listView3.SelectedItems[0].SubItems[0].Text.ToString(CultureInfo.InvariantCulture);
                    break;
                case 3:
                    txtCure.Text += listView3.SelectedItems[0].SubItems[0].Text.ToString(CultureInfo.InvariantCulture);
                    break;
            }
        }

        private void listView4_DoubleClick(object sender, EventArgs e)
        {
            switch (tabCaseProcess.SelectedIndex)
            {
                case 0:
                    txtSickHistoryBefore.Text += listView4.SelectedItems[0].SubItems[0].Text;
                    break;
                case 1:
                    txtCheckContent1.Text +=
                        listView4.SelectedItems[0].SubItems[0].Text.ToString(CultureInfo.InvariantCulture);
                    break;
                case 2:
                    txtDiagnose.Text +=
                        listView4.SelectedItems[0].SubItems[0].Text.ToString(CultureInfo.InvariantCulture);
                    break;
                case 3:
                    txtCure.Text += listView4.SelectedItems[0].SubItems[0].Text.ToString(CultureInfo.InvariantCulture);
                    break;
            }
        }

        private void listView5_DoubleClick(object sender, EventArgs e)
        {
            switch (tabCaseProcess.SelectedIndex)
            {
                case 0:
                    txtKeywords.Text += listView5.SelectedItems[0].SubItems[0].Text;
                    break;
                case 1:
                    txtCheckContent1.Text +=
                        listView5.SelectedItems[0].SubItems[0].Text.ToString(CultureInfo.InvariantCulture);
                    break;
                case 2:
                    txtDiagnose.Text +=
                        listView5.SelectedItems[0].SubItems[0].Text.ToString(CultureInfo.InvariantCulture);
                    break;
                case 3:
                    txtCure.Text += listView5.SelectedItems[0].SubItems[0].Text.ToString(CultureInfo.InvariantCulture);
                    break;
            }
        }

        private void tabCaseProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCaseProcess.SelectedIndex < 4)
            {
                listView2.Visible = true;
                listView3.Visible = true;
                listView4.Visible = true;
                listView5.Visible = true;
                
                if(_ctrl != null)
                    pnlTemplate.Controls.Remove(_ctrl);

                LoadTemplates(tabCaseProcess.SelectedIndex);
            }

            if (tabCaseProcess.SelectedIndex != 4) return;
            listView2.Visible = false;
            listView3.Visible = false;
            listView4.Visible = false;
            listView5.Visible = false;

            _ctrl = Presenter.OnLoadPrescriptionCtrl().LastLoadedControl;
            pnlTemplate.Controls.Add(_ctrl);
        }

        private void CaseProcView_SizeChanged(object sender, EventArgs e)
        {
            OnSizeChanged();
        }

        private void CaseProcView_ResizeEnd(object sender, EventArgs e)
        {
            OnSizeChanged();
        }

        private void LoadTemplates(int type)
        {
            ConfigListView(type);
            LoadTemplate_Personal(type);
        }

        private void LoadTemplate_Personal(int type)
        {
            DataTable dt = Presenter.SelectTemplate(type);

            int cnt = 0;
            foreach (ListView l in _list)
            {
                cnt++;
                foreach (
                    ListViewItem lvi in
                        from DataRow r in dt.Rows select new ListViewItem(r[cnt].ToString()))
                {
                    l.Items.Add(lvi);
                }
            }
        }

        private void ConfigListView(int type)
        {
            foreach (ListView lst in _list)
            {
                lst.LabelEdit = true;
                lst.FullRowSelect = true;
                pnlTemplate.Controls.Add(lst);
            }

            switch (type)
            {
                case 0:
                    ClearListView();
                    listView2.Columns.Add("主诉", listView2.Width, HorizontalAlignment.Center);
                    listView3.Columns.Add("病史", listView3.Width, HorizontalAlignment.Center);
                    listView4.Columns.Add("既往史", listView4.Width, HorizontalAlignment.Center);
                    listView5.Columns.Add("关键字", listView5.Width, HorizontalAlignment.Center);
                    break;
                case 1:
                    ClearListView();
                    listView2.Columns.Add("", listView2.Width, HorizontalAlignment.Center);
                    listView3.Columns.Add("", listView3.Width, HorizontalAlignment.Center);
                    listView4.Columns.Add("", listView4.Width, HorizontalAlignment.Center);
                    listView5.Columns.Add("", listView5.Width, HorizontalAlignment.Center);
                    break;
                case 2:
                    ClearListView();
                    listView2.Columns.Add("", listView2.Width, HorizontalAlignment.Center);
                    listView3.Columns.Add("", listView3.Width, HorizontalAlignment.Center);
                    listView4.Columns.Add("", listView4.Width, HorizontalAlignment.Center);
                    listView5.Columns.Add("", listView5.Width, HorizontalAlignment.Center);
                    break;
                case 3:
                    ClearListView();
                    listView2.Columns.Add("", listView2.Width, HorizontalAlignment.Center);
                    listView3.Columns.Add("", listView3.Width, HorizontalAlignment.Center);
                    listView4.Columns.Add("", listView4.Width, HorizontalAlignment.Center);
                    listView5.Columns.Add("", listView5.Width, HorizontalAlignment.Center);
                    break;
            }
        }

        private void ClearListView()
        {
            foreach (ListView lvi in _list)
            {
                lvi.Clear();
            }
        }

        private void OnSizeChanged()
        {
            if (tabCaseProcess.SelectedIndex != 4)
            {
                int w = pnlTemplate.Width;

                listView2.Location = new Point(pnlTemplate.Location.X, listView2.Location.Y);
                listView2.Width = w / 4;
                listView3.Location = new Point(listView2.Location.X + listView2.Width, listView3.Location.Y);
                listView3.Width = w / 4;
                listView4.Location = new Point(listView3.Location.X + listView3.Width, listView4.Location.Y);
                listView4.Width = w / 4;
                listView5.Location = new Point(listView4.Location.X + listView4.Width, listView5.Location.Y);
                listView5.Width = w / 4;
            }
            else
            {
                _ctrl.Location = new Point(_ctrl.Location.X, pnlTemplate.Location.Y);
                _ctrl.Height = pnlTemplate.Height;
            }
            
        }

        private void btnModifyModel_Click(object sender, EventArgs e)
        {
            switch (cmbModelStyle.SelectedIndex)
            {
                case 0:
                    {
                        new TemplateOpView().Show();
                        break;
                    }
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        #region ICaseProcView Members

        public string PersonalContext
        {
            get { return txtPersonalContext.Text; }
            set { }
        }

        public string SickHistoryNow
        {
            get { return txtSickHistoryNow.Text; }
            set { }
        }

        public string SickHistoryBefore
        {
            get { return txtSickHistoryBefore.Text; }
            set { }
        }

        public string KeyWords
        {
            get { return txtKeywords.Text; }
            set { }
        }

        public string CheckInfo
        {
            get { return txtCheckContent1.Text; }
            set { }
        }

        public string DiagnoseInfo
        {
            get { return txtDiagnose.Text; }
            set { }
        }

        public string CureInfo
        {
            get { return txtCure.Text; }
            set { }
        }


        public void Exit()
        {
            Close();
        }

        #endregion
    }
}