using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using DentistryClient.DentistrySupervisor;

namespace DentistryClient.UserCtrl
{
    public delegate void AddNewNodeEventHandler(string name);

    public partial class TodayJobCtrl : UserControl, ITodayJobView
    {
        public TodayJobCtrl()
        {
            InitializeComponent();
        }

        public TodayJobPresenter Presenter { get; set; }

        public void AddNewNodeDeleg(string nodeName)
        {
            TreeNode tn = DateTime.Now.Hour < 12
                              ? treeTodayPatients.Nodes[0].Nodes[0]
                              : treeTodayPatients.Nodes[0].Nodes[1];

            tn.Nodes.Add(new TreeNode(nodeName));
            treeTodayPatients.ExpandAll();
        }

        public string SelectedCaseNo { get; set; }
        public string PatientName { get; set; }

        public string SearchWord
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }

        private void TodayJobCtrl_Load(object sender, EventArgs e)
        {
            LoadTodayPatients();
            LoadThisWeekOrders();
        }

        private void btnSuffererRegistrer_Click(object sender, EventArgs e)
        {
            Presenter.OnRegister();
        }

        private void btnCaseFill_Click(object sender, EventArgs e)
        {
            Presenter.OnFillCase();
        }

        private void btnOutProcess_Click(object sender, EventArgs e)
        {
            Presenter.OnOutProduce();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            Presenter.OnCharge();
        }

        private void lvPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPatients.SelectedItems.Count > 0)
            {
                SelectedCaseNo = lvPatients.SelectedItems[0].SubItems[0].Text;
                PatientName = lvPatients.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void lvPatients_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvPatients.SelectedItems.Count == 1)
            {
                switch (e.Button)
                {
                    case MouseButtons.Right:
                        int i = 1;
                        break;
                    case MouseButtons.Left:
                        PatientName = lvPatients.SelectedItems[0].SubItems[1].Text;
                        break;
                }
            }
        }

        private void treeTodayPatients_MouseClick(object sender, MouseEventArgs e)
        {
            TreeNode tn = treeTodayPatients.GetNodeAt(e.Location);
            if (tn.Name != "ndPreliminary" && tn.Name != "NodeFMorning"
                && tn.Name != "NodeFAfternoon" && tn.Name != "ndRetrial"
                && tn.Name != "NodeSMorning" && tn.Name != "NodeSAfternoon")
                PatientName = tn.Text;
        }

        private void tabSuffererInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabSuffererInfo.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    ShowSearched(Presenter.QueryAllPatients());
                    break;
                case 2:

                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowSearched(Presenter.Search());
        }

        private void LoadThisWeekOrders()
        {
            Hashtable orderHt = Presenter.QueryThisWeekOrders();

            foreach (DictionaryEntry item in orderHt)
            {
                string key = item.Key.ToString();
                string value = item.Value.ToString();

                var node = new TreeNode(key + "   " + value);
                treeOrder.Nodes[0].Nodes.Add(node);
            }

            treeOrder.ExpandAll();
        }

        private void LoadTodayPatients()
        {
            DataTable dt = Presenter.QueryTodayPatients();

            foreach (DataRow r in dt.Rows)
            {
                var node = new TreeNode(r[1].ToString());
                node.EnsureVisible();

                if (Convert.ToInt16(r[18]) < 12)
                    treeTodayPatients.Nodes[0].Nodes[0].Nodes.Add(node);
                else
                    treeTodayPatients.Nodes[0].Nodes[1].Nodes.Add(node);
            }
            treeTodayPatients.ExpandAll();
        }

        private void ShowSearched(DataTable dt)
        {
            lvPatients.Items.Clear();

            lvPatients.BeginUpdate();
            foreach (DataRow r in dt.Rows)
            {
                var li = new ListViewItem();
                li.SubItems[0].Text = r[0].ToString();

                li.SubItems.Add(r[1].ToString());
                string tmp = r[2].ToString() == "1" ? "男" : "女";
                li.SubItems.Add(tmp);

                li.SubItems.Add(r[3].ToString());
                li.SubItems.Add(r[17].ToString());
                lvPatients.Items.Add(li);
            }
            lvPatients.EndUpdate();
        }
    }
}