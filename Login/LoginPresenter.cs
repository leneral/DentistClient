using Model.Message;
using Model.User;

namespace DentistryClient.Login
{
    public class LoginPresenter : Presenter
    {
        public ILoginView View { get; set; }

        public void Login()
        {
            if (View.UserName == string.Empty)
            {
                MessageA.ShowMessage("�û�������Ϊ�գ�");
                return;
            }
            if (View.UserPassword == string.Empty)
            {
                MessageA.ShowMessage("���벻��Ϊ�գ�");
                return;
            }
            var us = new UserService();
            if (us.IsExisting(new User(View.UserName, View.UserPassword)))
            {
                View.Show();
            }
            else
            {
                MessageA.ShowMessage("�û������������");
            }
        }

        public void Closing()
        {
            View.Exit();
        }
    }
}