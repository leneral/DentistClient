using System;
using System.Data;
using System.Windows.Forms;
using DentistryClient.Selection;

namespace DentistryClient.MyView
{
    public partial class SelectionView : Form, ISelectionView
    {
        public SelectionView()
        {
            InitializeComponent();
        }

        public SelectionPresenter Presenter { get; set; }

        public string SearchWord
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }

        public string SelectedCaseNo { get; set; }
        public string SelectedName { get; set; }

        private void FormPatientSelect_Load(object sender, EventArgs e)
        {
            ShowTodayPatients();
            ShowAllPatients();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Presenter.OnSelect();
            Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            ShowPatientsInfo(Presenter.Search(), lvAllPatients);
        }

        private void lvAllPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTodayPatients.SelectedItems.Count > 0)
            {
                SelectedCaseNo = lvAllPatients.SelectedItems[0].SubItems[0].Text;
                SelectedName = lvAllPatients.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void lvTodayPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTodayPatients.SelectedItems.Count > 0)
            {
                SelectedCaseNo = lvTodayPatients.SelectedItems[0].SubItems[0].Text;
                SelectedName = lvTodayPatients.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void lvTodayPatients_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvTodayPatients.SelectedItems.Count == 1)
            {
                SelectedCaseNo = lvTodayPatients.SelectedItems[0].SubItems[0].Text;
                SelectedName = lvTodayPatients.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void lvAllPatients_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvAllPatients.SelectedItems.Count == 1)
            {
                SelectedCaseNo = lvAllPatients.SelectedItems[0].SubItems[0].Text;
                SelectedName = lvAllPatients.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowTodayPatients()
        {
            ShowPatientsInfo(Presenter.QueryTodayPatients(), lvTodayPatients);
        }

        private void ShowAllPatients()
        {
            ShowPatientsInfo(Presenter.QueryAllPatients(), lvAllPatients);
        }

        private void ShowPatientsInfo(DataTable dt, ListView list)
        {
            if(dt == null) return;
            list.Items.Clear();
            list.BeginUpdate();
            foreach (DataRow r in dt.Rows)
            {
                var item = new ListViewItem();

                item.SubItems[0].Text = r[0].ToString();
                item.SubItems.Add(r[1].ToString());

                list.Items.Add(item);
            }
            list.EndUpdate();
        }
    }
}