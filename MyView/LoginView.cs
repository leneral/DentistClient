using System;
using System.Windows.Forms;
using DentistryClient.Login;

namespace DentistryClient.MyView
{
    public partial class LoginView : Form, ILoginView
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public LoginPresenter Presenter { set; private get; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Presenter.Login();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Presenter.Closing();
        }

        #region ILoginView Members

        public string UserName
        {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; }
        }

        public string UserPassword
        {
            get { return txtPWD.Text; }
            set { txtPWD.Text = value; }
        }


        public new void Show()
        {
            _name = UserName;
            DialogResult = DialogResult.OK;
        }

        public void Exit()
        {
            Close();
        }

        #endregion
    }
}