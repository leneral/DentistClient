namespace Model.Database
{
    class DbFactory
    {
        public static IDbManager Create(DbType type)
        {
            IDbManager ret = null;

            switch (type)
            {
                case DbType.Access:
                    ret = new AccessDb();
                    break;
                case DbType.Sqlserver:
                    //                   ret = new SqlServer();
                    break;
            }

            return ret;
        }
    }
}
