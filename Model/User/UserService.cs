using System.Configuration;
using System.Data;
using System.Linq;
using Model.Database;

namespace Model.User
{
    public class UserService
    {
        public bool IsExisting(User user)
        {
            DataTable dt = DbSingleton.Instance.RunQuery(@"Select * from [user]");

            DataRow[] dr = dt.Select("username = '" + user.UserName + "'");
            if (dr.Any(r => r[2].ToString() == user.UserPassword))
                return true;
            return false;
        }

        public bool AddUser(string username, string password)
        {
            return true;
        }

        public bool DeleteUser(string username, string password)
        {
            return true;
        }
    }
}
