using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using Model.Database;

namespace DentistryClient.MyView
{
    public partial class TemplateOperationView : Form
    {
        private int _selectIndex;
        readonly DataSet _storedDs = new DataSet();
        public TemplateOperationView()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCertain_Click(object sender, EventArgs e)
        {
            
        }

        private void FormChiefCaseHistory_Load(object sender, EventArgs e)
        {
            InitFormChiefCaseHistory();

            cmbContext.Text = cmbContext.Items[0].ToString();
            dgwDisplay.DataSource = _storedDs.Tables[0];
        }

        private void InitFormChiefCaseHistory()
        {
            InitDataset("chiefcomplaint");
            InitDataset("currentcasehistory");
            InitDataset("pastcasehistory");
            InitDataset("casekey");
        }

        private void InitDataset(string fieldname)
        {
            DataTable dt = new DataTable();
            string cmd = string.Format(@"SELECT {0} FROM chiefcomhistory",fieldname);
            dt = DoQuery(cmd);
            _storedDs.Tables.Add(dt);
        }

        

        private DataTable DoQuery(string cmd)
        {
            DbSingleton.Instance.ConnectDb(ConfigurationManager.AppSettings["DBNAME"]);
            DataTable dt = DbSingleton.Instance.RunQuery(cmd);
            DbSingleton.Instance.CloseDb();

            return dt;
        }

        private void cmbContext_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectIndex = cmbContext.SelectedIndex;
            switch (_selectIndex)
            {
                case 0:
                    dgwDisplay.DataSource = _storedDs.Tables[0];
                    break;
                case 1:
                    dgwDisplay.DataSource = _storedDs.Tables[1];
                    break;
                case 2:
                    dgwDisplay.DataSource = _storedDs.Tables[2];
                    break;
                case 3:
                    dgwDisplay.DataSource = _storedDs.Tables[3];
                    break;
            }
            dgwDisplay.Refresh();
        }
    }  
}
