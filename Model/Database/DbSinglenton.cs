using System.Data;

namespace Model.Database
{
    public sealed class DbSingleton
    {
        private static DbSingleton _instance;

        private readonly IDbManager _db;

        private DbSingleton()
        {
            _db = DbFactory.Create(DbType.Access);
        }

        public static DbSingleton Instance
        {
            get { return _instance ?? (_instance = new DbSingleton()); }
        }

        public void ConnectDb(string dbname)
        {
            _db.Connect("", dbname, "", "");
            _db.Open();
        }

        public void CloseDb()
        {
            _db.Close();
        }

        public void RunNoQuery(string cmd)
        {
            ConnectDb("..\\..\\database\\Dentist.accdb");
            _db.RunNoQuery(cmd);
            CloseDb();
        }

        public DataTable RunQuery(string cmd)
        {
            ConnectDb("..\\..\\database\\Dentist.accdb");
            DataTable dt = _db.RunQuery(cmd);
            CloseDb();

            return dt;
        }

    }
}
