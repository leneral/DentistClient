namespace DentistryClient.Login
{
    public interface ILoginView : IView
    {
        string UserName { get; set; }
        string UserPassword { get; set; }

        LoginPresenter Presenter { set; }

        void Show();
    }
}