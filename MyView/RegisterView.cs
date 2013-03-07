using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using DentistryClient.Register;
using DentistryClient.UserCtrl;
using Model.Patients;

namespace DentistryClient.MyView
{
    internal partial class RegisterView : Form, IRegisterView
    {
        public RegisterPresenter Presenter { get; set; }
        private readonly AddNewNodeEventHandler _mr;
        private string _image;

        public RegisterView(AddNewNodeEventHandler mr)
        {
            InitializeComponent();

            _mr = mr;
        }

        public RegisterView(PatientsInfo info)
        {
            InitializeComponent();

            CaseNo = info.CaseNo;
            PatientsName = info.Name;
            Sex = info.Sex;
            Age = info.Age;
            BirthTime = info.Birthtime;
            Folk = info.Folk;
            School = info.School;
            Phone = info.Phone;
            Mobilephone = info.Mobilephone;
            From = info.From;
            Email = info.Email;
            Address = info.Address;
            FavorMatter = info.FavorMatter;
            DislikeMatter = info.DislikeMatter;
            Cooperation = info.Cooperation;
            SelfControl = info.SelfControl;
            Other = info.Other;
             _image = info.Picture;

            ToUpdate = true;
            btnSave.Text = @"¸üÐÂ";
        }

        private void RegisterView_Load(object sender, EventArgs e)
        {
            if (!ToUpdate)
            {
                Presenter.GenNewCaseno();
            }
            if (_image.Length != 0)
            {
                byte[] photo = Convert.FromBase64String(_image);
                Picture = Presenter.GetImage(photo);
            }
            else
            {
                Picture = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Presenter.OnSave();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Presenter.OnClose();
        }

        private void picPhoto_Click(object sender, EventArgs e)
        {
            Picture = Presenter.ReadImage();
        }

        #region IPatientsRegister Members

        public string CaseNo
        {
            get { return txtCaseNo.Text.Trim(); }
            set { txtCaseNo.Text = value; }
        }

        public string PatientsName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public byte Sex
        {
            get { return cmbSex.SelectedIndex == 0 ? Convert.ToByte(1) : Convert.ToByte(0); }
            set { cmbSex.SelectedIndex = value; }
        }

        public int Age
        {
            get { return int.Parse(s: numUDAge.Value.ToString(CultureInfo.InvariantCulture)); }
            set { numUDAge.Value = value; }
        }

        public string From
        {
            get { return cmbFrom.Text; }
            set { cmbFrom.Text = value; }
        }

        public DateTime BirthTime
        {
            get { return dateTimeBirth.Value; }
            set { dateTimeBirth.Value = value; }
        }

        public string Folk
        {
            get { return txtFolk.Text; }
            set { txtFolk.Text = value; }
        }

        public string School
        {
            get { return txtSchool.Text; }
            set { txtSchool.Text = value; }
        }

        public string Phone
        {
            get { return txtPhone.Text; }
            set { txtPhone.Text = value; }
        }

        public string Mobilephone
        {
            get { return txtMobilePhone.Text; }
            set { txtMobilePhone.Text = value; }
        }

        public string Email
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }

        public string Address
        {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; }
        }

        public string FavorMatter
        {
            get { return txtFavorMatter.Text; }
            set { txtFavorMatter.Text = value; }
        }

        public string DislikeMatter
        {
            get { return txtDistasteMatter.Text; }
            set { txtDistasteMatter.Text = value; }
        }

        public string Cooperation
        {
            get { return txtCoorpration.Text; }
            set { txtCoorpration.Text = value; }
        }

        public string SelfControl
        {
            get { return txtSelfRegulating.Text; }
            set { txtSelfRegulating.Text = value; }
        }

        public string Other
        {
            get { return txtOtherSelfhood.Text; }
            set { txtOtherSelfhood.Text = value; }
        }

        public Image Picture
        {
            get { return picPhoto.Image; }
            set { picPhoto.Image = value; }
        }

        public bool ToUpdate { get; set; }

        public void ShowDlg()
        {
            ShowDialog();
        }

        public void RegisterCallback()
        {
            _mr(PatientsName);
        }

        public void Exit()
        {
            Close();
        }

        public void ShowInfoDlg(PatientsInfo info)
        {
            Presenter.ShowPatientInfoDlg(info);
        }

        #endregion
    }
}