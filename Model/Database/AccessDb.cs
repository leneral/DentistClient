using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;

namespace Model.Database
{
    internal class AccessDb : DbManager
    {
        public AccessDb()
            : base(DbType.Access)
        {
        }

        protected override DbDataAdapter DbAdp
        {
            get { return new OleDbDataAdapter(); }
        }

        public override DataTable Tables
        {
            get
            {
                return ((OleDbConnection)Conn).GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                                                                    new object[] { null, null, null, "Table" });
            }
        }

        protected override void CreateConnection(string strServer, string strDataBase, string strUser, string strPwd)
        {
            string strConn = "Provider = ";
            switch (strDataBase.Substring(strDataBase.LastIndexOf('.') + 1).ToLower())
            {
                case "mdb": // 2000, 2003
                    strConn += "Microsoft.Jet.OleDb.4.0;";
                    break;

                case "accdb": // 2007
                    strConn += "Microsoft.ACE.OLEDB.12.0;";
                    break;

                default:
                    throw (new Exception("Unknown Access Version."));
                //break;
            }
            strConn += StrDataBase + " = " + strDataBase;
            //strConn += CON_strUser + " = " + strUser;
            //strConn += CON_strPwd + " = " + strPwd;
            Conn = new OleDbConnection(strConn);
        }

        protected override DbCommand GetCmd(string strCmd)
        {
            return new OleDbCommand(strCmd, (OleDbConnection)Conn);
        }

        public override DataTable GetColumns()
        {
            var dt = new DataTable();
            foreach (DataRow row in Tables.Rows)
            {
                dt.Merge(GetColumns(row["TABLE_NAME"].ToString()));
            }
            return dt;
        }

        public override DataTable GetColumns(string strTable)
        {
            return ((OleDbConnection)Conn).GetOleDbSchemaTable(OleDbSchemaGuid.Columns,
                                                                new object[] { null, null, strTable, null });
        }
    }
}
