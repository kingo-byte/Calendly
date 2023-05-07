using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Web.Configuration;
using Dapper;

namespace DAL
{
    internal class DapperAccess
    {
        private string connectionString = WebConfigurationManager.AppSettings["CONN_STRING"];
        public List<T> Execute<T>(string storedProcedure, object param)
        {   
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                return conn.Query<T>(storedProcedure, param, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public void ExecuteNonQuery(string storedProcedure, object param)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Query(storedProcedure, param, commandType: CommandType.StoredProcedure).ToList();
            }  
        }
    }
}
