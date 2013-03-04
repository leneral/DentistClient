namespace Model.User
{
    public class User
    {
        public User(string userName, string userPassword)
        {
            UserName = userName;
            UserPassword = userPassword;
        }

        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}
