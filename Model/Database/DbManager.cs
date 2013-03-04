using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;

namespace Model.Database
{
    internal abstract class DbManager : IDbManager
    {
        protected const string StrServer = "Server";
        protected const string StrDataBase = "Data Source";
        protected const string StrUser = "UID";
        protected const string StrPwd = "PWD";
        protected const string StrConnTimeOut = "Connect Timeout = 2";
        private readonly DbType _type = DbType.Access;
        protected DbConnection Conn = null;

        protected DbManager(DbType type)
        {
            _type = type;
        }

        protected abstract DbDataAdapter DbAdp { get; }

        public DbType DbType
        {
            get { return _type; }
        }

        public void Connect(string strServer, string strDataBase, string strUser, string strPwd)
        {
            CreateConnection(strServer, strDataBase, strUser, strPwd);
        }

        public int RunNoQuery(string strCmd)
        {
            int ret = 0;

            try
            {
                DbCommand cmd = GetCmd(strCmd);
                if (cmd != null)
                {
                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return ret;
        }

        public DataTable RunQuery(string cmd)
        {
            var dt = new DataTable();
            DbDataAdapter adp = DbAdp;
            adp.SelectCommand = GetCmd(cmd);
            adp.Fill(dt);
            return dt;
        }

        public int GetFieldMax(string strTable, string strField)
        {
            string strSelect = @"Select Max(" + strField + ") From" + strTable;
            DataTable dt = RunQuery(strSelect);

            if (null != dt && dt.Rows.Count == 1)
                return dt.Rows[0][0] is DBNull ? 0 : Convert.ToInt32(dt.Rows[0][0]);

            return -1;
        }

        public void Close()
        {
            if (null != Conn && ConnectionState.Open == Conn.State)
                Conn.Close();
        }

        public bool IsConnected()
        {
            return Conn.State == ConnectionState.Open;
        }
        public abstract DataTable Tables { get; }
        public abstract DataTable GetColumns();
        public abstract DataTable GetColumns(string strTable);

        public void Open()
        {
            if (Conn == null) return;
            Conn.Open();
        }

        protected abstract void CreateConnection(string strServer, string strDataBase, string strUser, string strPwd);
        protected abstract DbCommand GetCmd(string strCmd);
    }
}
