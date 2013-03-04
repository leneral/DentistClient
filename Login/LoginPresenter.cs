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
                MessageA.ShowMessage("用户名不能为空！");
                return;
            }
            if (View.UserPassword == string.Empty)
            {
                MessageA.ShowMessage("密码不能为空！");
                return;
            }
            var us = new UserService();
            if (us.IsExisting(new User(View.UserName, View.UserPassword)))
            {
                View.Show();
            }
            else
            {
                MessageA.ShowMessage("用户名或密码错误！");
            }
        }

        public void Closing()
        {
            View.Exit();
        }
    }
}