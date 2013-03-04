using System.Data;
using System.Data.Common;
using System.Data.OleDb;

namespace Model.Database
{
    public interface IDbManager
    {
        DbType DbType { get; }
        DataTable Tables { get; }
        void Connect(string strServer, string strDbName, string strUser, string strPwd);

        void Open();

        void Close();

        bool IsConnected();

        int RunNoQuery(string cmd);

        DataTable RunQuery(string cmd);

        int GetFieldMax(string strTable, string strField);

        DataTable GetColumns();

        DataTable GetColumns(string strTable);
    }
}
